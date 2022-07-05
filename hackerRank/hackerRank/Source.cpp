#include <algorithm>
#include <iostream>
#include <map>
#include <string>
#include <unordered_map>
#include <vector>


int sockMerchant(int n, std::vector<int> ar) {
	int cntOfPairs = 0;
	for (auto i = ar.begin(); i != ar.end(); ++i)
	{
		for (auto j = i; j != ar.end(); ++j)
		{
			std::cout << *i << " " << *j << '\n';
			if (*i == *j && i._Ptr != j._Ptr)
			{
				++cntOfPairs;
				//std::advance(i, 1);
				ar.erase(j);
				break;
			}
		}
	}
	return cntOfPairs;
}

int sockMerchant2(int n, std::vector<int> ar) {
	std::unordered_map<int, unsigned> counts;
	int result = 0;
	for (auto value : ar)
	{
		++counts[value];
	}
	for (auto count : counts)
	{
		if (count.second / 2 >= 1)
			result += count.second / 2;
	}
	return result;


}
std::size_t duplicateCount(const char* in) {
	std::unordered_map<char, unsigned> counts;
	for (const char* c = in; *c != '\0'; ++c) {
		++counts[tolower(*c)];
	}
	return std::count_if(cbegin(counts), cend(counts), [](const auto& count) {
		return count.second > 1;
		});
}

int main()
{
	std::vector<int> arr{ 10, 20,20, 10, 10, 30, 50, 10, 20 };
	std::cout << sockMerchant2(9, arr) << '\n';

	return 0;
}

