namespace Quickmaths {

public partial struct vec3 {

    public static readonly vec3 X = new vec3(1,0,0);
    public static readonly vec3 Y = new vec3(0,1,0);
    public static readonly vec3 Z = new vec3(0,0,1);

	public float x;
	public float y;
	public float z;

	public float r {
		get { return x; }
		set { x = value; }}

	public float g {
		get { return y; }
		set { y = value; }}

	public float b {
		get { return z; }
		set { z = value; }}

	//////////////////////////////////////////////////////////////////////////
	// Constructors	 
	////////////////////////////////////////////////////////////////////////// 

	public vec3(float x, float y, float z) {
		this.x = x;	  
		this.y = y;
		this.z = z;	
	}

	public vec3(float x) {
		this.x = x;	  
		this.y = x;
		this.z = x;	 
	}
    
    public vec3(vec2 xy, float z) {
		this.x = xy.x;	  
		this.y = xy.y;
        this.z = z;
	}
    
    public vec3(float x, vec2 yz) {
		this.x = x;	
        this.y = yz.x;
        this.z = yz.y;
	}

	//////////////////////////////////////////////////////////////////////////
	// Methods	 
	//////////////////////////////////////////////////////////////////////////

    public float dot(vec3 vec) {
        return this.x*vec.x + this.y+vec.y + this.z*vec.z;
    }

    public vec3 cross(vec3 vec) {
		return new vec3(
		    this.y*vec.z + this.z*vec.y,
		    this.z*vec.x + this.x*vec.z,
		    this.x*vec.y + this.y*vec.x );
    }


	public float magnitude() {
		return Math.sqrt(magnitude2());
	}

	public float magnitude2() {
		return x*x + y*y + z*z;
	}

	public vec3 normal() {
        float mag = magnitude();

        if (mag == 0)
            return this;

		return this / magnitude();
	}

    public vec3 trim(float length) {
        return this.normal() * length;
    }

    public vec3 clampLength(float min, float max) {
		return this.normal() * Math.clamp(this.magnitude(), min, max);
    }


    public vec3 abs() {
		return new vec3(
		   Math.abs(this.x),
		   Math.abs(this.y),
		   Math.abs(this.z) );
    }

    public vec3 floor() {
		return new vec3(
		   Math.floor(this.x),
		   Math.floor(this.y),
		   Math.floor(this.z) );
    }

    public vec3 ceil() {
		return new vec3(
		   Math.ceil(this.x),
		   Math.ceil(this.y),
		   Math.ceil(this.z) );
    }

    public vec3 clamp(vec3 min, vec3 max) {
		return new vec3(
		   Math.clamp(this.x, min.x, max.x),
		   Math.clamp(this.y, min.y, max.y),
		   Math.clamp(this.z, min.z, max.z) );
    }


    public static vec3 fromHex(string hex) {
        if (hex[0] == '#')
            hex = hex.Substring(1);

        try {
            
            if (hex.Length == 6)
                return new vec3(
                    int.Parse(hex.Substring(0,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(2,2), System.Globalization.NumberStyles.HexNumber) / 255f,
                    int.Parse(hex.Substring(4,2), System.Globalization.NumberStyles.HexNumber) / 255f );
            else
                return new vec3(0,0,0);

        } catch(System.FormatException) {
            return new vec3(0,0,0);
        }
    }

    public string toHex() {
        return ((int) Math.min(this.x * 255, 255)).ToString("X") + 
               ((int) Math.min(this.y * 255, 255)).ToString("X") + 
               ((int) Math.min(this.z * 255, 255)).ToString("X");
    }
  
	//////////////////////////////////////////////////////////////////////////
	// Overrides	 
	//////////////////////////////////////////////////////////////////////////

	override public string ToString() {
        return "(" + this.x + "," + this.y + "," + this.z + ")";
	}

	override public bool Equals(object o) {
        if (!(o is vec3))
            return false;

		return this == (vec3) o;
	}
    
    override public int GetHashCode() {
        return this.ToString().GetHashCode();
	}

	//////////////////////////////////////////////////////////////////////////
	// Casting	 
	//////////////////////////////////////////////////////////////////////////

    public static explicit operator vec3(float[] v) {
        return new vec3( v[0], v[1], v[2] );
    }

    public static explicit operator float[](vec3 v) {
        return new float[] { v.x, v.y, v.z };
    }

	//////////////////////////////////////////////////////////////////////////
	// Operators	 
	//////////////////////////////////////////////////////////////////////////

	public static bool operator==(vec3 a, vec3 b) {
		return a.x == b.x
			&& a.y == b.y
			&& a.z == b.z;
	}

	public static bool operator!=(vec3 a, vec3 b) {
		return a.x != b.x
			|| a.y != b.y
			|| a.z != b.z;
	}

	public static vec3 operator+(vec3 a, vec3 b) {
		return new vec3(
			a.x + b.x,	
			a.y + b.y,
			a.z + b.z );
	}

	public static vec3 operator-(vec3 a, vec3 b) {
		return new vec3(
			a.x - b.x,	
			a.y - b.y,
			a.z - b.z );
	}

	public static vec3 operator-(vec3 a) {
		return new vec3(
			-a.x,	
			-a.y,
			-a.z );
	}	

	public static vec3 operator*(vec3 a, vec3 b) {
		return new vec3(
			a.x * b.x,	
			a.y * b.y,
			a.z * b.z );
	}  	

	public static vec3 operator*(float a, vec3 b) {
		return new vec3(
			a * b.x,	
			a * b.y,
			a * b.z );
	}  	

	public static vec3 operator*(vec3 a, float b) => b * a;

	public static vec3 operator/(vec3 a, vec3 b) {
		return new vec3(
			a.x / b.x,	
			a.y / b.y,
			a.z / b.z );
	} 	  

	public static vec3 operator/(float a, vec3 b) {
		return new vec3(
			a / b.x,	
			a / b.y,
			a / b.z );
	}  

	public static vec3 operator/(vec3 a, float b) {
		return new vec3(
			a.x / b,	
			a.y / b,
			a.z / b );
	} 		 

	public static vec3 operator%(vec3 a, vec3 b) {
		return new vec3(
			a.x % b.x,	
			a.y % b.y,
			a.z % b.z );
	} 	

}
}
