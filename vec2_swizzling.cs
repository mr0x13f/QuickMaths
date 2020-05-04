namespace Quickmaths {

public partial struct vec2 {

	public vec2.Swizzler swizzle => new vec2.Swizzler(this);

	public struct Swizzler {

		private vec2 vector;

		public Swizzler(vec2 vector) {
			this.vector = vector;
		}
		
		public float x => vector.x;
		public float y => vector.y;

		//////////////////////////////////////////////////////////////////////////
		// 2 components
		//////////////////////////////////////////////////////////////////////////
		public vec2 xx => new vec2(x,x);
		public vec2 xy => new vec2(x,y);
		public vec2 yx => new vec2(y,x);
		public vec2 yy => new vec2(y,y);

		//////////////////////////////////////////////////////////////////////////
		// 3 components
		//////////////////////////////////////////////////////////////////////////
		public vec3 xxx => new vec3(x,x,x);
		public vec3 xxy => new vec3(x,x,y);
		public vec3 xyx => new vec3(x,y,x);
		public vec3 xyy => new vec3(x,y,y);
		public vec3 yxx => new vec3(y,x,x);
		public vec3 yxy => new vec3(y,x,y);
		public vec3 yyx => new vec3(y,y,x);
		public vec3 yyy => new vec3(y,y,y);

		//////////////////////////////////////////////////////////////////////////
		// 4 components
		//////////////////////////////////////////////////////////////////////////
		public vec4 sxxxx => new vec4(x,x,x,x);
		public vec4 xxxy => new vec4(x,x,x,y);
		public vec4 xxyx => new vec4(x,x,y,x);
		public vec4 xxyy => new vec4(x,x,y,y);
		public vec4 xyxx => new vec4(x,y,x,x);
		public vec4 xyxy => new vec4(x,y,x,y);
		public vec4 xyyx => new vec4(x,y,y,x);
		public vec4 xyyy => new vec4(x,y,y,y);
		public vec4 yxxx => new vec4(y,x,x,x);
		public vec4 yxxy => new vec4(y,x,x,y);
		public vec4 yxyx => new vec4(y,x,y,x);
		public vec4 yxyy => new vec4(y,x,y,y);
		public vec4 yyxx => new vec4(y,y,x,x);
		public vec4 yyxy => new vec4(y,y,x,y);
		public vec4 yyyx => new vec4(y,y,y,x);
		public vec4 yyyy => new vec4(y,y,y,y);

	}
}
}