#include <iostream>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	
	int score;
	
	cin >> score;
	
	if (90 <= score && score <= 100)
		cout << "A\n";
	else if (80 <= score)
		cout << "B\n";
	else if (70 <= score)
		cout << "C\n";
	else if (60 <= score)
		cout << "D\n";
	else
		cout << "F\n";
		
	return 0;
	
}
