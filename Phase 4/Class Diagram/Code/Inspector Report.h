namespace Report {
	class Inspector_Report {

	private:
		string comment;
		date creation_date;
		Booth::Booth booth;

	public:
		Inspector_Report();
	
		void showReport();
	};
}
