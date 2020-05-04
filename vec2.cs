namespace Quickmaths {

public partial struct vec2 {

    public static readonly vec2 X = new vec2(1,0);
    public static readonly vec2 Y = new vec2(0,1);

	public float x;
	public float y;

	//////////////////////////////////////////////////////////////////////////
	// Constructors	 
	////////////////////////////////////////////////////////////////////////// 

	public vec2(float x, float y) {
		this.x = x;	  
		this.y = y;
	}

	public vec2(float x) {
		this.x = x;	  
		this.y = x; 
	}

	//////////////////////////////////////////////////////////////////////////
	// Methods	 
	//////////////////////////////////////////////////////////////////////////

    public float dot(vec2 vec) {
        return this.x*vec.x + this.y+vec.y;
    }

    public float cross(vec2 vec) {
		return this.x*vec.y + this.y*vec.x;
    }


	public float magnitude() {
		return Math.sqrt(magnitude2());
	}

	public float magnitude2() {
		return x*x + y*y;
	}

	public vec2 normal() {
        float mag = magnitude();

        if (mag == 0)
            return this;

		return this / magnitude();
	}

    public vec2 trim(float length) {
        return this.normal() * length;
    }

    public vec2 clampLength(float min, float max) {
		return this.normal() * Math.clamp(this.magnitude(), min, max);
    }


    public vec2 abs() {
		return new vec2(
		   Math.abs(this.x),
		   Math.abs(this.y) );
    }

    public vec2 floor() {
		return new vec2(
		   Math.floor(this.x),
		   Math.floor(this.y) );
    }

    public vec2 ceil() {
		return new vec2(
		   Math.ceil(this.x),
		   Math.ceil(this.y) );
    }

    public vec2 clamp(vec2 min, vec2 max) {
		return new vec2(
		   Math.clamp(this.x, min.x, max.x),
		   Math.clamp(this.y, min.y, max.y) );
    }
  
	//////////////////////////////////////////////////////////////////////////
	// Overrides	 
	//////////////////////////////////////////////////////////////////////////

	override public string ToString() {
        return "(" + this.x + "," + this.y + ")";
	}

	override public bool Equals(object o) {
        if (!(o is vec2))
            return false;

		return this == (vec2) o;
	}
    
    override public int GetHashCode() {
        return this.ToString().GetHashCode();
	}

	//////////////////////////////////////////////////////////////////////////
	// Casting	 
	//////////////////////////////////////////////////////////////////////////

    public static explicit operator vec2(float[] v) {
        return new vec2( v[0], v[1] );
    }

    public static explicit operator float[](vec2 v) {
        return new float[] { v.x, v.y };
    }

	//////////////////////////////////////////////////////////////////////////
	// Operators	 
	//////////////////////////////////////////////////////////////////////////

	public static bool operator==(vec2 a, vec2 b) {
		return a.x == b.x
			&& a.y == b.y;
	}

	public static bool operator!=(vec2 a, vec2 b) {
		return a.x != b.x
			|| a.y != b.y;
	}

	public static vec2 operator+(vec2 a, vec2 b) {
		return new vec2(
			a.x + b.x,	
			a.y + b.y );
	}

	public static vec2 operator-(vec2 a, vec2 b) {
		return new vec2(
			a.x - b.x,	
			a.y - b.y );
	}

	public static vec2 operator-(vec2 a) {
		return new vec2(
			-a.x,	
			-a.y );
	}	

	public static vec2 operator*(vec2 a, vec2 b) {
		return new vec2(
			a.x * b.x,	
			a.y * b.y );
	}  	

	public static vec2 operator*(float a, vec2 b) {
		return new vec2(
			a * b.x,	
			a * b.y );
	}  	

	public static vec2 operator*(vec2 a, float b) {
		return new vec2(
			a.x * b,	
			a.y * b );
	}   

	public static vec2 operator/(vec2 a, vec2 b) {
		return new vec2(
			a.x / b.x,	
			a.y / b.y );
	} 	  

	public static vec2 operator/(float a, vec2 b) {
		return new vec2(
			a / b.x,	
			a / b.y );
	}  

	public static vec2 operator/(vec2 a, float b) {
		return new vec2(
			a.x / b,	
			a.y / b );
	} 		 

	public static vec2 operator%(vec2 a, vec2 b) {
		return new vec2(
			a.x % b.x,	
			a.y % b.y );
	}

}
}
