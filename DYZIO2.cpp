

using namespace std;

int* euklides()
{
array = new unsigned int [ 10^6 ];
  lp = 0; k  = 1; d  = 1; p = 2;
  while( lp < 10^6 )
  {
   
    if( lp < 3 ) p += lp;
    else
    {
      p = 6 * k + d;
      if( d == 1 )
      {
        d = -1; k++;
      }
      else d = 1;
      g = ( unsigned int )sqrt ( p );
      for( i = 2; tlp [ i ] <= g; i++ )
        if( ! ( p % tlp [ i ] ) )
        {
          t = false;
          break;
        }
    }
}
return array;
}

//int euklides(int & counter,int & a)
//{
  //  for(int i=a+1; i<=10^6;i++)
   // {
   //     if(a%i==0) return counter;
  //  }
  //  return ++counter;
    
//}


int main()
{
    int* array=euklides();
    int results[N];
    int a,b,N,counter;
    cin>>N;
   
    //int results[N];
    for(int i=0;i<N;i++)
    {
        for(int j=a;j<=b;j++)
        {
          for(int result: array)
          {
            if(result==j)
              {
              counter++;
              break;
              }
          }
          
        }
         results[i]=counter; 
         counter=0;
    }
    cin>>a>>b;
  for(int i : results)
  
    cout<<i<<endl;

    return 0;
}