import org.testng.Assert.assertEquals
import org.testng.annotations.Test
import Exercises.`8Kyu`.Reverse

public class ReverseTests {
    @Test
    public fun sample() {
        var str = Reverse.reverseWords("I like eating");
        assertEquals("eating like I",Reverse.reverseWords("I like eating") )
        assertEquals("flying like I", Reverse.reverseWords("I like flying"))
        assertEquals("nice is world The", Reverse.reverseWords("The world is nice"))
        assertEquals("it!! Split Just", Reverse.reverseWords("Just Split it!!"))
        assertEquals("!!! !! !", Reverse.reverseWords("! !! !!!"))
        assertEquals("7777 777 77 7", Reverse.reverseWords("7 77 777 7777"))
        assertEquals("D : Jpazzy", Reverse.reverseWords("Jpazzy : D"))
    }
}