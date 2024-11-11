import Exercises.`7Kyu`.smallEnough
import org.testng.Assert.assertEquals
import org.testng.annotations.Test

class smallEnoughTests {
    @Test
    fun `Basic Tests`() {
        assertEquals(true, smallEnough(intArrayOf(66, 101), 200))
        assertEquals(false, smallEnough(intArrayOf(78, 117, 110, 99, 104, 117, 107, 115), 100))
        assertEquals(true, smallEnough(intArrayOf(101, 45, 75, 105, 99, 107), 107))
        assertEquals(true, smallEnough(intArrayOf(80, 117, 115, 104, 45, 85, 112, 115), 120))
    }}