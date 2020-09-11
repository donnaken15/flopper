#include <windows.h>
#include <iostream>
#include <csignal>
#include <thread>
#include <atomic>

char*signals[] = {
	0,"Hungup",
	"Interrupted",
	"Quitting",
	"Illegal operation",0,
	"Aborting",0,
	"FPE",
	"Killed",0,0,0,0,0,
	"Terminated"
};

static unsigned char mp = 15;
//static std::atomic<unsigned int long long> flops;
//unsigned int long long tick;
static unsigned int long long flops, tick;
//static unsigned char onesecond = 0;

void sig(int signum) {
	puts(signals[signum]);
	exit(signum);
}

/*

more planning:
include difficulties for ui that test specific values

allow changing of timing method: tick based, perfcount based, sleep based etc

print like:

CPU - 3.0 GFLOPS/s - floats involved maybe
CPU + MP - 6.0 GLOPS/s - 1.5G/thread avg

*/

/*template<typename BaseType>
struct atomic
{
	operator BaseType () const volatile;
};*/

/*void fclock()
{
	while (1) {
		Sleep(1000);
		::onesecond = 1;
		printf("asdf");
	}
}*/

int main(int argc, char*argv[])
{
	signal(SIGINT, sig);

	//std::thread timer(fclock);

	while (1)
	{
		//flops = 0;
		tick = GetTickCount64();
#pragma omp parallel /*default(shared) shared(flops)*/ num_threads(mp+1) if(mp)
		{
			unsigned int long long i = 0;
			while (tick > GetTickCount64() - 5000)
			//while (i < 100000000000)
			{
				i++;
			}
			flops += i;
		}
		printf("%llu\n",flops);
		flops = 0;
	}
	return 0;
}