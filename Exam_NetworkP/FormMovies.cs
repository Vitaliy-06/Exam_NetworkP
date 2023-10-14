using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Exam_NetworkP
{

	// 37e7f9dd

	public partial class FormMovies : Form
	{
		private readonly string apiKey = "37e7f9dd";

		public FormMovies()
		{
			InitializeComponent();
			comboBoxPlot.SelectedIndex = 0;
		}

		private async void buttonSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxSearchTitle.Text))
				return;


			WebClient client = new WebClient();
			client.Encoding = Encoding.UTF8;

			string page;
			try
			{
				if (!string.IsNullOrEmpty(textBoxSearchYear.Text))
					page = await client.DownloadStringTaskAsync(
					$"https://www.omdbapi.com/?apikey={apiKey}&t={textBoxSearchTitle.Text}&y={textBoxSearchYear.Text}&plot={comboBoxPlot.SelectedItem}"
					);
				else
					page = await client.DownloadStringTaskAsync(
					$"https://www.omdbapi.com/?apikey={apiKey}&t={textBoxSearchTitle.Text}&plot={comboBoxPlot.SelectedItem}"
					);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
			Console.WriteLine(page);


			var json = JsonConvert.DeserializeObject<Root>(page);


			if (json.Response == "False")
			{
				pictureBoxPoster.Image = new Bitmap($"{Directory.GetCurrentDirectory()}\\NotFound.png");
				textBoxTitle.Text = "Not Found";
				textBoxYear.Text = "Not Found";
				textBoxCountry.Text = "Not Found";
				textBoxMetascore.Text = "Not Found";
				textBoxGenre.Text = "Not Found";
				textBoxType.Text = "Not Found";
				richTextBoxDesc.Text = "Not Found";
				return;
			}

			if (json.Poster == "N/A")
				pictureBoxPoster.Image = new Bitmap($"{Directory.GetCurrentDirectory()}\\NotFound.png");
			else
				pictureBoxPoster.Image = ConvertToPicture(json.Poster);

			textBoxTitle.Text = json.Title;
			textBoxYear.Text = json.Year;
			textBoxCountry.Text = json.Country;
			textBoxMetascore.Text = json.Metascore;
			textBoxGenre.Text = json.Genre;
			textBoxType.Text = json.Type;
			richTextBoxDesc.Text = json.Plot;

		}


		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private static Bitmap ConvertToPicture(string img)
		{
			Bitmap poster = null;
			using (HttpClient httpClient = new HttpClient())
			{
				byte[] posterData = httpClient.GetByteArrayAsync(img).Result;

				using (MemoryStream stream = new MemoryStream(posterData))
				{
					poster = new Bitmap(stream);
				}
			}
			return poster;
		}

	}
}
