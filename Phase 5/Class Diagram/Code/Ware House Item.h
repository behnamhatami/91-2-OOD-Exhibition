class Ware_House_Item {

private:
	string name;
	User owner;
	long registration_code;
	date entrance_date;
	date release_date;

public:
	Ware_House_Item();

	void releaseItem();
};
