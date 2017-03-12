using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ReliefValveCalculator
{
	public partial class ReliefValvePage : ContentPage
	{
		public ReliefValvePage()
		{
			InitializeComponent();
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			double diameter = Convert.ToDouble(txtDiameter.Text);
			double length = Convert.ToDouble(txtLength.Text);
			double refrigerantFactor = 0.7;

			double volume = (Math.PI / 4.0) * Math.Pow(diameter, 2) * length * refrigerantFactor;
			txtHansenRating.Text=volume.ToString();
				
			                                  
		}
	}
}
