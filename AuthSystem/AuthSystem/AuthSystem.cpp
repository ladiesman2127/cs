#include <string>
#include <fstream>
#include <iostream>

class user
{
private:
	std::string login_;
	std::string password_;
public:
	user(std::string login, std::string password) : login_(std::move(login)),
		password_(std::move(password))
	{
	}
	bool check_user()
	{
		std::fstream fs;
		const std::string line = login_ + password_ + std::string();
		std::string check_line;
		fs.open("creditless.txt", std::fstream::in | std::fstream::out | std::fstream::app);
		while (!fs.eof())
		{
			std::getline(fs, check_line);
			if (check_line == line)
			{
				return true;
			}
		}
		fs.close();
		return false;
	}
	void add_user()
	{
		std::fstream fs;
		fs.open("creditless.txt", std::fstream::in | std::fstream::out | std::fstream::app);
		fs << login_ << password_ << '\n';
		fs.close();
	}


};
int main()
{
	std::cout << "Choose:\n1.Login\n2.Registration\n";
	int inp;
	std::cin >> inp;
	std::string login;
	std::string password;
	std::cout << "Login:\n";
	std::cin >> login;
	std::cout << "Password:\n";
	std::cin >> password;
	user user(login, password);
	if (inp == 1)
	{
		if (user.check_user())
		{
			std::cout << "Welcome!\n";
		}
		else
			std::cout << "Incorrect data!\n";
	}
	else user.add_user();
	return 0;
}
