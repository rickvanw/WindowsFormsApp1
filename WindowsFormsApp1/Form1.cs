using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Net;
using RestSharp;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public static class Globals
        {
            public static String HOST_ADDRESS_CALLS = "http://localhost:8000/";
            public static String HOST_ADDRESS_IMAGES = "http://localhost:63342/2016-2017-Project-Uitdaging-EHI2Va15-Web/kom_in_beweging/img/";
            public static string treatment_exercise_id;

            public static string TreatmentExerciseID
            {
                get
                {
                    return treatment_exercise_id;
                }
                set
                {
                    treatment_exercise_id = value;
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeForm();
            getExerciseAsync();

        }

        private void initializeForm()
        {
            this.ShowInTaskbar = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //Show();
            //WindowState = FormWindowState.Normal;
            //Hide();

            //Set the SizeMode to center the image.
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        /**
            private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
            //WindowState = FormWindowState.Normal;

            notifyIcon1.ShowBalloonTip(2000, "hallo", "test", ToolTipIcon.Info);
        }
            **/


        /**
         * --------------   USER INTERACTION    ----------------
         **/
        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doneExerciseAsync("1");
            buttonDone.BackColor = Color.FromArgb(191, 229, 191);
            buttonNotDone.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doneExerciseAsync("-1");
            buttonDone.BackColor = Color.White;
            buttonNotDone.BackColor = Color.FromArgb(249, 156, 156);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rateExerciseAsync("1");
            buttonLike.BackColor = Color.FromArgb(191, 229, 191);
            buttonDislike.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rateExerciseAsync("-1");
            buttonLike.BackColor = Color.White;
            buttonDislike.BackColor = Color.FromArgb(249, 156, 156);
        }


        /**
        * --------------   SERVER CALLS    ----------------
        **/
        private async System.Threading.Tasks.Task getExerciseAsync()
        {

            var client = new RestClient(Globals.HOST_ADDRESS_CALLS);
            var request = new RestRequest("treatment/exercise-now", Method.GET);

            //TODO implement auth jwt        
            request.AddHeader("authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InJ1YmVuYXNzaW5rQGhvdG1haWwuY29tIiwidXNlcl9pZCI6NCwicm9sZV9pZCI6MCwiaWF0IjoxNDk1MzkzNTYwLCJleHAiOjE1MjY5Mjk1NjB9.4UMl25J0i7C4d5METeHxY-4FYrf9ez0B0RkkijuoaCc");
            request.Timeout = 2000;

            // execute the request
            var response = await client.ExecuteTaskAsync(request);
            var content = response.Content; // raw content as string  

            // Check if response is not null
            try
            {
                if (!content.Equals(null))
                {
                    if (content != "[]")
                    {
                        setExercise(content);
                    }
                    else
                    {
                        // Notify user, there is no exercise
                        MessageBox.Show("Kan geen oefening vinden, neem contact op met de systeembeheerder.", "Fout",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("ERROR: empty content: " + content);
                    }
                }
            }
            catch (Exception e)
            {
                // Notify user, can't get from the server
                MessageBox.Show("Kan geen gegevens ophalen van de server, neem contact op met de systeembeheerder.", "Fout",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("ERROR: " + e.Message);
            }

        }

        private async System.Threading.Tasks.Task doneExerciseAsync(string done)
        {

            var client = new RestClient(Globals.HOST_ADDRESS_CALLS);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("treatment/exercise-done", Method.PUT);
            request.AddParameter("done", done); // adds to POST or URL querystring based on Method
            request.AddParameter("treatment_exercise_id", Globals.TreatmentExerciseID); 

            //TODO implement auth jwt        
            request.AddHeader("authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InJ1YmVuYXNzaW5rQGhvdG1haWwuY29tIiwidXNlcl9pZCI6NCwicm9sZV9pZCI6MCwiaWF0IjoxNDk1MzkzNTYwLCJleHAiOjE1MjY5Mjk1NjB9.4UMl25J0i7C4d5METeHxY-4FYrf9ez0B0RkkijuoaCc");
            request.Timeout = 2000;

            // execute the request
            var response = await client.ExecuteTaskAsync(request);
            var content = response.Content; // raw content as string  


            // Check if response is not null
            try
            {
                if (!content.Equals(null))
                {
                    setExercise(content);
                }
            }
            catch (Exception e)
            {
                // Notify user, can't get from the server
                MessageBox.Show("Kan geen gegevens sturen naar de server, neem contact op met de systeembeheerder.", "Fout",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("ERROR: " + e.Message);
            }

        }

        private async System.Threading.Tasks.Task rateExerciseAsync(string rating)
        {

            var client = new RestClient(Globals.HOST_ADDRESS_CALLS);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("exercise/rate", Method.PUT);
            request.AddParameter("rating", rating); // adds to POST or URL querystring based on Method
            request.AddParameter("treatment_exercise_id", Globals.TreatmentExerciseID);

            //TODO implement auth jwt        
            request.AddHeader("authorization", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJlbWFpbCI6InJ1YmVuYXNzaW5rQGhvdG1haWwuY29tIiwidXNlcl9pZCI6NCwicm9sZV9pZCI6MCwiaWF0IjoxNDk1MzkzNTYwLCJleHAiOjE1MjY5Mjk1NjB9.4UMl25J0i7C4d5METeHxY-4FYrf9ez0B0RkkijuoaCc");
            request.Timeout = 2000;

            // execute the request
            var response = await client.ExecuteTaskAsync(request);
            var content = response.Content; // raw content as string  

            // Check if response is not null
            try
            {
                if (!content.Equals(null))
                {
                    setExercise(content);
                }
            }
            catch (Exception e)
            {
                // Notify user, can't get from the server
                MessageBox.Show("Kan geen gegevens sturen naar de server, neem contact op met de systeembeheerder.", "Fout",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("ERROR: " + e.Message);
            }

        }


        /**
        * --------------   CONTENT FILLERS    ----------------
         **/
        private void setExercise(string JSONResponse)
        {

                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONResponse);
                for (var i = 0; i < data.Count; i++)
                {
                    dynamic item = data[i];
                    Console.WriteLine((string)item.repetitions, (string)item.name);
                    exerciseName.Text = (string)item.name;
                    exerciseRepetitions.Text = (string)item.repetitions;

                // Set buttons
                if ((string)item.done == "1") {
                    buttonDone.BackColor = Color.FromArgb(191, 229, 191);
                }
                else if ((string)item.done == "-1") {
                    buttonNotDone.BackColor = Color.FromArgb(249, 156, 156);
                }

                if ((string)item.rating_user == "1")
                {
                    buttonLike.BackColor = Color.FromArgb(191, 229, 191);
                }
                else if ((string)item.rating_user == "-1")
                {
                    buttonDislike.BackColor = Color.FromArgb(249, 156, 156);
                }

                // Save treatment_exercise_id for later use
                Globals.TreatmentExerciseID = (string)item.treatment_exercise_id;

                    // Fill webbrowser for video, insert correct video url
                exerciseVideoBrowser.DocumentText = "<!DOCTYPE html>" +
                        "<html lang = 'en' xmlns = 'http://www.w3.org/1999/xhtml'>" +
                        "<head >" +
                        "<meta http-equiv = 'X-UA-Compatible' content = 'IE=edge' />" +
                        "</head >" +
                        "<body oncontextmenu='return false;' style='user-select: none;-ms-user-select:none; -moz-user-select: none;  -webkit-user-select: none;background-color:#efeaea;top:0; left:0; margin:0; border:none;height:350px; width:620px' >" +
                        "<div style = 'background-color:#efeaea;overflow:hidden;height:100%; width:100%;' >" +
                        "<iframe allowfullscreen='allowfullscreen' style ='background-color:#efeaea;overflow:hidden;top:0; left:0; margin:0; border:none;height:100%; width:100%;' src =" +
                        "'" + (string)item.media_url + "?autoplay=0&showinfo=0&controls=1&rel=0' allowfullscreen>" +
                        "</iframe >" +
                        "</div>" +
                        "</body>" +
                        "</html> ";

                    // Fill webbrowser for video, insert correct image url
                    exerciseImageBrowser.DocumentText = "<!DOCTYPE html>" +
                        "<html lang = 'en' xmlns = 'http://www.w3.org/1999/xhtml'>" +
                        "<head>" +
                        "<meta http-equiv = 'X-UA-Compatible' content = 'IE=edge' />" +
                        "</head>" +
                        "<body oncontextmenu='return false;' style='pointer-events: none;user-select: none;-ms-user-select:none; -moz-user-select: none;  -webkit-user-select: none;background-color:#efeaea;top:0; left:0; margin:0; border:none;height:208px; width:258px'>" +
                        "<div style = 'background-color:#efeaea;overflow:hidden;height:208px; width:258px;'>" +
                        "<img style = 'box-shadow: 0px 0px 16px #888888;display:block;background-color:#efeaea;overflow:hidden;top:0; left:0; margin:8px; border:none;height:auto;width:auto;max-height:192px; max-width:243px;' src =" +
                        "'" + Globals.HOST_ADDRESS_IMAGES + (string)item.image_url + ".jpg" + "'>" +
                        "</div>" +
                        "</body>" +
                        "</html> ";

                    // Fill webbrowser for description
                    exerciseDescriptionBrowser.DocumentText = "<!DOCTYPE html>" +
                        "<html lang = 'en' xmlns = 'http://www.w3.org/1999/xhtml'>" +
                        "<head>" +
                        "<meta http-equiv = 'X-UA-Compatible' content = 'IE=edge' />" +
                        "</head>" +
                        "<body oncontextmenu='return false;' style='cursor:default;user-select: none;-ms-user-select:none; -moz-user-select: none;  -webkit-user-select: none;  background-color:#efeaea;top:0; left:0; margin:0; border:none;height:100%; width:100%' >" +
                        "<div style = 'font-size: 14px; overflow-y:auto; font-family:Helvetica,Arial,sans-serif; font-weight:bold; color: rgba(0, 0, 0, 0.65); background-color:#efeaea;height:100%; width:100%;' >" +
                        (string)item.description +
                        "</div>" +
                        "</body>" +
                        "</html> ";

                }
            
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}
