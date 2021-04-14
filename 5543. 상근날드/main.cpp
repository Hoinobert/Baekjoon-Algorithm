#include <iostream>

using namespace std;

int main()
{
	ios_base::sync_with_stdio(false);
	cin.tie(NULL);
	cout.tie(NULL);
	
	int hamLow = 2000;
	int sodaLow = 1000;
	
	for (int i = 0; i < 3; i++)
	{
		int hamburger;
		cin >> hamburger;
		if (hamburger < hamLow)
			hamLow = hamburger;
	}
	
	for (int i = 0; i < 2; i++)
	{
		int soda;
		cin >> soda;
		if (soda < sodaLow)
			sodaLow = soda;
	}
	
	cout << hamLow + sodaLow - 50 << endl;
	
	return 0;
}
