using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_1 : MonoBehaviour
{
    //Name of the course
    public string CourseName;
    //Number of modules in course: Minimum 2, Maximum 15
    public int ModuleNumber;
    //Number of reading materials: Minimum 3, Maximum 30
    public int ReadingMaterials;
    //number of Quizzes: Minimum 2, Maximum 15
    public int QuizNumber;
    //Number of Assignments: Minimim 3, Maximum 30
    public int AssignmentNumber;
    //Has the instructor previously taught this course?
    public bool PreviosulyTaught;

    private double ChallengeScore;

    private double TempScore = 0;


    void Start()
    {
        TempScore = ModuleNumber + ReadingMaterials + QuizNumber + AssignmentNumber;
        if(PreviosulyTaught == false)
                TempScore += 10;
        ChallengeScore = TempScore / 10;
        Debug.Log(TempScore);
        Debug.Log("The challenge score for " + CourseName + " is " + ChallengeScore);
    }
}