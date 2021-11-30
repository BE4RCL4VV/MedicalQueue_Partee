using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Partee
{
	public class Node
	{
		private Patient _data;
		private Node _next;

		public Patient Data
		{
			get { return _data; }
			set { _data = value; }
		}

		public Node Next
		{
			get { return _next; }
			set { _next = value; }
		}

		public Node(Patient Data)
		{
			_data = Data;
		}

	}
}
