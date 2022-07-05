#include <stack>
#include <iostream>
#include <list>
#include <string>
#include <vector>
#include <queue>

class Range
{
public:
	int start, end, sum;
	Range(int start, int end, int sum)
	{
		this->start = start;
		this->end = end;
		this->sum = sum;
	}
};
Range& findMaxRange(const int* arr, const int size)
{
	int curSum = 0;
	int start = 0, end = 0;
	Range* maxRange = nullptr;
	for (int end = 0; end < size; ++end)
	{
		curSum += arr[end];
		if (maxRange == nullptr || curSum > maxRange->sum)
		{
			maxRange = new Range(start, end, curSum);
		}
		if (curSum < 0)
		{
			curSum = 0;
			start = end + 1;
		}
	}
	return *maxRange;
}

std::string check_brackets(const std::string str)
{
	std::stack<std::pair<char, int>> open_brackets;
	int top = 0;
	int curr_pos = 0;
	for (auto ch : str)
	{
		++curr_pos;
		if (ch == '(' || ch == '[' || ch == '{')
		{
			open_brackets.emplace(ch, curr_pos);
		}
		else if (ch == ')' || ch == ']' || ch == '}')
		{
			if (open_brackets.empty())
			{
				return std::to_string(curr_pos);
			}
			if (!open_brackets.empty())
			{
				top = open_brackets.top().first;
				open_brackets.pop();
				if (ch == ')' && top != '(' || ch == ']' && top != '[' || ch == '}' && top != '{')
				{
					return std::to_string(curr_pos);
				}
			}

		}
	}

	if (curr_pos != str.length())
	{
		return std::to_string(curr_pos);
	}
	if (open_brackets.empty())
	{
		return  "0";
	}
	return std::to_string(open_brackets.top().second);
}

void tree_height()
{
	int n;
	std::cin >> n;
	std::vector<int> tree(n);
	for (int i = 0; i < n; i++) {
		std::cin >> tree[i];
	}
	int max = 0;
	int cnt = 0;
	for (int i = 0; i < n; i++) {
		int current = tree[i];
		cnt = 1;
		while (current != -1) {
			current = tree[current];
			cnt++;
		}
		//индекс указывает на то родителем чего явлется текущий эл массива
		//то есть для обхода узлов дерево до корня необходимо проходить цикл до тех пор пока
		//a[i] != i; в данном случае мы дошли до корня дерева!
		if (cnt > max) {
			max = cnt;
		}
	}

	std::cout << max << std::endl;
}

void net_package_sim()
{
	int size, n;
	std::cin >> size >> n;
	std::queue<int> buffer;
	std::list<std::pair<int, int>> list;
	for (int i = 0; i < n; ++i)
	{
		int arrival, duration;
		std::cin >> arrival >> duration;
		list.emplace_back(arrival, duration);
	}
	for (int i = 0; i < n; ++i)
	{
		int arrival = list.front().first;
		int duration = list.front().second;
		list.pop_front();
		while (!buffer.empty() && buffer.front() <= arrival)
		{
			buffer.pop();
		}
		int Res = -1;
		if (buffer.size() < size)
		{
			Res = arrival;
			arrival += duration;
			buffer.push(arrival);
		}
		std::cout << Res << '\n';
	}

}

int cache[100][100];
int paths(const int n, const int m)
{
	if (n <= 1 || m <= 1)
	{
		return 0;
	}
	if (n == 1 && m == 1)
	{
		return 1;
	}
	if (cache[n][m] == 0)
		cache[n][m] = paths(n - 1, m) + paths(n, m - 1);
	return cache[n][m];
}



int main()
{
	//const int arr[] = { 10, -8, -12, 3, 17, 5, 0, 7, -18, 20 };
	//findMaxRange(arr,std::size(arr));
	//check_brackets("([](){([])})");
	//tree_height();
	//assert(check_brackets("({([])})") == "0");
	//assert(check_brackets("()[]}") == "5");
	//assert(check_brackets("{{[()]]") == "7");
	//assert(check_brackets("{{{[][][]") == "3");
	//assert(check_brackets("{*{{}") == "3");
	//assert(check_brackets("[[*") == "2");
	//assert(check_brackets("{*}") == "0");
	//assert(check_brackets("{{") == "2");
	//assert(check_brackets("{}") == "0");
	//assert(check_brackets("") == "0");
	//assert(check_brackets("}") == "1");
	//assert(check_brackets("*{}") == "0");
	//assert(check_brackets("{{{**[][][]") == "3");
	//net_package_sim();
	
}

