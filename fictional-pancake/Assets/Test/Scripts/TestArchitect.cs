using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TESTING
{
    public class TestArchitect : MonoBehaviour
    {
        DialogSystem ds;
        TextArchitect architect;

        public TextArchitect.BuildMethod bm = TextArchitect.BuildMethod.instant;

        string[] lines = new string[5] {
            "This line is cool.",
            "I was wondering",
            "Cock in mcnuggets",
            "elephant in the room",
            "anime"
        };

        // Start is called before the first frame update
        void Start()
        {
            ds = DialogSystem.instance;
            architect = new TextArchitect(ds.dialogContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.fade;
        }

        // Update is called once per frame
        void Update()
        {
            if (bm != architect.buildMethod)
            {
                architect.buildMethod = bm;
                architect.Stop();
            }

            if (Input.GetKeyDown(KeyCode.S))
                architect.Stop();
            string longLie = "abra cadabrabra adbadad rababbaabbaba dara ca mam zebit so stept bai hai mai repede bai ce de lent esti tucma ma zaibesti pidrila hai bai mai repde si maine vei schimba viitorul tau propriu pentru ca esti un geniu si tu totul poti.";
            if (Input.GetKeyDown(KeyCode.Space))
                if (architect.isBuilding)
                {
                    if (!architect.hurryUp)
                        architect.hurryUp = true;
                    else
                        architect.ForceComplete();
                }
                else
                    architect.Build(longLie);
            //  architect.Build(lines[Random.Range(0, lines.Length)]);
            else if (Input.GetKeyDown(KeyCode.A))
            {
                architect.Append(longLie);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }
        }
    }
}
