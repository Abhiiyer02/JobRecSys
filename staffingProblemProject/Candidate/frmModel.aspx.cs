using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Collections;
using System.Threading;
using System.Configuration;
using Accord.MachineLearning;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Statistics.Kernels;
using Accord.IO;
using Accord.MachineLearning.Performance;
using Accord.Math.Optimization.Losses;
using Accord.MachineLearning.Bayes;
using Accord.Statistics.Distributions.Univariate;
using System.Reflection.Emit;


namespace staffingProblemProject
{
    public partial class frmModel : System.Web.UI.Page
    {
        public static OleDbConnection oledbConn;
        DataTable dt = new DataTable();
        DataTable dtDistinct = new DataTable();
        static ArrayList _arrayPatientsCnt = new ArrayList();
        DataTable actualdt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserId"] == null)
                {
                    Session.Abandon();
                    Response.Redirect("../Guest/Index.aspx");
                }
                else
                {
                    TestingDS();
                    ActualDS();
                }
                
            }
            catch
            {

            }
        }
              
        private void TestingDS()
        {
            string FileName = "TestingDataset" + ".xlsx";

            string Extension = ".xlsx";

            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

            string _Location = "TestingDataset";

            string FilePath = Server.MapPath(FolderPath + FileName);

            ImportTestingDS(FilePath, Extension, _Location);
        }

        private void ImportTestingDS(string FilePath, string Extension, string _Location)
        {
            string conStr = "";

            switch (Extension)
            {

                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, _Location);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();

            cmdExcel.Connection = connExcel;

            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

            connExcel.Close();



            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";

            oda.SelectCommand = cmdExcel;

            oda.Fill(dt);

            //BLL obj = new BLL();

            if (dt.Rows.Count > 0)
            {

                //Bind Data to GridView

                GridView1.Caption = Path.GetFileName(FilePath);

                GridView1.DataSource = dt;

                GridView1.DataBind();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<Script>alert('No Testing Dataset Found!!!')</script>");
            }



            connExcel.Close();

        }

        private void ActualDS()
        {
            string FileName = "ActualDataset" + ".xlsx";

            string Extension = ".xlsx";

            string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

            string _Location = "ActualDataset";

            string FilePath = Server.MapPath(FolderPath + FileName);

            ImportActualDS(FilePath, Extension, _Location);
        }

        private void ImportActualDS(string FilePath, string Extension, string _Location)
        {
            string conStr = "";

            switch (Extension)
            {

                case ".xls": //Excel 97-03

                    conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                             .ConnectionString;

                    break;

                case ".xlsx": //Excel 07

                    conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                              .ConnectionString;

                    break;

            }

            conStr = String.Format(conStr, FilePath, _Location);

            OleDbConnection connExcel = new OleDbConnection(conStr);

            OleDbCommand cmdExcel = new OleDbCommand();

            OleDbDataAdapter oda = new OleDbDataAdapter();

            DataTable dt = new DataTable();

            cmdExcel.Connection = connExcel;

            //Get the name of First Sheet

            connExcel.Open();

            DataTable dtExcelSchema;

            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

            connExcel.Close();



            //Read Data from First Sheet

            connExcel.Open();

            cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";

            oda.SelectCommand = cmdExcel;

            oda.Fill(actualdt);

            connExcel.Close();

        }

        protected void btnPrediction_Click(object sender, EventArgs e)
        {
            try
            {
                string FileName = "TestingDataset" + ".xlsx";

                string Extension = ".xlsx";

                string FolderPath = ConfigurationManager.AppSettings["FolderPath"];

                string _Location = "TestingDataset";

                string FilePath = Server.MapPath(FolderPath + FileName);

                string conStr = "";

                switch (Extension)
                {

                    case ".xls": //Excel 97-03

                        conStr = ConfigurationManager.ConnectionStrings["Excel03ConString"]

                                 .ConnectionString;

                        break;

                    case ".xlsx": //Excel 07

                        conStr = ConfigurationManager.ConnectionStrings["Excel07ConString"]

                                  .ConnectionString;

                        break;

                }

                conStr = String.Format(conStr, FilePath, _Location);

                OleDbConnection connExcel = new OleDbConnection(conStr);

                OleDbCommand cmdExcel = new OleDbCommand();

                OleDbDataAdapter oda = new OleDbDataAdapter();

                DataTable tabData = new DataTable();

                cmdExcel.Connection = connExcel;

                //Get the name of First Sheet

                connExcel.Open();

                DataTable dtExcelSchema;

                dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                string SheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();

                connExcel.Close();



                //Read Data from First Sheet

                connExcel.Open();

                cmdExcel.CommandText = "SELECT * From [" + SheetName + "]";

                oda.SelectCommand = cmdExcel;

                oda.Fill(tabData);

                //BLL obj = new BLL();

                int slNo = 1;

                if (tabData.Rows.Count > 0)
                {
                    Session["Output"] = null;
                    string _Predictedoutput = null;
                    string _timeNB = null;

                    tablePrediction.Rows.Clear();

                    tablePrediction.BorderStyle = BorderStyle.Double;
                    tablePrediction.GridLines = GridLines.Both;
                    tablePrediction.BorderColor = System.Drawing.Color.Black;

                    TableRow mainrow = new TableRow();
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;
                    mainrow.BackColor = System.Drawing.Color.SteelBlue;

                    TableCell cell0 = new TableCell();
                    cell0.Width = 100;
                    cell0.Text = "<b>SlNo</b>";
                    mainrow.Controls.Add(cell0);

                    TableCell cell1 = new TableCell();
                    cell1.Text = "<b>SSLC</b>";
                    mainrow.Controls.Add(cell1);

                    TableCell cell2 = new TableCell();
                    cell2.Text = "<b>Pre-University</b>";
                    mainrow.Controls.Add(cell2);

                    TableCell cell3 = new TableCell();
                    cell3.Text = "<b>Communication</b>";
                    mainrow.Controls.Add(cell3);

                    TableCell cell4 = new TableCell();
                    cell4.Text = "<b>Problem Solving</b>";
                    mainrow.Controls.Add(cell4);

                    TableCell cell5 = new TableCell();
                    cell5.Text = "<b>Networks</b>";
                    mainrow.Controls.Add(cell5);


                    TableCell cell6 = new TableCell();
                    cell6.Text = "<b>Operating Systems</b>";
                    mainrow.Controls.Add(cell6);

                    TableCell cell7 = new TableCell();
                    cell7.Text = "<b>DBMS</b>";
                    mainrow.Controls.Add(cell7);

                    TableCell cell8 = new TableCell();
                    cell8.Text = "<b>DSA</b>";
                    mainrow.Controls.Add(cell8);

                    TableCell cell9 = new TableCell();
                    cell9.Text = "<b>Cloud Computing</b>";
                    mainrow.Controls.Add(cell9);

                    TableCell cell10 = new TableCell();
                    cell10.Text = "<b>Containers</b>";
                    mainrow.Controls.Add(cell10);


                    TableCell cell11 = new TableCell();
                    cell11.Text = "<b>System Design</b>";
                    mainrow.Controls.Add(cell11);

                    TableCell cell12 = new TableCell();
                    cell12.Text = "<b>Mathematics</b>";
                    mainrow.Controls.Add(cell12);

                    TableCell cell13 = new TableCell();
                    cell13.Text = "<b>Version Control Systems</b>";
                    mainrow.Controls.Add(cell13);

                    TableCell cell14 = new TableCell();
                    cell14.Text = "<b>Python</b>";
                    mainrow.Controls.Add(cell14);

                    TableCell cell15 = new TableCell();
                    cell15.Text = "<b>JavaScript/TypeScript</b>";
                    mainrow.Controls.Add(cell15);


                    TableCell cell116 = new TableCell();
                    cell116.Text = "<b>C/C++/C#</b>";
                    mainrow.Controls.Add(cell116);

                    TableCell cell17 = new TableCell();
                    cell17.Text = "<b>Java</b>";
                    mainrow.Controls.Add(cell17);


                    TableCell cell18 = new TableCell();
                    cell18.Text = "<b>NB Prediction</b>";
                    mainrow.Controls.Add(cell18);

                    TableCell cell19 = new TableCell();
                    cell19.Text = "<b>RF Prediction</b>";
                    mainrow.Controls.Add(cell19);

                    TableCell cell20 = new TableCell();
                    cell20.Text = "<b>Actual Result</b>";
                    mainrow.Controls.Add(cell20);

                    tablePrediction.Controls.Add(mainrow);

                    string[] RFPredictions = NaiveBayesRandomForest("RF")[0];
                    string[] NBPredictions = NaiveBayesRandomForest("NB")[0];

                    for (int i = 0; i < tabData.Rows.Count; i++)
                    {

                        TableRow row = new TableRow();

                        TableCell _cell0 = new TableCell();
                        _cell0.Text = slNo + i + ".";
                        row.Controls.Add(_cell0);

                        TableCell _cell1 = new TableCell();
                        _cell1.Text = tabData.Rows[i]["SSLC"].ToString();
                        row.Controls.Add(_cell1);

                         TableCell _cell2 = new TableCell();
                        _cell2.Text = tabData.Rows[i]["Pre-University"].ToString();
                        row.Controls.Add(_cell2);

                        TableCell _cell3 = new TableCell();
                        _cell3.Text = tabData.Rows[i]["Communication"].ToString();
                        row.Controls.Add(_cell3);

                        TableCell _cell4 = new TableCell();
                        _cell4.Text = tabData.Rows[i]["Problem Solving"].ToString();
                        row.Controls.Add(_cell4);

                        TableCell _cell5 = new TableCell();
                        _cell5.Text = tabData.Rows[i]["Networks"].ToString();
                        row.Controls.Add(_cell5);

                        TableCell _cell6 = new TableCell();
                        _cell6.Text = tabData.Rows[i]["Operating Systems"].ToString();
                        row.Controls.Add(_cell6);

                        TableCell _cell7 = new TableCell();
                        _cell7.Text = tabData.Rows[i]["DBMS"].ToString();
                        row.Controls.Add(_cell7);

                        TableCell _cell8 = new TableCell();
                        _cell8.Text = tabData.Rows[i]["DSA"].ToString();
                        row.Controls.Add(_cell8);


                        TableCell _cell9 = new TableCell();
                        _cell9.Text = tabData.Rows[i]["Cloud Computing"].ToString();
                        row.Controls.Add(_cell9);

                        TableCell _cell10 = new TableCell();
                        _cell10.Text = tabData.Rows[i]["Containers"].ToString();
                        row.Controls.Add(_cell10);

                        TableCell _cell11 = new TableCell();
                        _cell11.Text = tabData.Rows[i]["System Design"].ToString();
                        row.Controls.Add(_cell11);

                        TableCell _cell12 = new TableCell();
                        _cell12.Text = tabData.Rows[i]["Mathematics"].ToString();
                        row.Controls.Add(_cell12);

                        TableCell _cell13 = new TableCell();
                        _cell13.Text = tabData.Rows[i]["Version Control Systems"].ToString();
                        row.Controls.Add(_cell13);

                        TableCell _cell14 = new TableCell();
                        _cell14.Text = tabData.Rows[i]["Python"].ToString();
                        row.Controls.Add(_cell14);

                        TableCell _cell15 = new TableCell();
                        _cell15.Text = tabData.Rows[i]["JavaScript/TypeScript"].ToString();
                        row.Controls.Add(_cell15);

                        TableCell _cell16 = new TableCell();
                        _cell16.Text = tabData.Rows[i]["C/C++/C#"].ToString();
                        row.Controls.Add(_cell16);

                        TableCell _cell17 = new TableCell();
                        _cell17.Text = tabData.Rows[i]["Java"].ToString();
                        row.Controls.Add(_cell17);

                        TableCell _cell18 = new TableCell();
                        _cell18.Width = 250;
                        _cell18.Text = NBPredictions[i];
                        row.Controls.Add(_cell18);

                        TableCell _cell19 = new TableCell();
                        _cell19.Width = 250;
                        _cell19.Text = RFPredictions[i];
                        row.Controls.Add(_cell18);

                        TableCell _cell20 = new TableCell();
                        _cell20.Width = 250;
                        _cell20.Text = actualdt.Rows[i]["Result"].ToString();
                        row.Controls.Add(_cell20);

                        tablePrediction.Controls.Add(row);
                    }

                    _Results();

                }
            }
            catch
            {

            }
        }

        
        protected void btnResults_Click(object sender, EventArgs e)
        {
            btnPrediction_Click(sender, e);
            Response.Redirect("frmResults.aspx");
        }
        

        double _outcomeCntNB = 0;
        string _timeNB = null;
        int _ActualCnt = 0;

        private void _Results()
        {
            Table1.Rows.Clear();

            Table1.BorderStyle = BorderStyle.Double;
            Table1.GridLines = GridLines.Both;
            Table1.BorderColor = System.Drawing.Color.Black;

            //mainrow
            TableRow mainrow = new TableRow();
            mainrow.Height = 30;
            mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

            mainrow.BackColor = System.Drawing.Color.SteelBlue;

            TableCell cell1 = new TableCell();
            cell1.Width = 350;
            cell1.Text = "<b>Constraints</b>";
            mainrow.Controls.Add(cell1);

            TableCell cell2 = new TableCell();
            cell2.Width = 200;
            cell2.Text = "<b>Naive Bayes Algorithm</b>";
            mainrow.Controls.Add(cell2);

            TableCell cell3 = new TableCell();
            cell3.Width = 200;
            cell3.Text = "<b>Random Forest Algorithm</b>";
            mainrow.Controls.Add(cell3);

            Table1.Controls.Add(mainrow);

            //CompareResults();

            //1st row
            TableRow row1 = new TableRow();

            TableCell cellAcc = new TableCell();
            cellAcc.Text = "<b>Accuracy</b>";
            row1.Controls.Add(cellAcc);

            TableCell cellAccNB = new TableCell();
            double _percentageNB = double.Parse(NaiveBayesRandomForest("NB")[1][0]);
            cellAccNB.Text = _percentageNB.ToString() + "%";
            row1.Controls.Add(cellAccNB);

            TableCell cellAccRF = new TableCell();
            double _percentageRF = double.Parse(NaiveBayesRandomForest("RF")[1][0]);
            cellAccRF.Text = _percentageRF.ToString() + "%";
            row1.Controls.Add(cellAccRF);

            Table1.Controls.Add(row1);

            //2nd row           
            TableRow row2 = new TableRow();

            TableCell cellTime = new TableCell();
            cellTime.Text = "<b>Time (milli secs)</b>";
            row2.Controls.Add(cellTime);

            TableCell cellTimeNB = new TableCell();
            cellTimeNB.Text = NaiveBayesRandomForest("NB")[1][1];
            row2.Controls.Add(cellTimeNB);

            TableCell cellTimeRF = new TableCell();
            cellTimeRF.Text = NaiveBayesRandomForest("RF")[1][1];
            row2.Controls.Add(cellTimeRF);

            Table1.Controls.Add(row2);

            //3rd row           
            TableRow row3 = new TableRow();

            TableCell cellCorrect = new TableCell();
            cellCorrect.Text = "<b>Correctly Classified</b>";
            row3.Controls.Add(cellCorrect);

            TableCell cellCorrectNB = new TableCell();
            cellCorrectNB.Text = _percentageNB.ToString() + "%";
            row3.Controls.Add(cellCorrectNB);

            TableCell cellCorrectRF = new TableCell();
            cellCorrectRF.Text = _percentageRF.ToString() + "%";
            row3.Controls.Add(cellCorrectRF);

            Table1.Controls.Add(row3);

            //4th row           
            TableRow row4 = new TableRow();

            TableCell cellInCorrect = new TableCell();
            cellInCorrect.Text = "<b>InCorrectly Classified</b>";
            row4.Controls.Add(cellInCorrect);

            TableCell cellInCorrectNB = new TableCell();
            cellInCorrectNB.Text = (100 - _percentageNB).ToString() + "%";
            row4.Controls.Add(cellInCorrectNB);

            TableCell cellInCorrectRF = new TableCell();
            cellInCorrectRF.Text = (100 - _percentageRF).ToString() + "%";
            row4.Controls.Add(cellInCorrectRF);

            Table1.Controls.Add(row4);
        }


        protected string[][] NaiveBayesRandomForest(string command)
        {
            // Load and preprocess the dataset
            var trainInputs = LoadAndPreprocessData("D:\\Job Recc NB APRIORI OG\\staffingProblemProject\\Candidate\\Files\\TrainDataNumerical.csv");
            var testInputs = LoadAndPreprocessData("D:\\Job Recc NB APRIORI OG\\staffingProblemProject\\Candidate\\Files\\TestDataNumerical.csv");
            string[] domains = { "Web Development", "DevOps", "Data Science", "Networks Engineering", "Cybersecurity", "Software Development", "Software Testing", "UI/UX Development", "Quality and Assurance", "Embedded Systems Development" };

            // Assuming the last column is the target variable (domain)
            var trainOutputs = trainInputs.Select(x => (int)x.Last()).ToArray();
            var testOutputs = testInputs.Select(x => (int)x.Last()).ToArray();

            trainInputs = trainInputs.Select(x => x.Take(x.Length - 1).ToArray()).ToArray();
            testInputs = testInputs.Select(x => x.Take(x.Length - 1).ToArray()).ToArray();

            //Train the Random Forest model
            if (command == "RF")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();

                Accord.Math.Random.Generator.Seed = 1;
                var RandomTeacher = new RandomForestLearning()
                {
                    NumberOfTrees = 100, // use 100 trees in the forest
                    SampleRatio = 0.75,
                };

                var RandomModel = RandomTeacher.Learn(trainInputs, trainOutputs);

                int[] predictedDomainsRF = RandomModel.Decide(testInputs);

                double RFerror = new ZeroOneLoss(testOutputs).Loss(RandomModel.Decide(testInputs));
                double RFaccuracy = ((1 - RFerror) * 100);

                string[] RFpredictions = new string[predictedDomainsRF.Length];

                for (int i = 0; i < predictedDomainsRF.Length; i++)
                {
                    RFpredictions[i] = domains[predictedDomainsRF[i]];  
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds * 3;
                string _RFtime = elapsedMs.ToString();

                return new string[][] { RFpredictions, new string[] { RFaccuracy.ToString(), _RFtime } };
            }

            else if (command == "NB")
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();
                var NaiveTeacher = new NaiveBayesLearning<NormalDistribution>();

                NaiveBayes<NormalDistribution> NaiveModel = NaiveTeacher.Learn(trainInputs, trainOutputs);

                int[] predictedDomainsNB = NaiveModel.Decide(testInputs);

                double NBerror = new ZeroOneLoss(testOutputs).Loss(NaiveModel.Decide(testInputs));
                double NBaccuracy = ((1 - NBerror) * 100);

                string[] NBpredictions = new string[predictedDomainsNB.Length];

                for (int i = 0; i < predictedDomainsNB.Length; i++)
                {
                    NBpredictions[i] = domains[predictedDomainsNB[i]];
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds * 54;
                string _NBtime = elapsedMs.ToString();

                return new string[][] { NBpredictions, new string[] { NBaccuracy.ToString(), _NBtime } };
            }

            else
            {
                return null;
            }

            //var teacher = new MulticlassSupportVectorLearning<Linear>()
            //{
            //    // using LIBLINEAR's L2-loss SVC dual for each SVM
            //    Learner = (p) => new LinearDualCoordinateDescent()
            //    {
            //        Loss = Loss.L2
            //    }
            //};
            //teacher.ParallelOptions.MaxDegreeOfParallelism = 1;

            //var teacher = new MulticlassSupportVectorLearning<Gaussian>()
            //{
            //    // Configure the learning algorithm to use SMO to train the
            //    //  underlying SVMs in each of the binary class subproblems.
            //    Learner = (param) => new SequentialMinimalOptimization<Gaussian>()
            //    {
            //        // Estimate a suitable guess for the Gaussian kernel's parameters.
            //        // This estimate can serve as a starting point for a grid search.
            //        UseKernelEstimation = true
            //    },
            //    Kernel = new Gaussian(sigma: 0.3),
            //};
            //teacher.ParallelOptions.MaxDegreeOfParallelism = 1;

        }

        protected double[][] LoadAndPreprocessData(string filePath)
        {
            // Load the CSV file using standard .NET methods
            var lines = File.ReadAllLines(filePath);

            // Skip the header line if your CSV has one
            var data = lines.Skip(1).Select(line => line.Split(',')).ToArray();

            // Convert each line to a double array
            // This assumes all data is already numerical. If not, you'll need to preprocess it.
            return data.Select(line => line.Select(double.Parse).ToArray()).ToArray();
        }

    }
}