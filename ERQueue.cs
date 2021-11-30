using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalQueue_Partee
{
    public class ERQueue
    {
        public List<Node> PatientList = new List<Node>();
        public Patient Patient { get; set; }
        public Node head;
        public Patient getHead() { return head.Data; }
        public int AddPatient(Patient patient)
        {
            Node person = new Node(patient);           
            if (head == null)
            {
                head = person;

                head.Data = patient;
                head.Next = null;
                PatientList.Add(head);
                return PatientList.Count;
            }

            Node current = head;
            while (current != null)
            {
                if (current.Next == null && person.Data.Priority >= head.Data.Priority)
                {
                    current.Next = person;
                    current.Next.Data = patient;
                    PatientList.Add(person);
                    break;
                }
                else
                {
                    if (person.Data.Priority <= head.Data.Priority && head.Data.Priority != 1)
                    {
                        person.Data = patient;
                        person.Next = head;
                        head = person;
                        PatientList.Add(person);
                        return PatientList.Count;
                    }
                    if (current.Next.Data.Priority > person.Data.Priority) 
                    {
                        Node temp = current.Next;
                        current.Next = person;
                        current.Next.Next = temp;
                        PatientList.Add(person);
                        return PatientList.Count;
                    }
                    current = current.Next;
                }               
            }           
            return PatientList.Count;
        }
        public Patient RemoveFirst()
        {
            Node current = head;

            head = head.Next;
            return current.Data;
        }
        public Patient RemovePatient(Patient patient)
        {
            Node node = head;
            Node current = head;
            Node previous = null;
            while (node != null)
            {
                current = node;
                if (node.Data == patient)
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;
                    }
                    else
                    {
                        head = head.Next;
                    }
                    break;
                }
                previous = current;
                node = node.Next;
            }
            return patient;
        }
        public List<Node> ListPatients()
        {
            Node current = head;
            while(current != null)
            {
                Console.WriteLine(current.Data.ToString());
                if (current.Next != null)
                {
                    current = current.Next;
                } else
                { break; }
            }
            return PatientList;
        }
        
    }
}
