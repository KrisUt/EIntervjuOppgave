using GMap.NET;
using GMap.NET.WindowsPresentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Documents;

namespace EtjenInt
{
    public class AgentsManger
    {
        List<Agents> agents = new List<Agents>();

        public List<String> loadStateCodes()
        {
            List<String> tempCodes = new List<String>();
            foreach(Agents agent in agents)
            {
                if (!tempCodes.Contains(agent.state))
                {
                    tempCodes.Add(agent.state);
                    
                }
            }
            tempCodes.Sort();
            return tempCodes;
        }

        public void LoadAgentList()
        {
            agents = SqliteDbAccess.LoadAgents();
        }
        public List<Agents> queryList(string s)
        {
            List<Agents> agent = new List<Agents>();
            agent = agents.FindAll(x => x.state == s);
            return agent;
        }

        public Agents findAgent(string agentFullName)
        {
            var fullName = agentFullName.Split(' ');
            string firstName = fullName[0];
            string lastName = fullName[1];
            

            List<Agents> foundAgents = new List<Agents>();
            Agents finalAgent = new Agents();

            foundAgents = agents.FindAll(x => x.firstName == firstName);
            
            foreach(Agents agent in foundAgents)
            {
                
                if(agent.lastName == lastName)
                {
                    finalAgent = agent;
                }
            }
            
            return finalAgent;
        }

        

        public List<GMapMarker> makeStateMarkers(List<Agents> agentList)
        {
            List<GMapMarker> stateMarkers = new List<GMapMarker>();
            foreach (Agents agent in agentList)
            {
                PointLatLng point = new PointLatLng(agent.latitude, agent.longitude);
                var marker = new GMapMarker(point);
                marker.Shape = new Ellipse
                {
                    Width = 5,
                    Height = 5,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1.5
                };
                marker.Tag = agent.firstName + agent.lastName;
                stateMarkers.Add(marker);
            }
            return stateMarkers;
        }
        public GMapMarker makeSearchMarker(Agents agent)
        {
            PointLatLng point = new PointLatLng(agent.latitude, agent.longitude);
            var marker = new GMapMarker(point);
            marker.Shape = new Ellipse
            {
                Width = 5,
                Height = 5,
                Stroke = Brushes.Black,
                StrokeThickness = 1.5
            };
            return marker;
        }

    }
}
