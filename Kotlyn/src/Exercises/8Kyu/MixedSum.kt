package Exercises.`8Kyu`

public class MixedSum {

    /*
    * Assume input will be only of Int or String type
    *
    *
    * Exercise:
    * Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.
      Return your answer as a number.
     * */
    public fun sum(mixed: List<Any>): Int {
        var sum: Int = 0
        mixed.forEach { item ->
            sum += if(item is String) {
                item.toInt()
            } else{
                item as Int;
            }
        }
        return sum;
    }
}