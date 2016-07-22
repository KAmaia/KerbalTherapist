using KerbalTherapist.Kerbals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KerbalTherapist.Forms {
	public class ChildForm : Form {
		protected Roster roster;
		public Roster Rstr { get { return roster; } set { roster = value; } }
	}
}
