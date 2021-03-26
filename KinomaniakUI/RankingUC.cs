using KinomaniakLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StrongaGlownaUI
{
    public partial class RankingUC : UserControl
    {

        



        public RankingUC()
        {
            InitializeComponent();
        }

        private void LoadListData()
        {
        List<MovieModel> availableModels = new List<MovieModel>();
        availableModels = GlobalConfig.Connection.GetAllMovies();
        }

        public void WireUpLists()
        {
            rankingDataGridView.DataSource = PrepareData();

            ChangeDataName();
        }

        private  List<MovieModel> PrepareData()
        {
            List<MovieModel> availableModels = new List<MovieModel>();

            availableModels = GlobalConfig.Connection.GetAllMovies();

            availableModels = AlphabeticalOrder(availableModels);

            availableModels = ShowAllMovies(availableModels);

            return availableModels;
        }
        /// <summary>
        /// Check Alphabetical order check box
        /// </summary>
        /// <param name="availableModels"></param>
        /// <returns></returns>
        private List<MovieModel> AlphabeticalOrder(List<MovieModel> availableModels)
        {
            if (alphabeticalOrderCheckBox.Checked == false)
            {
                availableModels = availableModels.OrderByDescending(x => x.MovieRating).ThenByDescending(x => x.Counter).ThenBy(x => x.NameOfMovie).ToList();
            }
            else if (alphabeticalOrderCheckBox.Checked == true)
            {
                availableModels = availableModels.OrderBy(x => x.NameOfMovie).ToList();
            }
            return availableModels;

        }

        /// <summary>
        /// Checking showALL check box
        /// </summary>
        /// <returns>if true show all -return 0, if dont show all return  false 6</returns>
        private List<MovieModel> ShowAllMovies(List<MovieModel> movies)
        {
            int numberOfRatings=2;

            if (showAllCheckBox.Checked == true)
            {
                numberOfRatings = 0;
            }
            if (showAllCheckBox.Checked == false)
            {
                numberOfRatings = 2;
            }

            movies = movies.Where(x => x.Counter >= numberOfRatings).ToList();

            return movies;

        }
        /// <summary>
        /// Change names of input data from ListMovieModel
        /// </summary>
        private void ChangeDataName()
        {




            if (null != rankingDataGridView)
            {
                rankingDataGridView.Columns["FullInfo"].Visible = false;
                rankingDataGridView.Columns["FullInfoWyszukaj"].Visible = false;
                rankingDataGridView.Columns["FullInfoNajczesciej"].Visible = false;
                rankingDataGridView.Columns["Total"].Visible = false;
                rankingDataGridView.Columns["Id"].Visible = false;

                
                rankingDataGridView.Columns["NameOfMovie"].HeaderText = "Title";
                rankingDataGridView.Columns["MovieGenre"].HeaderText = "Movie Genre";
                rankingDataGridView.Columns["YearOfProduction"].HeaderText = "Year of production";
                rankingDataGridView.Columns["MovieRating"].HeaderText = "Rating";

                rankingDataGridView.Columns["Counter"].HeaderText = "Number of ratings";
                
                foreach (DataGridViewRow r in rankingDataGridView.Rows)
                {
                    rankingDataGridView.Rows[r.Index].Cells["miejsceDataGridView"].Value = (r.Index + 1).ToString();

                }




            }

           
            rankingDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rankingDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            rankingDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            WireUpLists();
        }


    }
}
