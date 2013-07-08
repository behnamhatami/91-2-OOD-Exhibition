namespace Poll {
	class Poll_Choice {

	private:
		string content;
		int number_of_hit;
		date creation_date;
		Roles votees;
		Poll::Poll poll;

	public:
		void PollChoice();
	
		void hitChoice();
	
		String getVoteeResult();
	};
}
