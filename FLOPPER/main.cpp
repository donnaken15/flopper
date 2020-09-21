#include <windows.h>
#include <iostream>
#include <csignal>
#include <math.h>
#include <cmath>

#define _USE_MATH_DEFINES

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
	"Minimalist CPU/GPU floating point operation benchmarker\n",
	"Options:",
	"\t--src [CPU|GPU]   | Choose which device to stress test",
	"\t--avg             | Display average FLOPS",
	"\t--raw             | Display raw number of flops (don't round)",
	"\t--ui              | Apply settings made for the visual interface",
	"\t--tdisp           | Display FLOPS from each thread",
	"\t--[lo|bi]         | Set FLOPS display by *iloFLOPS (base 1024) or *ibiFLOPS (base 1000)",
	"\t--int     1.000   | Set testing interval (seconds)  (apply with --ti)",
	"\t--os      1000000 | Set amount of FLOPS to run      (apply with --tc)",
	"\t--t       5       | Test a number of times (def. 5), 0 makes it run forever",
	"\t--asynk           | Override interval/--os, calculate infinitely, depend on asynchronous termination",
	"\t--mp 4            | Set number of threads to use",
	"\t--help            | Display this",
	"\t--q               | Quiet",
	"\nBenchmark settings:",
	"\t--t[i|c]                     \t | Set stress test mode (ti: interval based, tc: count based)",
	"\t                             \t | (--ti may be reduce performance)",
	"\t--im [p|t]                   \t | Set interval checking mode (p:erformance counter, t:ick count)",
	"\t--op  [NUL|ADD|SUB|MUL|",
	"\t       DIV|POW|PRINT|SIN|",
	"\t       COS|TAN|LN|LOG|",
	"\t       RND|FLR|SQRT]         \t | Set operations to use, can be entered multiple times",
	"\t\tNUL                      - do nothing, only use float as an operation",
	"\t\tADD,SUB,MUL,DIV,POW      - mathematic functions",
	"\t\tSIN,COS,TAN,LN,LOG       - trigonometry and logarithmic functions",
	"\t\tRND,FLR,SQRT             - round/floor/square root",
	"\t\tPRINT                    - printf testing, uses %.8f format",
	"\t--fl                         \t | Set floats to use, can be entered multiple times",
	"\t\t0.000        - 1e8       - novice",
	"\t\t0.000e-10    / 1e10      - standard",
	"\t\t0.000e-80    / 1e80      - heavy",
	"\t\t0.000e-200   / 1e200     - extreme",
	"\t--pi                         \t | Use pi (3.1415), can be entered multiple times\n"
	"\t--rng                        \t | Use random numbers, ignores --fl",
	"\t--ri                         \t | Random number difficulty (def. 0.1)\n"
	"\t--count                      \t | Integer based counter test, only depends on --t(i/c) and --int/--os",
}, units[] = {
	0, 'K', 'M', 'G', 'T', 'P', 'E'
};

enum OPS {
	NUL, ADD, SUB,  MUL,  DIV, POW,
	SIN, COS, TAN,  LN,   LOG,
	RND, FLR, SQRT, PRINT
};

static unsigned char mp = 1, unit = 0; static unsigned short flags = 0b0000000000000000;
// FLAGS
	static const unsigned short flag_mode      = 0b0000000000000001,
							    flag_avgp      = 0b0000000000000010,
							    flag_asynk     = 0b0000000000000100,
							    flag_src       = 0b0000000000001000,
							    flag_rng       = 0b0000000000010000,
							    flag_lobi      = 0b0000000000100000,
							    flag_avg       = 0b0000000001000000,
							    flag_tdisp     = 0b0000000010000000,
							    flag_count     = 0b0000000100000000,
							    flag_quiet     = 0b0000001000000000,
							    flag_ui        = 0b0000010000000000,
							    flag_arg2      = 0b0000100000000000,
							    flag_impc      = 0b0001000000000000;
static unsigned int long long flops, interval = 10000000, countup = 1000000000, times;
static LARGE_INTEGER tick, tick2;
static FLOAT flopdisp;
static const unsigned int long long onesecond = 10000000;

 FLOAT*floats [];
   OPS*ops    [];

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

int main(int argc, char*argv[])
{
	if (argc < 2)
	{
		for (int i = 0; i < 36; i++)
			puts(helppage[i]);
		//scanf_s("A");
	}
	else
	{
		signal(SIGINT, sig);
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
			//if ((strlen(argv[i]) > 2) || ((flags) & (flag_arg2)))
			if ((flags) & (flag_arg2))
			{
				if (flags | flag_arg2)
					flags &= ~flag_arg2;
			}
			else
			{
				if (argv[i][0] == '-')
				{
					if (argv[i][1] == '-')
					{
						switch (argv[i][2])
						{
						case 'a':
							if (argv[i][3] == 's')
								if (argv[i][4] == 'y')
									if (argv[i][5] == 'n')
										if (argv[i][6] == 'k')
											flags |= flag_asynk;
										else
											goto badarg;
									else
										goto badarg;
								else
									goto badarg;
							else
								goto badarg;
							break;
						case 't':
							if (strlen(argv[i]) == 3)
							{
								if (i < argc - 1)
								{
									times = atoi(argv[i + 1]);
									flags |= flag_arg2;
								}
								else
									printf("No value specified for argument: %s\n", argv[i]);
							}
							else
							{
								switch (argv[i][3])
								{
								case 'd':
									if (argv[i][4] == 'i')
										if (argv[i][5] == 's')
											if (argv[i][6] == 'p')
												flags |= flag_tdisp;
											else
												goto badarg;
										else
											goto badarg;
									else
										goto badarg;
									//maybe make func that uses string and return true if chars match and goto badarg if false
									break;
									// case 'i':
								case 'c':
									flags |= flag_mode;
									break;
								default:
									goto badarg;
									break;
								}
							}
							break;
						default:
							goto badarg;
							break;
						}
					}
					else goto badarg;
				}
				else
				{
				badarg:
					printf("Invalid argument: %s\n", argv[i]);
				}
			}
		}
		while (1)
		{
			{
				unsigned int long long i = 0;
				QueryPerformanceCounter(&tick);
				tick.QuadPart += interval;
#pragma omp parallel num_threads(mp+1) if(mp)
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
			/*{
				unsigned int long long i = 0;
				QueryPerformanceCounter(&tick);
#pragma omp parallel num_threads(mp+1) if(mp)
				{
					do
					{
						i++;
					} while (i < 1000000000);
					//printf("%llu+",i);
				}
				QueryPerformanceCounter(&tick2);
				flops += i;
			}*/
			flopdisp = FLOAT(flops);
			// which is better, cast or FLOAT(i)
			while (flopdisp >= 1000 && unit < 7)
			{
				unit++;
				flopdisp /= 1000; //incoming Xibif** or something
			}
			printf("CPU ");
			if (mp > 0)
				printf("+ MTx%03d ", mp+1);
			// --tc
			printf("@ %.3f %cFLOPS/%.2fs\n", flopdisp, units[unit], FLOAT(interval / 10000000));
			// --ti
			//printf("@ %.3f %cFLOPS in %.5fs\n", flopdisp, units[unit], (FLOAT(tick2.QuadPart - tick.QuadPart) / 10000000));
			unit = 0;
			flops = 0;
		}
	}
	return 0;
}