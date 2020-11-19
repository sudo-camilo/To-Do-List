using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIT265_Truman_T_A5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void quit_button_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to quit the program?", "", MessageBoxButtons.YesNo); //gets the result after clicking quit
            if (dialog == DialogResult.Yes)
            {
                TextWriter savedFile = new StreamWriter(@".\To-do List.txt"); //saving to file (relative)
                foreach(var item in listBox1.Items)
                {
                    savedFile.WriteLine(item.ToString()); //writing to file
                }
                this.Close();
                savedFile.Close();
            }
        }

        private void add_activity_Click(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value; //sets 'date' to the user input
            listBox1.Items.Add(textBox1.Text + " " + date.ToString("MM/dd/yyyy")); //adding to the listbox
            //clear the controls
            dateTimePicker1.Value = DateTime.Today;
            textBox1.Clear();
        }

        private void remove_activity_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Would you like to remove the event?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void sort_name_Click(object sender, EventArgs e)
        {
            List<string> nameSortArray = listBox1.Items.OfType<string>().ToList(); //casting to list
            var sorted = from name in nameSortArray orderby name select name; //instantiate query
            listBox1.Items.Clear(); //clear the listbox for new information
            foreach(var item in sorted)
            {
                listBox1.Items.Add(item); //add the new stuff
            }
        }

        private void date_sort_Click(object sender, EventArgs e)
        {
         
            List<string> dateSortArray = listBox1.Items.OfType<string>().ToList(); //casting to list
            var sortedYear = from name in dateSortArray orderby name.Substring(name.LastIndexOf("/")) select name; //instantiate query for year
            var sortedNew = from name in sortedYear orderby name.Substring(name.LastIndexOf(" "), 5) select name; //instantiate query for mmdd
            listBox1.Items.Clear(); //clear the listbox for new information
            foreach (var item in sortedNew)
            {
                listBox1.Items.Add(item); //add the new stuff
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                StreamReader stream = new StreamReader(@".\To-do List.txt");
                string text;
                while ((text = stream.ReadLine()) != null) //making sure it does not add infinite blank lines
                {
                    listBox1.Items.Add(text);
                }
                stream.Close();
            }
            catch (FileNotFoundException message)
            {
                Console.WriteLine(message);
            }
            
        }
    }
}
