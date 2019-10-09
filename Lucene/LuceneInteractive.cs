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

class LuceneInteractive
    {

        Lucene.Net.Store.Directory luceneIndexDirectory;
        Lucene.Net.Analysis.Analyzer analyzer;
        Lucene.Net.Index.IndexWriter writer;
        IndexSearcher searcher;
        QueryParser parser;
    //private object JsonConvert;
        
        const Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;
        const string TEXT_FN = "Text";

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
            Lucene.Net.Documents.Document doc = new Document();
            doc.Add(field);
            writer.AddDocument(doc);
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
        public void CreateSearcher()
        {
            searcher = new IndexSearcher(luceneIndexDirectory);
        }

        /// <summary>
        /// Searches the index for the querytext
        /// </summary>
        /// <param name="querytext">The text to search the index</param>
        public TopDocs SearchText(string querytext)
        {

            System.Console.WriteLine("Searching for " + querytext);
            querytext = querytext.ToLower();
            Query query = parser.Parse(querytext);

            TopDocs results = searcher.Search(query, 100);

            return results;
        }


        /// <summary>
        /// Displays a ranked list of results to the screen
        /// </summary>
        /// <param name="results">A set of results</param>
        public List<string> DisplayResults(TopDocs results)
        {

            int rank = 0;
        List<string> rankResult = new List<string>();
            foreach (ScoreDoc scoreDoc in results.ScoreDocs)
            {
                rank++;
                Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
                string myFieldValue = doc.Get(TEXT_FN).ToString();
                rankResult.Add("Rank " + rank + " text: " + myFieldValue);
                //hsuan +=  "Rank " + rank + " text " + myFieldValue +"\n";
            }
        return rankResult;
        }


        /// <summary>
        /// Print document detils to the screen
        /// </summary>
        /// <param name="results">Set of results for a query</param>
        /// <param name="docNum">A document number</param>
        public void DisplayOneResult(TopDocs results, int resultIndex)
        {
            ScoreDoc scoreDoc = results.ScoreDocs[resultIndex];
            Lucene.Net.Documents.Document doc = searcher.Doc(scoreDoc.Doc);
            string myFieldValue = doc.Get(TEXT_FN).ToString();
            Console.WriteLine("DocNum " + resultIndex + " text " + myFieldValue);
        }


        /// <summary>
        /// Closes the index after searching
        /// </summary>
        public void CleanUpSearcher()
        {
            searcher.Dispose();
        }

    public List<IndividualCollection> collectString(string path) {

        //string pathdicectory = @"C:\Users\wangh\OneDrive\桌面\IFN647_Assignment2\Sample.json";
        string pathdicectory = path;
        // Input Json to string and then using list to store
        System.IO.TextReader reader = new System.IO.StreamReader(pathdicectory);
        string text = reader.ReadToEnd();
        reader.Close();

        List<IndividualCollection> hsuan = JsonConvert.DeserializeObject<List<IndividualCollection>>(text);

        //IndividualCollection p2 = hsuan[0];


        return hsuan;
    }


    //----------------------------------------------------------------------------


    //-----------------------------------------------------------------------------
    public List<string> activateIndex(string query,string path)
        {

        

        List<IndividualCollection> hsuan = collectString(path);


        // source collection
        List<string> l = new List<string>();
        for (int i =0;i<=4;i++) {
            l.Add(hsuan[i].passage_text + hsuan[i].passage_ID);
        }



        // Index code
        string indexPath = @"C:\Users\wangh\OneDrive\桌面\IFN647_Assignment2\Week8\HsuanIndex";
            LuceneInteractive myLuceneApp = new LuceneInteractive();
            myLuceneApp.CreateIndex(indexPath);
            
            foreach (string s in l)
            {
                myLuceneApp.IndexText(s);
            }
            
            myLuceneApp.CleanUpIndexer();

            myLuceneApp.CreateSearcher();
            TopDocs results = myLuceneApp.SearchText(query);
            
           return  myLuceneApp.DisplayResults(results);
        // return myLuceneApp.DisplayResults(results);

        //// Activity 7
            //myLuceneApp.DisplayOneResult(results, 0);
            //myLuceneApp.DisplayOneResult(results, 1);
            //myLuceneApp.DisplayOneResult(results, 2);

        //// Activity 8
        //Console.WriteLine("Enter the rank index for the result you wish to view: ");
        //string myText = Console.ReadLine();
           // int myInt = Int32.Parse(query);
           //myLuceneApp.DisplayOneResult(results, myInt);

        //Console.ReadLine();
        //myLuceneApp.CleanUpSearcher();


    }
    }

