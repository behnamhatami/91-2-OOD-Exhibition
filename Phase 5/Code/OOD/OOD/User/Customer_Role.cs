using System;
namespace Overview {
	public class Customer_Role : User_Role  {
		public void RequestForExhibition() {
			throw new System.Exception("Not implemented");
		}
		public void RequestForBoothConstruction() {
			throw new System.Exception("Not implemented");
		}
		public void RequestForGetBooth() {
			throw new System.Exception("Not implemented");
		}
		public void SpecialRequest() {
			throw new System.Exception("Not implemented");
		}
		public void AddPayment() {
			throw new System.Exception("Not implemented");
		}

		private Payment.Payment[] has2;
		private Requests.Request[] request2;

	}

}
