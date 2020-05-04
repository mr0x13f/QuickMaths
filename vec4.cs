namespace Quickmaths {

public partial struct vec4 {

    public static readonly vec4 X = new vec4(1,0,0,0);
    public static readonly vec4 Y = new vec4(0,1,0,0);
    public static readonly vec4 Z = new vec4(0,0,1,0);
    public static readonly vec4 W = new vec4(0,0,0,1);

	public float x;
	public float y;
	public float z;
	public float w;

	public float r {
		get { return x; }
		set { x = value; }}

	public float g {
		get { return y; }
		set { y = value; }}

	public float b {
		get { return z; }
		set { z = value; }}

	public float a {
		get { return w; }
		set { w = value; }}

	//////////////////////////////////////////////////////////////////////////
	// Constructors	 
	////////////////////////////////////////////////////////////////////////// 

	public vec4(float x, float y, float z, float w) {
		this.x = x;	  
		this.y = y;
		this.z = z;	
		this.w = w;
	}

	public vec4(float x) {
		this.x = x;	  
		this.y = x;
		this.z = x;	 
		this.w = x;
	}
    
    public vec4(vec3 xyz, float w) {
		this.x = xyz.x;	  
		this.y = xyz.y;
		this.z = xyz.z;	
		this.w = w;
	}
    
    public vec4(float x, vec3 yzw) {
		this.x = x;	  
		this.y = yzw.x;
		this.z = yzw.y;	
		this.w = yzw.z;
	}
    
    public vec4(vec2 xy, vec2 zw) {
		this.x = xy.x;	  
		this.y = xy.y;
		this.z = zw.x;	
		this.w = zw.y;
	}
    
    public vec4(vec2 xy, float z, float w) {
		this.x = xy.x;	  
		this.y = xy.y;
		this.z = z;	
		this.w = w;
	}
    
    public vec4(float x, float y, vec2 zw) {
		this.x = x;	  
		this.y = y;
		this.z = zw.x;	
		this.w = zw.y;
	}
    
    public vec4(float x, vec2 yz, float w) {
		this.x = x;	  
		this.y = yz.x;
		this.z = yz.y;	
		this.w = w;
	}

	//////////////////////////////////////////////////////////////////////////
	// Methods	 
	//////////////////////////////////////////////////////////////////////////

    public float dot(vec4 vec) {
        return this.x*vec.x + this.y+vec.y + this.z*vec.z + this.w*vec.w;
    }

    public vec4 cross(vec4 vec) {
		return new vec4(
		    this.y*vec.z + this.z*vec.y,
		    this.z*vec.w + this.w*vec.z,
		    this.w*vec.x + this.x*vec.w,
		    this.x*vec.y + this.y*vec.x );
    }


	public float magnitude() {
		return Math.sqrt(magnitude2());
	}

	public float magnitude2() {
		return x*x + y*y + z*z + w*w;
	}

	public vec4 normal() {
        float mag = magnitude();

        if (mag == 0)
            return this;

		return this / magnitude();
	}

    public vec4 trim(float length) {
        return this.normal() * length;
    }

    public vec4 clampLength(float min, float max) {
		return this.normal() * Math.clamp(this.magnitude(), min, max);
    }


    public vec4 abs() {
		return new vec4(
		   Math.abs(this.x),
		   Math.abs(this.y),
		   Math.abs(this.z),
		   Math.abs(this.w) );
    }

    public vec4 floor() {
		return new vec4(
		   Math.floor(this.x),
		   Math.floor(this.y),
		   Math.floor(this.z),
		   Math.floor(this.w) );
    }

    public vec4 ceil() {
		return new vec4(
		   Math.ceil(this.x),
		   Math.ceil(this.y),
		   Math.ceil(this.z),
		   Math.ceil(this.w) );
    }

    public vec4 clamp(vec4 min, vec4 max) {
		return new vec4(
		   Math.clamp(this.x, min.x, max.x),
		   Math.clamp(this.y, min.y, max.y),
		   Math.clamp(this.z, min.z, max.z),
		   Math.clamp(this.w, min.w, max.w) );
    }


    public static vec4 fromHex(string hex, float a=1) {
        if (hex[0] == '#')
            hex = hex.Substring(1);

        try {
            
            if (hex.Length == 8)
                return new vec4(
                    int.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(6,2), System.Globalization.NumberStyles.HexNumber) / 255f );
            else if (hex.Length == 6)
                return new vec4(
                    int.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    a );
            else
                return new vec4(0,0,0,a);

        } catch(System.FormatException) {
            return new vec4(0,0,0,a);
        }
    }

    public string toHex() {
        return ((int) Math.min(this.x * 255, 255)).ToString("X") + 
               ((int) Math.min(this.y * 255, 255)).ToString("X") + 
               ((int) Math.min(this.z * 255, 255)).ToString("X") + 
               ((int) Math.min(this.w * 255, 255)).ToString("X");
    }
  
	//////////////////////////////////////////////////////////////////////////
	// Overrides	 
	//////////////////////////////////////////////////////////////////////////

	override public string ToString() {
        return "(" + this.x + "," + this.y + "," + this.z + "," + this.w + ")";
	}

	override public bool Equals(object o) {
        if (!(o is vec4))
            return false;

		return this == (vec4) o;
	}
    
    override public int GetHashCode() {
        return this.ToString().GetHashCode();
	}

	//////////////////////////////////////////////////////////////////////////
	// Casting	 
	//////////////////////////////////////////////////////////////////////////

    public static implicit operator vec4(vec3 v) {
        return new vec4(
            v.x,
			v.y,
			v.z,
			0 );
    }

    public static explicit operator vec4(float[] v) {
        return new vec4( v[0], v[1], v[2], v[3] );
    }

    public static explicit operator float[](vec4 v) {
        return new float[] { v.x, v.y, v.z, v.w };
    }

	//////////////////////////////////////////////////////////////////////////
	// Operators	 
	//////////////////////////////////////////////////////////////////////////

	public static bool operator==(vec4 a, vec4 b) {
		return a.x == b.x
			&& a.y == b.y
			&& a.z == b.z
			&& a.w == b.w;
	}

	public static bool operator!=(vec4 a, vec4 b) {
		return a.x != b.x
			|| a.y != b.y
			|| a.z != b.z
			|| a.w != b.w;
	}

	public static vec4 operator+(vec4 a, vec4 b) {
		return new vec4(
			a.x + b.x,	
			a.y + b.y,
			a.z + b.z,
			a.w + b.w );
	}

	public static vec4 operator-(vec4 a, vec4 b) {
		return new vec4(
			a.x - b.x,	
			a.y - b.y,
			a.z - b.z,
			a.w - b.w );
	}

	public static vec4 operator-(vec4 a) {
		return new vec4(
			-a.x,	
			-a.y,
			-a.z,
			-a.w );
	}	

	public static vec4 operator*(vec4 a, vec4 b) {
		return new vec4(
			a.x * b.x,	
			a.y * b.y,
			a.z * b.z,
			a.w * b.w );
	}  	

	public static vec4 operator*(float a, vec4 b) {
		return new vec4(
			a * b.x,	
			a * b.y,
			a * b.z,
			a * b.w );
	}  	

	public static vec4 operator*(vec4 a, float b) {
		return new vec4(
			a.x * b,	
			a.y * b,
			a.z * b,
			a.w * b );
	}   

	public static vec4 operator/(vec4 a, vec4 b) {
		return new vec4(
			a.x / b.x,	
			a.y / b.y,
			a.z / b.z,
			a.w / b.w );
	} 	  

	public static vec4 operator/(float a, vec4 b) {
		return new vec4(
			a / b.x,	
			a / b.y,
			a / b.z,
			a / b.w );
	}  

	public static vec4 operator/(vec4 a, float b) {
		return new vec4(
			a.x / b,	
			a.y / b,
			a.z / b,
			a.w / b );
	} 		 

	public static vec4 operator%(vec4 a, vec4 b) {
		return new vec4(
			a.x % b.x,	
			a.y % b.y,
			a.z % b.z,
			a.w % b.w );
	} 	

}
}
