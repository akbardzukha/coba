
// ParallelSPSS.Form1
extern "C" __global__  void addVector( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N);
// ParallelSPSS.Form1
extern "C" __global__  void compare_max( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N);
// ParallelSPSS.Form1
extern "C" __global__  void compare_min( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N);
// ParallelSPSS.Form1
extern "C" __global__  void sum( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N);

// ParallelSPSS.Form1
extern "C" __global__  void addVector( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N)
{
	for (int i = threadIdx.x + blockIdx.x * blockDim.x; i < N; i += gridDim.x)
	{
		c[(i)] = a[(i)] + b[(i)];
	}
}
// ParallelSPSS.Form1
extern "C" __global__  void compare_max( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N)
{
	for (int i = threadIdx.x + blockIdx.x * blockDim.x; i < N; i += gridDim.x)
	{
		if (a[(i)] > b[(i)])
		{
			c[(i)] = a[(i)];
		}
		else
		{
			c[(i)] = b[(i)];
		}
	}
}
// ParallelSPSS.Form1
extern "C" __global__  void compare_min( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N)
{
	for (int i = threadIdx.x + blockIdx.x * blockDim.x; i < N; i += gridDim.x)
	{
		if (a[(i)] < b[(i)])
		{
			c[(i)] = a[(i)];
		}
		else
		{
			c[(i)] = b[(i)];
		}
	}
}
// ParallelSPSS.Form1
extern "C" __global__  void sum( float* a, int aLen0,  float* b, int bLen0,  float* c, int cLen0, int N)
{
	for (int i = threadIdx.x + blockIdx.x * blockDim.x; i < N; i += gridDim.x)
	{
		c[(i)] = a[(i)] + b[(i)];
	}
}
