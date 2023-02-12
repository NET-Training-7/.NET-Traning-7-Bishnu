namespace Basics;
class Array // Pascal
{
    void LearnArrays()  // Pascal casing
    {
        // Arrays
        // int personScore = 89;   // Camel casing
        // int score2 = 45;
        // int score3 = 90;
        // int score4 = 56;
        // int score5 = 82;

        // One-dimensional array
        int[] scores = new int[5];
        scores[0] = 89;
        scores[1] = 45;
        scores[2] = 90;
        scores[3] = 56;
        scores[4] = 82;

        int[] pScores = { 89, 45, 90, 56, 82, 78 };
        string[] names = { "Ram", "Shyam", "Hari", "Gita" };

        // multi-dimensional
        short[,] mat1 = new short[2, 3];

        // 4    6   8
        // 9    8   3

        // Jagged array
        float[][] table = new float[5][];
        table[0] = new float[3];
        table[1] = new float[5];
    }
}
