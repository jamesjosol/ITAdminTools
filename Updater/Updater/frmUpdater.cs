using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace Updater
{
    public partial class frmUpdater : Form
    {
        public frmUpdater()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }

        bool expanded = false;

        string exePath = "", appName = "", updatePath = "", local_backup_path = "", local_dir_path = "";
        string[] args=null;

        private void frmUpdater_Load(object sender, EventArgs e)
        {
            args = Environment.GetCommandLineArgs();
            richTextBox1.Text = "Starting updater!";
            bgWorkerUpdater.RunWorkerAsync(); //Start process

        }

        private List<string> getAllFileDirectory(string path)
        {
            List<string> location = new List<string>();
            DirectoryInfo di = new DirectoryInfo(path);
            foreach (var subfolder in di.GetDirectories()) //look for sub-folder from the server path
            {
                location.Add(subfolder.FullName);
                foreach (var insideSubFolder in getAllFileDirectory(subfolder.FullName)) //look for more sub-folder inside this sub-folder
                {
                    location.Add(insideSubFolder);
                }
            }
            return location;
        }

        private void animate(int targetHeight, int stepSize)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel3.Width += 3;

            if (panel3.Width >= 440)
            {
                timer1.Stop();
            }
        }

        private void animate2(int targetHeight, int stepSize)
        {
           

        }

        void UpdateStatus(string message)
        {
            richTextBox1.Invoke(new Action(() => richTextBox1.Text = message));

        }
        //private bool hasChildDirectory(string path)
        //{
        //    /// <summary>
        //    ///     This will determine if the path has a child
        //    ///     if path has child then it will not be deleted
        //    /// </summary>
        //    bool has_child = false;
        //    DirectoryInfo di = new DirectoryInfo(path);
        //    foreach (var subfolder in di.GetDirectories())
        //    {
        //        has_child = true;
        //        break;
        //    }
        //    return has_child;
        //}

        //private List<string> delete_last_child(List<string> local_directories)
        //{
        //    List<string> new_local_directories = local_directories;
        //    /// <summary>
        //    ///     Look for the most child in the list of local directories and 
        //    ///     delete this folder together with it's corresponding files that doesn't exists on the server and
        //    ///     the system will return a new list that needs to be evaluated again
        //    /// </summary>
        //    foreach (string local_dir in local_directories)
        //    {
        //        bool child_flag = hasChildDirectory(local_dir);
        //        if (child_flag == false)
        //        {
        //            Directory.Delete(local_dir, true);
        //            new_local_directories.Remove(local_dir);
        //            break;
        //        }
        //    }
        //    return new_local_directories;
        //}
        private void getServerFiles(string path = "")
        {
            try
            {
                if (Directory.Exists(path))
                {
                    local_dir_path = Directory.GetCurrentDirectory();
                    local_backup_path = local_dir_path + "\\Backup";
                    if (Directory.Exists(local_backup_path)) Directory.Delete(local_backup_path, true); //Delete entire backup folder


                    if (!Directory.Exists(local_backup_path))
                    {
                        UpdateStatus("Creating directory " + local_backup_path );
                        Directory.CreateDirectory(local_backup_path); //Create a Backup folder in local folder if not exists

                    }
                    DirectoryInfo local_backup_info = new DirectoryInfo(local_backup_path); //GET the info of backup directory

                    try
                    {
                        //List<string> local_directories = getAllFileDirectory(local_dir_path); //get all sub directories from the local parent folder
                        List<string> server_directories = getAllFileDirectory(path); //get all sub directories from the server parent folder
                        server_directories.Add(path); //include the server parent folder


                        /// <summary>
                        ///     Loop each file found in server_path and compare the modified date to the current files locally
                        /// </summary>
                        foreach (string dir in server_directories)//get all updated files from the server
                        {
                            //var folder_name = dir.Split(new[] { "\\" }, StringSplitOptions.None);
                            string new_local_dir_path = dir.Replace(path, local_dir_path); //Change the server's root path to local's root path to get the subfolders

                            //local_directories = local_directories.Where(o => o.ToString() != new_local_dir_path &&
                            //!o.ToString().Contains("Backup")).ToList();//remove from the list the sub folders that still exists on the server

                            if (!Directory.Exists(new_local_dir_path))
                            {
                                UpdateStatus("Creating directory " + new_local_dir_path );
                                Directory.CreateDirectory(new_local_dir_path); //create a new folder locally if sub folder located in the server is not found
                            }

                            foreach (string server_file_path in Directory.GetFiles(dir))
                            {
                                DirectoryInfo server_file_info = new DirectoryInfo(server_file_path); //get file information from server
                                /// <summary>
                                ///     This will check if the file found in server is inside the local folder
                                ///     If exists, compare the last modified date 
                                ///     If both files doesn't have the same modified date then replace the local file with the server file
                                ///     If both files file have the same modified date then skip 
                                /// </summary>
                                string local_file_path = new_local_dir_path + "\\" + server_file_info.Name;

                                if (File.Exists(local_file_path))
                                {
                                    DirectoryInfo local_file_info = new DirectoryInfo(local_file_path); //GET the info of local file

                                    if (server_file_info.LastWriteTime > local_file_info.LastWriteTime)
                                    {
                                        /// <summary>
                                        ///     These line of code will backup the files from local directory to backup directory.
                                        ///     If some errors occurred during execution, the system will roll back the changes
                                        /// </summary>                
                                        string new_local_backup_path = dir.Replace(path, local_backup_info.FullName);  //Change the local's root path to backup's root path
                                        if (!Directory.Exists(new_local_backup_path))
                                        {
                                            UpdateStatus("Creating directory " + new_local_backup_path );
                                            Directory.CreateDirectory(new_local_backup_path); //create a new folder in the backup path if sub folder located locally is not found

                                        }

                                        UpdateStatus("Creating directory " + new_local_backup_path);
                                        File.Move(local_file_path, new_local_backup_path + "\\" + server_file_info.Name);

                                        //Copy the file from server directory to local directory
                                        UpdateStatus("Copying file from " + server_file_path + " to " + local_file_path );
                                        File.Copy(server_file_path, local_file_path);
                                    }
                                }
                                else
                                {

                                    //Copy the new file found in server that is not in the local directory
                                    UpdateStatus("Copying file from " + server_file_path + " to " + local_file_path );
                                    File.Copy(server_file_path, local_file_path);

                                }
                            }
                        }

                        ////Loop until all the non-existing sub directory are deleted starting with the most child
                        //while (delete_last_child(local_directories).Count() > 0) { }

                        //throw new Exception("test");

                        timer2.Tick += new EventHandler((o, a) => animate2(400, 3));
                        UpdateStatus("Successfully updated " + appName);
                        System.Threading.Thread.Sleep(1000);

                    }
                    catch (Exception ex)
                    {
                        RollBack(ex);
                    }
                }
                else
                {
                    UpdateStatus("Update path not accessible");
                    System.Threading.Thread.Sleep(3000);
                }
            }
            catch(Exception ex)
            {
                UpdateStatus("An error occurred! " + ex.ToString() + "\n");
            }
        }
        private void bgWorkerUpdater_DoWork(object sender, DoWorkEventArgs e)
        {

            if (args != null && args.Length>2)
            {
                updatePath = args[1];
                appName = args[2];
                exePath = Directory.GetCurrentDirectory() + "\\" + appName;
                lblTitle.Invoke(new Action(() => lblTitle.Text = string.Format("Checking updates for {0}", appName)));
                getServerFiles(updatePath);
            }
            else
            {
                timer1.Tick += new EventHandler((o, a) => animate(200, 3));
                UpdateStatus("Updater startup error. Invalid argument count, expecting update path and application name");
                System.Threading.Thread.Sleep(4000);
            }
        }
        private Timer timer2 = new Timer();
        private void bgWorkerUpdater_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (!string.IsNullOrEmpty(appName))
            {
                try
                {

                    System.Diagnostics.Process.Start(exePath, "True"); //Start the [App_Name].exe
                    this.Close();
                }
                catch (Exception ex)
                {
                    UpdateStatus(string.Format("Unable to start main application: \n'{0}'.\nError Message :\n{1}",exePath,ex.Message));
                }
            }
            else
            {
                timer2.Start();
                timer2.Interval = 15;

                timer2.Tick += new EventHandler((o, a) => animate2(400, 3));
                
                UpdateStatus("Invalid calling application name");
            }

            
        }

        private void RollBack(Exception ex)
        {
            UpdateStatus("An error occurred! " + ex.ToString() + " Rolling back changes." );
            /// <summary>
            ///     Loop each file found in backup_path to rollback the files in local directory
            /// </summary>
            List<string> backup_directories = getAllFileDirectory(local_backup_path); //get all sub directories from the backup folder
            backup_directories.Add(local_backup_path); //include the backup parent folder path
            foreach (string dir in backup_directories)
            {
                string new_local_dir_path = dir.Replace(local_backup_path, local_dir_path); //Change the backup's root path to local's root path
                if (!Directory.Exists(new_local_dir_path))
                {
                    Directory.CreateDirectory(new_local_dir_path); //create a new folder locally if sub folder located in the backup path is not found
                    
                }
                foreach (string backup_file_path in Directory.GetFiles(dir))//get all files from the backup folder
                {
                    DirectoryInfo backup_file_info = new DirectoryInfo(backup_file_path); //get directory information from backup path
                    string local_file_path = new_local_dir_path + "\\" + backup_file_info.Name;
                    if (File.Exists(local_file_path))
                    {
                        File.Delete(local_file_path); //Delete the file found locally
                    }

                    File.Move(backup_file_path, local_file_path); //Move the file from the backup to local
                }
            }
        }
        private void frmUpdater_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            RollBack(new Exception("User interrupted update process, system will now roll back changes!"));
            Application.Exit();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (!expanded)
            {
                expanded = true;
                this.Height = 198;
            }
            else
            {
                expanded = false;
                this.Height = 80;
            }

        }
    }
}
