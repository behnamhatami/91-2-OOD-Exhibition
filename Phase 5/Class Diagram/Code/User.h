class User {

private:
	string Username;
	string first_name;
	string family_name;
	long phone_number;

	string password;

public:
	boolean changePassword();

	void addExhibitionRole();

	void removeExhibitonRole();

	boolean login();
};
