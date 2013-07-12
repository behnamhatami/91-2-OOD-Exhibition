using System;
namespace Overview {
	public class Public_Role : User_Role  {
		public void RequestForVisitorReport() {
			throw new System.Exception("Not implemented");
		}
		public void AnswerToPoll() {
			throw new System.Exception("Not implemented");
		}

		private Poll.Poll[] attends;

	}

}
