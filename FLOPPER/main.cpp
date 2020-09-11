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

char units[] = {
	0x0, 'K', 'M', 'G', 'T', 'P', 'E'
};

static unsigned char mp = 13, unit = 0;
//static std::atomic<unsigned int long long> flops;
//unsigned int long long tick;
static unsigned int long long flops;// , tick;
static LARGE_INTEGER tick, tick2;
static FLOAT flopdisp;
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
		Sleep(100);
		QueryPerformanceCounter(&tick2);
	}
}*/

int main(int argc, char*argv[])
{
	signal(SIGINT, sig);

	//std::thread timer(fclock);

	while (1)
	{
		//flops = 0;
		//tick = GetTickCount64();
		unsigned int long long i = 0;
		//while (i < 100000000000)
		//do
			/*for (QueryPerformanceCounter(&tick); tick.QuadPart > tick2.QuadPart - 10000000; QueryPerformanceCounter(&tick2))
			i++*/
		QueryPerformanceCounter(&tick);
#pragma omp parallel /*default(shared) shared(tick,tick2)*/ num_threads(mp+1) if(mp)
		{
			do
			{
				i++;
				QueryPerformanceCounter(&tick2);
			} while (tick.QuadPart > tick2.QuadPart - 10000000);
			//printf("%llu+",i);
			flops += i;
		}
		flopdisp = flops;
		while (flopdisp >= 1000 && unit < 7)
		{
			unit++;
			flopdisp /= 1000;
		}
		printf("TEST MODE: counted to %.3f%c/second\n", flopdisp, units[unit]);
		fprintf(stderr,"%d\n", flops);
		//printf("TEST MODE: counted to %llu\n",flops);
		unit = 0;
		flops = 0;
	}
	return 0;
}