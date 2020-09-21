#include <windows.h>
#include <iostream>
#include <csignal>

char*signals[] = {
	0,"Hungup",
	"Interrupted",
	"Quitting",
	"Illegal operation",0,
	"Aborting",0,
	"FPE",
	"Killed",0,0,0,0,0,
	"Terminated"
}, *helppage[] = {
	"FLOPPER - developed by donnaken15\n",
	"Minimalist CPU/GPU benchmarker\n",
	"Options:",
	"\t--src [CPU|GPU]   | Choose which device to stress test",
	"\t--avg             | Display average FLOPS",
	"\t--raw             | Display raw number of flops",
	"\t--tdisp           | Display FLOPS from each thread",
	"\t--[lo|bi]         | Set FLOPS display by *iloFLOPS or *ibiFLOPS",
	"\t--int 1.000       | Set testing interval (seconds)",
	"\t--t 5             | Test a number of times (def. 5)",
	"\t--asynk           | Override interval, depend on asynchronous termination",
	"\t--help            | Display this",
	"\t--q               | Quiet",
	"\nBenchmark settings:",
	"\t--op  [NUL|ADD|SUB|MUL",
	"\t       MUL|DIV|POW|PRINT] \t| Set operations to use, can be entered multiple times",
	"\t\tNUL                     - do nothing, only use float as an operation",
	"\t\tADD,SUB,MUL,DIV,POW     - mathematic functions",
	"\t\tPRINT                   - printf testing, uses %.8f format",
	"\t--mp                      \t| Set number of threads to use",
	"\t--fl                      \t| Set floats to use, can be entered multiple times",
	"\t\t0.000        - 1e8      - novice",
	"\t\t0.000e-10    / 1e10     - standard",
	"\t\t0.000e-80    / 1e80     - heavy",
	"\t\t0.000e-200   / 1e200    - extreme",
	"\t--rng                     \t| Use random numbers, ignores --fl",
	"\t--ri                      \t| Random number difficulty (def. 0.1)"
	"\t--count                   \t| Integer based counter test, ignores almost all above args",
}, units[] = {
	0, 'K', 'M', 'G', 'T', 'P', 'E'
};

static unsigned char mp = 16, unit = 0, flags = 0b00000000;
// FLAGS
	static const unsigned char flag_avgp      = 0b00000001,
							   flag_asynk     = 0b00000010,
							   flag_src       = 0b00000100,
							   flag_rng       = 0b00001000,
							   flag_lobi      = 0b00010000,
							   flag_avg       = 0b00100000,
							   flag_tdisp     = 0b01000000,
							   flag_count     = 0b10000000;
static unsigned int long long flops, interval = 10000000;// , tick;
static LARGE_INTEGER tick, tick2;
static FLOAT flopdisp;

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
CPU + MP.# - 6.0 GLOPS/s - 1.5G/thread avg

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
	if (argc < 2)
	{
		for (int i = 0; i < 26; i++)
			puts(helppage[i]);
		//scanf_s("A");
	}
	else
	{
		signal(SIGINT, sig);
		//std::thread timer(fclock);
		for (int i = 1; i < argc; i++)
		{
			/*switch (*argv[i])
			{
			case *"--asynk":
				flags |= flag_asynk;
				break;
			case *"--avg":
				flags |= flag_avgp;
				break;
				figure this out, dont be a yandev :///
			}
			puts(argv[i]);
			printf("%d", flags);
			if (argv[i] == "--asynk")
				flags |= flag_asynk;
			if (argv[i] == "--avg")
				flags |= flag_avgp;
			if (argv[i] == "--rng")
				flags |= flag_rng;
			if (argv[i] == "--count")
				flags |= flag_count;
			puts(argv[i]);
			printf("%d", flags);
			// which is faster in this case, ifs or else ifs,
			// doesnt affect anything to use either i believe
			// scrap anyway, garbage string system*/
			if (argv[i][0])
			{

			}
		}
		while (1)
		{
			//flops = 0;
			//tick = GetTickCount64();
			//while (i < 100000000000)
			//do
				/*for (QueryPerformanceCounter(&tick); tick.QuadPart > tick2.QuadPart - 10000000; QueryPerformanceCounter(&tick2))
				i++*/
			unsigned int long long i = 0;
			/*if (flags & flag_asynk)
			{
#pragma omp parallel num_threads(mp+1) if(mp)
				while (1)
				{
					do
					{
						i++;
					} while (i < 1000000);
					//printf("%llu+",i);
					flops += i;
				}
			} else */{
				QueryPerformanceCounter(&tick);
				tick.QuadPart += interval;
#pragma omp parallel /*default(shared) shared(tick,tick2)*/ num_threads(mp+1) if(mp)
				{
					do
					{
						i++;
						QueryPerformanceCounter(&tick2);
					} while (tick.QuadPart > tick2.QuadPart);
					//printf("%llu+",i);
					flops += i;
				}
			}
			flopdisp = flops;
			while (flopdisp >= 1000 && unit < 7)
			{
				unit++;
				flopdisp /= 1000; //incoming Xibif** or something
			}
			printf("CPU - %.3f%cFLOPS/second\n", flopdisp, units[unit]);
			//printf("TEST MODE: counted to %.3f%c/second\n", flopdisp, units[unit]);
			//fprintf(stderr, "%llu\n", flops); // do for ui, make user require param to be entered for
			//printf("TEST MODE: counted to %llu\n",flops);
			unit = 0;
			flops = 0;
		}
	}
	return 0;
}