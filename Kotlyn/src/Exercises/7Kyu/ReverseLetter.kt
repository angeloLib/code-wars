package Exercises.`7Kyu`

/*
Given a string str, reverse it and omit all non-alphabetic characters.
 */
fun reverseLetter(str: String): String {
    return str.filter { it.isLetter() }.reversed()
}