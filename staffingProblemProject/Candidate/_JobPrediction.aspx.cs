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
using System.Reflection;
using System.Net.Mail;

namespace staffingProblemProject.Candidate
{
    public partial class _JobPrediction : System.Web.UI.Page
    {
        string _output = "";
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
                    //TrainingDS();
                    jobstxt.Visible = false;
                    ResultAnnouncement.Visible = false;
                    if (lblResult.Text != "")
                    {
                        ResultAnnouncement.Visible = true;
                        GetCompanyAds(lblResult.Text);
                    }

                    if (!IsPostBack)
                    {
                        SetParams();
                    }
                }
            }
            catch
            {

            }
        }

        protected void SetParams() { 
            
            BLL forParams = new BLL();
            DataTable userParams = forParams.GetMLParamsById(Session["UserId"].ToString());
            DropDownListSSLC.Items.FindByValue(userParams.Rows[0]["SSLC"].ToString()).Selected = true;
            DropDownListPUC.Items.FindByValue(userParams.Rows[0]["PUC"].ToString()).Selected = true;
            DropDownListCS.Items.FindByValue(userParams.Rows[0]["Communication"].ToString()).Selected = true;
            DropDownListPSolving.Items.FindByValue(userParams.Rows[0]["ProblemSolving"].ToString()).Selected = true;
            DropDownListNetworks.Items.FindByValue(userParams.Rows[0]["Networks"].ToString()).Selected = true;
            DropDownListOS.Items.FindByValue(userParams.Rows[0]["OS"].ToString()).Selected = true;
            DropDownListDBMS.Items.FindByValue(userParams.Rows[0]["DBMS"].ToString()).Selected = true;
            DropDownListDS.Items.FindByValue(userParams.Rows[0]["DSA"].ToString()).Selected = true;
            DropDownListCloud.Items.FindByValue(userParams.Rows[0]["CloudComputing"].ToString()).Selected = true;
            DropDownListContainers.Items.FindByValue(userParams.Rows[0]["Containers"].ToString()).Selected = true;
            DropDownListSD.Items.FindByValue(userParams.Rows[0]["SystemDesign"].ToString()).Selected = true;
            DropDownListM.Items.FindByValue(userParams.Rows[0]["Maths"].ToString()).Selected = true;
            DropDownListVCS.Items.FindByValue(userParams.Rows[0]["VersionControl"].ToString()).Selected = true;
            DropDownListPython.Items.FindByValue(userParams.Rows[0]["Python"].ToString()).Selected = true;
            DropDownListJS.Items.FindByValue(userParams.Rows[0]["JSTS"].ToString()).Selected = true;
            DropDownListCCCP.Items.FindByValue(userParams.Rows[0]["CC++"].ToString()).Selected = true;
            DropDownListJava.Items.FindByValue(userParams.Rows[0]["Java"].ToString()).Selected = true;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string _data = null;

                _data = DropDownListSSLC.SelectedItem.Value + "," +
                        DropDownListPUC.SelectedItem.Value + "," +
                        DropDownListCS.SelectedItem.Value + "," +
                        DropDownListPSolving.SelectedItem.Value + "," +
                        DropDownListNetworks.SelectedItem.Value + "," +
                        DropDownListOS.SelectedItem.Value + "," +
                        DropDownListDBMS.SelectedItem.Value + "," +
                        DropDownListDS.SelectedItem.Value + "," +
                        DropDownListCloud.SelectedItem.Value + "," +
                        DropDownListContainers.SelectedItem.Value + "," +
                        DropDownListSD.SelectedItem.Value + "," +
                        DropDownListM.SelectedItem.Value + "," +
                        DropDownListVCS.SelectedItem.Value + "," +
                        DropDownListPython.SelectedItem.Value + "," +
                        DropDownListJS.SelectedItem.Value + "," +
                        DropDownListCCCP.SelectedItem.Value + "," +
                        DropDownListJava.SelectedItem.Value ;


                double[] values = _data.Split(',').Select(double.Parse).ToArray();

                _output = NaiveBayes(values);

                lblResult.ForeColor = System.Drawing.Color.Green;
                ResultAnnouncement.Visible = true;
                lblResult.Text = _output;


                //Response.Redirect(string.Format("StudentGraph.aspx?p1={0}", _output));
                GetCompanyAds(_output);
            }
            catch
            {

            }
        }

        protected string NaiveBayes(double[] input)
        {
            // Load and preprocess the dataset
            var trainInputs = LoadAndPreprocessData(Server.MapPath("Files/TrainDataNumerical.csv"));
            string[] domains = { "Web Development", "DevOps", "Data Science", "Networks Engineering", "Cybersecurity", "Software Development", "Software Testing", "UI/UX Development", "Quality and Assurance", "Embedded Systems Development" };

            // Assuming the last column is the target variable (domain)
            var trainOutputs = trainInputs.Select(x => (int)x.Last()).ToArray();
            

            trainInputs = trainInputs.Select(x => x.Take(x.Length - 1).ToArray()).ToArray();

            //Train the Random Forest model
            //Accord.Math.Random.Generator.Seed = 1;
            //var teacher = new RandomForestLearning()
            //{
            //    NumberOfTrees = 100, // use 100 trees in the forest
            //    SampleRatio = 0.75,
            //};

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

            var teacher = new NaiveBayesLearning<NormalDistribution>();
            // Split the dataset into training and testing sets

            //var model = teacher.Learn(trainInputs, trainOutputs);
            NaiveBayes<NormalDistribution> model = teacher.Learn(trainInputs, trainOutputs);

            // Predict the domain of the new job
            int predictedDomain = model.Decide(input);
            string output = domains[predictedDomain];

            return output;
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

        public void GetCompanyAds(string job_domain)
        {
            BLL obj = new BLL();

            DataTable tab = new DataTable();
            tab.Rows.Clear();

            tab = obj.GetJobAdsByType(job_domain);

            if (tab.Rows.Count > 0)
            {
                Table4.Rows.Clear();
                jobstxt.Visible = true;

                Table4.BorderStyle = BorderStyle.Double;
                Table4.GridLines = GridLines.Both;
                Table4.BorderColor = System.Drawing.Color.DarkGray;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

                mainrow.BackColor = System.Drawing.Color.Gray;

                TableHeaderCell cell0 = new TableHeaderCell();
                cell0.Text = "AdId";
                mainrow.Controls.Add(cell0);

                TableHeaderCell comp = new TableHeaderCell();
                comp.Text = "Company Id";
                mainrow.Controls.Add(comp);

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Job Domain";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Job Title";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Skills Required";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Job Description";
                mainrow.Controls.Add(cell4);

                TableHeaderCell cell5 = new TableHeaderCell();
                cell5.Text = "Posted On";
                mainrow.Controls.Add(cell5);

                TableHeaderCell cellStatus = new TableHeaderCell();
                cellStatus.Text = "Status";
                mainrow.Controls.Add(cellStatus);

                TableHeaderCell cellEdit = new TableHeaderCell();
                cellEdit.Text = "Apply";
                mainrow.Controls.Add(cellEdit);


                Table4.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cellName = new TableCell();
                    cellName.Width = 100;
                    cellName.Text = tab.Rows[i]["AdsId"].ToString();
                    row.Controls.Add(cellName);

                    TableCell cellCompId = new TableCell();
                    cellCompId.Width = 100;
                    cellCompId.Text = tab.Rows[i]["MemberId"].ToString();
                    row.Controls.Add(cellCompId);

                    TableCell cellCompanyName = new TableCell();
                    cellCompanyName.Width = 150;
                    cellCompanyName.Text = tab.Rows[i]["JobType"].ToString();
                    row.Controls.Add(cellCompanyName);

                    TableCell cellContactNo = new TableCell();
                    cellContactNo.Width = 200;
                    cellContactNo.Text = tab.Rows[i]["SubType"].ToString();
                    row.Controls.Add(cellContactNo);

                    TableCell cellSkills = new TableCell();
                    cellSkills.Width = 300;
                    cellSkills.Text = tab.Rows[i]["SkillsRequired"].ToString();
                    row.Controls.Add(cellSkills);

                    TableCell cellDesc = new TableCell();
                    cellDesc.Width = 300;
                    cellDesc.Text = tab.Rows[i]["JobDesc"].ToString();
                    row.Controls.Add(cellDesc);

                    TableCell cellDate = new TableCell();
                    cellDate.Width = 100;
                    cellDate.Text = tab.Rows[i]["PostedDate"].ToString();
                    row.Controls.Add(cellDate);

                    TableCell cellStatus1 = new TableCell();
                    cellStatus1.Width = 100;
                    cellStatus1.Text = tab.Rows[i]["Status"].ToString();
                    row.Controls.Add(cellStatus1);

                    TableCell cell_edit = new TableCell();

                    Button btn_edit123 = new Button();
                    btn_edit123.ID = "edit~" + tab.Rows[i]["AdsId"].ToString();
                    btn_edit123.Text = "APPLY";
                    btn_edit123.OnClientClick = "return confirm('Are you sure want to APPLY ?')";
                    btn_edit123.Click += new EventHandler(btn_edit123_Click);
                    cell_edit.Controls.Add(btn_edit123);
                    row.Controls.Add(cell_edit);


                    Table4.Controls.Add(row);
                }

            }
            else
            {
                Table4.Rows.Clear();
                Table4.GridLines = GridLines.None;

                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ColumnSpan = 5;
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "No Jobs Found";
                row.Controls.Add(cell);

                Table4.Controls.Add(row);
            }
        }

        void btn_edit123_Click(object sender, EventArgs e)
        {
            BLL obj = new BLL();
            Button lbtn = (Button)sender;
            string[] s = lbtn.ID.ToString().Split('~');

            try
            {
                if (obj.CheckUserAd(Session["UserId"].ToString(), int.Parse(s[1])))
                {
                    DataTable Ad = obj.GetAdsById(int.Parse(s[1]));
                    DataTable User = obj.GetUserById(Session["UserId"].ToString());
                    obj.InsertApplyJob(Session["UserId"].ToString(), int.Parse(s[1]), "APPLIED");
                    MailMessage mail = new MailMessage();
                    mail.To.Add(User.Rows[0][5].ToString());
                    mail.From = new MailAddress("onlinenotes56@gmail.com", "Job Portal", System.Text.Encoding.UTF8);
                    mail.Subject = "Job Application Submitted for Job ID" + Ad.Rows[0][0];
                    mail.SubjectEncoding = System.Text.Encoding.UTF8;
                    //mail.Body = "your job application for ";
                    mail.Body = "Your Job Application has been submitted. Job Application details are as follows:<br>Job ID " + Ad.Rows[0][0] + "<br> Posted by: " + Ad.Rows[0][1] + "<br> Role:" + Ad.Rows[0][3] + "<br>";
                    mail.BodyEncoding = System.Text.Encoding.UTF8;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;
                    SmtpClient client = new SmtpClient();
                    client.Credentials = new System.Net.NetworkCredential("onlinenotes56@gmail.com", "kwaaisxwvqjwbdnz");
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.EnableSsl = true;
                    client.Send(mail);
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Job Applied Successfully')</script>");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Already Applied')</script>");
                }
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Sending Failed...');}</script>");
            }
        }
    }
}