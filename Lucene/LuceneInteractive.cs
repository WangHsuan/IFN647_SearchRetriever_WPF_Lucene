using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis; // for Analyser
using Lucene.Net.Documents; // for Document and Field
using Lucene.Net.Index; //for Index Writer
using Lucene.Net.Store; //for Directory
using Lucene.Net.Search; // for IndexSearcher
using Lucene.Net.QueryParsers;  // for QueryParser
using WindowsFormsApplication1.Collection;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;
using System.Threading;
using Newtonsoft.Json.Linq;

class LuceneInteractive
    {

        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
        

        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TITLE_FN = "Title";
        const string AUTHOR_FN = "Author";
        const string TEXT_FN = "Text";
        public string IndexingTime { get; set; }
        public string IndexPath { get; set; }
        public LuceneInteractive()
            {
                luceneIndexDirectory = null;
                writer = null;
                analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
                parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, TEXT_FN, analyzer);
                
            }


    /// <summary>
    /// Creates the index at a given path
    /// </summary>
    /// <param name="indexPath">The pathname to create the index</param>
    public void CreateIndex(string indexPath)
        {
            luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);
            writer = new Lucene.Net.Index.IndexWriter(luceneIndexDirectory, analyzer, true, mfl);
        }


        /// <summary>
        /// Indexes a given string into the index
        /// </summary>
        /// <param name="text">The text to index</param>
        public void IndexText(string text)
        {

        Lucene.Net.Documents.Field field = new Field(TEXT_FN, text, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.YES);
        //Lucene.Net.Documents.Field authorField = new Field(AUTHOR_FN, author, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        //Lucene.Net.Documents.Field titleField = new Field(TITLE_FN, title, Field.Store.YES, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS);
        Lucene.Net.Documents.Document doc = new Document();
        doc.Add(field);
        //  doc.Boost = (float) pagerank; // Activity 5
        writer.AddDocument(doc);
        //doc.Add(authorField);
        //doc.Add(titleField);
        //doc.Boost = (float)pagerank; // Activity 5
        //writer.AddDocument(doc);
    }


        /// <summary>
        /// Flushes the buffer and closes the index
        /// </summary>
        public void CleanUpIndexer()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }


        /// <summary>
        /// Creates the searcher object
        /// </summary>
        public void CreateSearcher(string indexPath)
        {
        luceneIndexDirectory = Lucene.Net.Store.FSDirectory.Open(IndexPath);
        searcher = new IndexSearcher(luceneIndexDirectory);
        }

       

        public List<string> SearchAndDisplayResults(string querytext)
        {
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);
            TopDocs results = searcher.Search(query, 100);

            int rank = 0;
            List<string> rankResult = new List<string>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
            string myFieldValue = doc.Get(TEXT_FN).ToString();
            rankResult.Add("Rank " + rank + " title " + myFieldValue);

            //string titleValue = doc.Get(TITLE_FN).ToString();
            //string authorValue = doc.Get(AUTHOR_FN).ToString();
            //Console.WriteLine("Rank " + rank + " title " + titleValue + " author " + authorValue);
            //rankResult.Add("Rank " + rank + " title " + titleValue + " author " + authorValue);
        }
       
        return rankResult;

    }
        

        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearcher()
            {
                searcher.Dispose();
            }

        public List<string> collectString(string path)
        {
        //-------------------------------------------------------------------------------------------------
        //string pathdicectory = @"C:\Users\wangh\OneDrive\桌面\IFN647_Assignment2\Sample.json";
        string pathdicectory = path;
        // Input Json to string and then using list to store
        System.IO.TextReader reader = new System.IO.StreamReader(pathdicectory);
        string text = reader.ReadToEnd();
        reader.Close();
        List<IndividualCollection> hsuan = JsonConvert.DeserializeObject<List<IndividualCollection>>(text);

        //--------------------------------------------------------------------------------------------------
       
        string hsuanJson = "";
        int arrayNumber = 0;
        string deArray = "";
        List<string> returnList = new List<string>();
        List<IndividualCollection> hsuanJsonList = new List<IndividualCollection>();
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        using (StreamReader sr = new StreamReader(fs))
        using (JsonTextReader Jsonreader = new JsonTextReader(sr))
        {
            while (Jsonreader.Read())
            {
                if (Jsonreader.TokenType == JsonToken.StartObject)
                {
                    // Load each object from the stream and do something with it
                    JObject obj = JObject.Load(Jsonreader);
                    //Console.WriteLine(obj["passages"]);
                    deArray = obj["passages"].ToString();
                    hsuanJsonList = JsonConvert.DeserializeObject<List<IndividualCollection>>(deArray);
                    for (int i =0; i<hsuanJsonList.Count();i++) {
                        returnList.Add(hsuanJsonList[i].passage_text);
                        //Console.WriteLine(hsuanJsonList[i].passage_text + hsuanJsonList[i].passage_ID);
                    }
                    arrayNumber++;
                }
            }
           
        }
        //Console.WriteLine(hsuanJson);
        //for (int i =0; i<returnList.Count();i++) {
        //    Console.WriteLine(returnList[i]);
        //}

        //-----------------------------------------------------------------------------------------------
        return returnList;

    }


    //----------------------------------------------------------------------------
    /// Creates a Thesuaris of stems
    public Dictionary<string, string[]> CreateThesaurus()
    {
        Dictionary<string, string[]> thesaurus = new Dictionary<string, string[]>();

        thesaurus.Add("walk", new[] { "walk", "walked", "walking" });
        thesaurus.Add("run", new[] { "run", "running" });
        thesaurus.Add("love", new[] { "love", "lovely", "loving" });
        return thesaurus;
    }
    /// Expands the query with terms in the thesaurus
    public string GetExpandedQuery(Dictionary<string, string[]> thesaurus, string queryTerm)
    {
        string expandedQuery = "";
        if (thesaurus.ContainsKey(queryTerm))
        {
            string[] array = thesaurus[queryTerm];
            foreach (string a in array)
            {
                expandedQuery += " " + a;
            }
        }
        return expandedQuery;
    }
    /// Expands the query with terms in the thesaurus but weights the original term the highest
    public string GetWeightedExpandedQuery(Dictionary<string, string[]> thesausus, string query)
    {
        string expandedQuery = "";
        if (thesausus.ContainsKey(query))
        {
            bool first = true;
            string[] array = thesausus[query];
            foreach (string a in array)
            {
                expandedQuery += " " + a;
                if (first)
                {
                    expandedQuery += "^5";
                    first = false;
                }
            }
        }
        return expandedQuery;
    }
    //-----------------------------------------------------------------------------
    public void activateIndex(string path)
        {
        LuceneInteractive myLuceneApp = new LuceneInteractive();

        //List<IndividualCollection> collectionList = collectString(path);
        List<string> l = collectString(path);
        for (int i =0; i<l.Count();i++) {
            Console.WriteLine(l[i]);
        }
        // source collection
        //List<string> l = new List<string>();
        //System.Console.WriteLine(collectionList.Count());
        //for (int i =0;i< collectionList.Count(); i++) {
        //    l.Add(collectionList[i].passage_text + collectionList[i].passage_ID);
           
        //}
        System.Console.WriteLine(l.Count());
        // Index code
        IndexPath = @"C:\Users\wangh\OneDrive\桌面\IFN647_Assignment2\Week8\HsuanIndex";
           // LuceneInteractive myLuceneApp = new LuceneInteractive();
            DateTime Indexingstart = System.DateTime.Now;
            myLuceneApp.CreateIndex(IndexPath);            
            foreach (string s in l)
            {
                myLuceneApp.IndexText(s);
            }
            
            myLuceneApp.CleanUpIndexer();
            DateTime IndexingEnd = System.DateTime.Now;
            IndexingTime = (IndexingEnd - Indexingstart).ToString();


           // myLuceneApp.CreateSearcher();
           //return  myLuceneApp.SearchAndDisplayResults(query);
        
        //myLuceneApp.CleanUpSearcher();


    }
}

