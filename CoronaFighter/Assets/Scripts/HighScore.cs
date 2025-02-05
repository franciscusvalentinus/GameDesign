using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//static class membuat class tidak perlu dibuat instancenya
// perhatikan bahwa dia bukan gameobject/turunan Monobehaviour
public static class HighScore
{
    //semua member harus static juga!!
    public static int global_score = 0;
}
