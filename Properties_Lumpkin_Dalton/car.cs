using System;
using System.Collections.Generic;
using System.Text;

namespace Properties_Lumpkin_Dalton
{
    class car
    {
		private string model;

		// sets properties for model
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		// gets and sets for Make
		public string Make
		{
			get; set;
		}
	}
}
