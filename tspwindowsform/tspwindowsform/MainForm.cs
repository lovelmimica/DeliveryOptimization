using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using traveling_salesman_problem;

namespace traveling_salesman_problem
{
    public partial class MainForm : Form
    {
        private ImageIterator iterator;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_onClick(object sender, EventArgs e)
        {
                        
            Address origin = new Address(tbOriginAddress.Text);
            Trip.GetInstance().Initialize(origin, "addresses.txt", int.Parse(tbVehicleCount.Text));

            Algorithm alg = new Algorithm();
            alg.OrganizeTrip(Trip.GetInstance());
            routeResultLabel.Text = Trip.GetInstance().Plan.ToString();
            //Trip.GetInstance().DisplayRoutes();

            //spremi slike ruta lokalno
            Trip.GetInstance().Plan.SaveImage();

            //ispisi rute u picture boxu
            iterator = new ImageIterator();
            pbMap.Image = iterator.First();
            btnNext.Visible = true;
        }

        private void btnNext_onClick(object sender, EventArgs e)
        {
            pbMap.Image = iterator.Next();
        }
    }
}
