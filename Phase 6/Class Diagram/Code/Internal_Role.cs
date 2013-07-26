using System;
namespace Overview {
	public class Internal_Role : User_Role  {
		public Exhibition ListExhibitions() {
			throw new System.Exception("Not implemented");
		}
		public String GetExhibitionInfo() {
			throw new System.Exception("Not implemented");
		}
		public String GetExhibitionReport() {
			throw new System.Exception("Not implemented");
		}

		private Report.Report[] create2;

	}

}
