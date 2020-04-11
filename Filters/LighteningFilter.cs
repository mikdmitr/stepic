using System;

namespace MyPhotoshop
{
	public class LighteningFilter : IFilter
	{
		public ParameterInfo[] GetParameters()
		{
			return new []
			{
				new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
				
			};
		}
		
		public override string ToString ()
		{
			return "Осветление/затемнение";
		}
		
		public Photo Process(Photo original, double[] parameters)
		{
			var result=new Photo();
			result.width=original.width;
			result.height=original.height;
			result.data=new Pixel [result.width,result.height];
			
			for (int x=0;x<result.width;x++)
				for (int y=0;y<result.height;y++)
				{
					result.data[x, y] = new Pixel();
					result.data[x, y].red = original.data[x, y].red * parameters[0];
					result.data[x, y].green = original.data[x, y].green * parameters[0];
					result.data[x, y].blue = original.data[x, y].blue * parameters[0];
				}
					//for (int z=0;z<3;z++)
					//	result.data[x,y,z]=original.data[x,y,z]*parameters[0];
			return result;
		}
	}
}

