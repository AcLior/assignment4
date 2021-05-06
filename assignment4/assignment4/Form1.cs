using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class Form1 : Form
    {
        Queue q1 = new Queue();

        public Form1()
        {
            InitializeComponent();
          
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Trip t;

            if (txtDate.Text != "" && txtDest.Text != "" && txtType.Text != "")
            {
                t = new Trip((TripType)Enum.Parse(typeof(TripType), txtType.Text), DateTime.Parse(txtDate.Text), txtDest.Text);
                q1.Enqueue(t);
              
                txtDate.Text = "";
                txtDest.Text = "";
                txtType.Text = "";
                listTrips.Items.Clear();
                foreach (Trip trip in q1.Arr)
                {
                    if (trip != null)
                    {
                        listTrips.Items.Add(trip.PrintTripForGUI());

                    }
                }
            }
            else MessageBox.Show("Wrong values", "Trip's data not correct or empty",MessageBoxButtons.OK) ;
            
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!q1.IsEmpty())
            {
                q1.Dequeue();
               
                listTrips.Items.Clear();

                foreach (Trip trip in q1.Arr)
                {
                    if (trip!=null)
                    {
                        listTrips.Items.Add(trip.PrintTripForGUI());

                    }
                }
            }
            else MessageBox.Show("The queue is empty!","Empty queue", MessageBoxButtons.OK);



        }

        private void btnShowByDate_Click(object sender, EventArgs e)
        {
            
            listTrips.Items.Clear();

            foreach (Trip trip in q1.Arr)
            {
                if (trip.Date <= dateTimePicker1.Value.Date&& trip!=null)
                {
                    listTrips.Items.Add(trip.PrintTripForGUI());
                }
            }
        }
    }
}
