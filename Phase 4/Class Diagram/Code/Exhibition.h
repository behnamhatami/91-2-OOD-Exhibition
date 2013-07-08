class Exhibition {

private:
	string name;
	string description;
	User owner;
	string full_description;
	User charis;
	Configuration configuration;
	string state;

public:
	Exhibition();

	void enterInformation();

	void changeConfiguration();

	void setFeatures();

	boolean startExhibition();

	boolean finsihExhibition();
};
