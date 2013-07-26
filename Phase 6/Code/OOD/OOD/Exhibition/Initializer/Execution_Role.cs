using System;
namespace Overview {
	public class Execution_Role : Exhibition_Role  {
		public void GetNews() {
			throw new System.Exception("Not implemented");
		}
		public void AddNews() {
			throw new System.Exception("Not implemented");
		}
		public void CreatePoll() {
			throw new System.Exception("Not implemented");
		}
		public void EditExhibitionInfo() {
			throw new System.Exception("Not implemented");
		}
		public void GetPublicInformation() {
			throw new System.Exception("Not implemented");
		}

		private Notification And News.News news;
		private Meeting.Meeting[] invite2;
		private Poll.Poll[] create2;

	}

}
