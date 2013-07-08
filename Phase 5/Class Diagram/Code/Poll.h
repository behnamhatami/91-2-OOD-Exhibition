namespace Poll {
	class Poll {

	private:
		string question;
		date creation_date;
	
		date finish_date;

	public:
		Poll();
	
		void addChoice();
	
		void removeChoice();
	
		void finishPoll();
	
		void hitChoice();
	
		String getResult();
	};
}
