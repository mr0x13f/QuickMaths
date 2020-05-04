namespace Quickmaths {

public partial struct vec3 {

	public vec3.Swizzler swizzle => new vec3.Swizzler(this);

	public struct Swizzler {
		
		private vec3 vector;

		public Swizzler(vec3 vector) {
			this.vector = vector;
		}
		
		public float x => vector.x;
		public float y => vector.y;
		public float z => vector.z;

		//////////////////////////////////////////////////////////////////////////
		// 2 components
		//////////////////////////////////////////////////////////////////////////
		public vec2 xx => new vec2(x,x);
		public vec2 xy => new vec2(x,y);
		public vec2 xz => new vec2(x,z);
		public vec2 yx => new vec2(y,x);
		public vec2 yy => new vec2(y,y);
		public vec2 yz => new vec2(y,z);
		public vec2 zx => new vec2(z,x);
		public vec2 zy => new vec2(z,y);
		public vec2 zz => new vec2(z,z);

		//////////////////////////////////////////////////////////////////////////
		// 3 components
		//////////////////////////////////////////////////////////////////////////
		public vec3 xxx => new vec3(x,x,x);
		public vec3 xxy => new vec3(x,x,y);
		public vec3 xxz => new vec3(x,x,z);
		public vec3 xyx => new vec3(x,y,x);
		public vec3 xyy => new vec3(x,y,y);
		public vec3 xyz => new vec3(x,y,z);
		public vec3 xzx => new vec3(x,z,x);
		public vec3 xzy => new vec3(x,z,y);
		public vec3 xzz => new vec3(x,z,z);
		public vec3 yxx => new vec3(y,x,x);
		public vec3 yxy => new vec3(y,x,y);
		public vec3 yxz => new vec3(y,x,z);
		public vec3 yyx => new vec3(y,y,x);
		public vec3 yyy => new vec3(y,y,y);
		public vec3 yyz => new vec3(y,y,z);
		public vec3 yzx => new vec3(y,z,x);
		public vec3 yzy => new vec3(y,z,y);
		public vec3 yzz => new vec3(y,z,z);
		public vec3 zxx => new vec3(z,x,x);
		public vec3 zxy => new vec3(z,x,y);
		public vec3 zxz => new vec3(z,x,z);
		public vec3 zyx => new vec3(z,y,x);
		public vec3 zyy => new vec3(z,y,y);
		public vec3 zyz => new vec3(z,y,z);
		public vec3 zzx => new vec3(z,z,x);
		public vec3 zzy => new vec3(z,z,y);
		public vec3 zzz => new vec3(z,z,z);

		//////////////////////////////////////////////////////////////////////////
		// 4 components
		//////////////////////////////////////////////////////////////////////////
		public vec4 xxxx => new vec4(x,x,x,x);
		public vec4 xxxy => new vec4(x,x,x,y);
		public vec4 xxxz => new vec4(x,x,x,z);
		public vec4 xxyx => new vec4(x,x,y,x);
		public vec4 xxyy => new vec4(x,x,y,y);
		public vec4 xxyz => new vec4(x,x,y,z);
		public vec4 xxzx => new vec4(x,x,z,x);
		public vec4 xxzy => new vec4(x,x,z,y);
		public vec4 xxzz => new vec4(x,x,z,z);
		public vec4 xyxx => new vec4(x,y,x,x);
		public vec4 xyxy => new vec4(x,y,x,y);
		public vec4 xyxz => new vec4(x,y,x,z);
		public vec4 xyyx => new vec4(x,y,y,x);
		public vec4 xyyy => new vec4(x,y,y,y);
		public vec4 xyyz => new vec4(x,y,y,z);
		public vec4 xyzx => new vec4(x,y,z,x);
		public vec4 xyzy => new vec4(x,y,z,y);
		public vec4 xyzz => new vec4(x,y,z,z);
		public vec4 xzxx => new vec4(x,z,x,x);
		public vec4 xzxy => new vec4(x,z,x,y);
		public vec4 xzxz => new vec4(x,z,x,z);
		public vec4 xzyx => new vec4(x,z,y,x);
		public vec4 xzyy => new vec4(x,z,y,y);
		public vec4 xzyz => new vec4(x,z,y,z);
		public vec4 xzzx => new vec4(x,z,z,x);
		public vec4 xzzy => new vec4(x,z,z,y);
		public vec4 xzzz => new vec4(x,z,z,z);
		public vec4 yxxx => new vec4(y,x,x,x);
		public vec4 yxxy => new vec4(y,x,x,y);
		public vec4 yxxz => new vec4(y,x,x,z);
		public vec4 yxyx => new vec4(y,x,y,x);
		public vec4 yxyy => new vec4(y,x,y,y);
		public vec4 yxyz => new vec4(y,x,y,z);
		public vec4 yxzx => new vec4(y,x,z,x);
		public vec4 yxzy => new vec4(y,x,z,y);
		public vec4 yxzz => new vec4(y,x,z,z);
		public vec4 yyxx => new vec4(y,y,x,x);
		public vec4 yyxy => new vec4(y,y,x,y);
		public vec4 yyxz => new vec4(y,y,x,z);
		public vec4 yyyx => new vec4(y,y,y,x);
		public vec4 yyyy => new vec4(y,y,y,y);
		public vec4 yyyz => new vec4(y,y,y,z);
		public vec4 yyzx => new vec4(y,y,z,x);
		public vec4 yyzy => new vec4(y,y,z,y);
		public vec4 yyzz => new vec4(y,y,z,z);
		public vec4 yzxx => new vec4(y,z,x,x);
		public vec4 yzxy => new vec4(y,z,x,y);
		public vec4 yzxz => new vec4(y,z,x,z);
		public vec4 yzyx => new vec4(y,z,y,x);
		public vec4 yzyy => new vec4(y,z,y,y);
		public vec4 yzyz => new vec4(y,z,y,z);
		public vec4 yzzx => new vec4(y,z,z,x);
		public vec4 yzzy => new vec4(y,z,z,y);
		public vec4 yzzz => new vec4(y,z,z,z);
		public vec4 zxxx => new vec4(z,x,x,x);
		public vec4 zxxy => new vec4(z,x,x,y);
		public vec4 zxxz => new vec4(z,x,x,z);
		public vec4 zxyx => new vec4(z,x,y,x);
		public vec4 zxyy => new vec4(z,x,y,y);
		public vec4 zxyz => new vec4(z,x,y,z);
		public vec4 zxzx => new vec4(z,x,z,x);
		public vec4 zxzy => new vec4(z,x,z,y);
		public vec4 zxzz => new vec4(z,x,z,z);
		public vec4 zyxx => new vec4(z,y,x,x);
		public vec4 zyxy => new vec4(z,y,x,y);
		public vec4 zyxz => new vec4(z,y,x,z);
		public vec4 zyyx => new vec4(z,y,y,x);
		public vec4 zyyy => new vec4(z,y,y,y);
		public vec4 zyyz => new vec4(z,y,y,z);
		public vec4 zyzx => new vec4(z,y,z,x);
		public vec4 zyzy => new vec4(z,y,z,y);
		public vec4 zyzz => new vec4(z,y,z,z);
		public vec4 zzxx => new vec4(z,z,x,x);
		public vec4 zzxy => new vec4(z,z,x,y);
		public vec4 zzxz => new vec4(z,z,x,z);
		public vec4 zzyx => new vec4(z,z,y,x);
		public vec4 zzyy => new vec4(z,z,y,y);
		public vec4 zzyz => new vec4(z,z,y,z);
		public vec4 zzzx => new vec4(z,z,z,x);
		public vec4 zzzy => new vec4(z,z,z,y);
		public vec4 zzzz => new vec4(z,z,z,z);

	}
}
}