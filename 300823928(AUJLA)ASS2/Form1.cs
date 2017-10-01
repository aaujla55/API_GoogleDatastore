using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _300823928_AUJLA_ASS2
{
    public partial class Form1 : Form
    {

        //Author: Amandeep Aujla(300823928)
        //Date: 9/30/2017
        Datastore ds = new Datastore();
        public Form1()
        {
           
            InitializeComponent();
        }

        //change the color of label to green
        private void success()
        {

            lblUpdateMessage.ForeColor = System.Drawing.Color.Green;
        }

        //change the color of label to red
        private void failed()
        {
            lblUpdateMessage.ForeColor = System.Drawing.Color.Red;

        }

        //On click Add button
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            String description = txtBoxDes.Text;
           
            if(description!= "")
            {
                ds.AddTask(description);
                success();
                lblUpdateMessage.Text = "Task has been added in Datastore!";
            }
            else
            {
                failed();
                lblUpdateMessage.Text = "Please enter description!";
            }
            
        }

       
        //On click delete button
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
           
            if (txtBoxDeleteTask.Text != "")
            {
                try
                {
                    long value = Convert.ToInt64(txtBoxDeleteTask.Text);
                    ds.DeleteTask(value);
                    success();
                    lblUpdateMessage.Text = "Task Deleted";
                }
                catch(Exception ex)
                {
                    failed();
                    lblUpdateMessage.Text = "Please enter valid Project id";
                }
                    
                }
               
            else
            {
                failed();
                lblUpdateMessage.Text = "Please enter projectID";
            }
        }

        //On click modify button
        private void btnModifyTask_Click(object sender, EventArgs e)
        {
            try
            {
                long value = Convert.ToInt64(txtBoxDeleteTask.Text);
                if (txtBoxDeleteTask.Text != "" || txtBoxDes.Text != "")
                {
                    if (ds.modifyTask(value, txtBoxDes.Text))
                    {
                        success();
                        lblUpdateMessage.Text = "Task Modified";
                    }
                    else
                    {
                        failed();
                        lblUpdateMessage.Text = "Sorry! No such task exist";
                    }
                }
                else
                {
                    failed();
                    lblUpdateMessage.Text = "Please fill in 'Project Id' and new description";
                }
            }
            catch(Exception err)
            {
                failed();
                lblUpdateMessage.Text = "Please enter valid details";
            }

        }
    }
}
