using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET;
using GMap.NET.WindowsPresentation;
using GMap.NET.MapProviders;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace EtjenInt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        

        AgentsManger agentManger = new AgentsManger();

        GMapMarker agentSearchMarker = null;

        Dictionary<string, List<GMapMarker>> stateMarkers = new Dictionary<string, List<GMapMarker>>();



        public MainWindow()
        {
            InitializeComponent();
            agentManger.LoadAgentList();

        }

        
        


        private void mapView_Loaded(object sender, EventArgs e)
        {
            mapView.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            mapView.ShowCenter = false;
            mapView.Zoom = 4;
            mapView.Position = new GMap.NET.PointLatLng(51.1855449268883, 7.987259873315675);
        }

        private void addStateMarkers(List<GMapMarker> markerList)
        {
            foreach(GMapMarker marker in markerList)
            {
                mapView.Markers.Add(marker);
            }
        }
        private void removeStateMarkers(List<GMapMarker> markerList, String stateID)
        {
            
            foreach (GMapMarker marker in markerList)
            {
                mapView.Markers.Remove(marker);
            }
            stateMarkers.Remove(stateID);
        }

        private void mangeStateMarkers(String stateID, List<GMapMarker> markerList)
        {
            if (!stateMarkers.ContainsKey(stateID))
            {
                stateMarkers.Add(stateID, markerList);
            }

        }

        private void agent_Search(object sender, EventArgs e)
        {
            if (agentSearchMarker != null)
            {
                mapView.Markers.Remove(agentSearchMarker);
            }

            string agentFullName = agent_Text.Text;
            Agents agent = new Agents();

            if (agentFullName.Contains(" "))
            {
                agent = agentManger.findAgent(agentFullName);
            }


            if (agent.seq != 0)
            {
                mapView.Position = new GMap.NET.PointLatLng(agent.latitude, agent.longitude);
                mapView.Zoom = 10;
                agentSearchMarker = agentManger.makeSearchMarker(agent);
                mapView.Markers.Add(agentSearchMarker);
            }
        }




        //All checkboxes


        private void checkbox_AL(object sender, EventArgs e)
        {
            string stateID = "AL";
            if (AL.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (AL.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID],stateID);
            }
        }

        private void checkbox_AK(object sender, EventArgs e)
        {
            string stateID = "AK";
            if (AK.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (AK.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_AZ(object sender, EventArgs e)
        {
            string stateID = "AZ";
            if (AZ.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (AZ.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_AR(object sender, EventArgs e)
        {
            string stateID = "AR";
            if (AR.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (AR.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_CA(object sender, EventArgs e)
        {
            string stateID = "CA";
            if (CA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (CA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_CO(object sender, EventArgs e)
        {
            string stateID = "CO";
            if (CO.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (CO.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_CT(object sender, EventArgs e)
        {
            string stateID = "CT";
            if (CT.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (CT.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_DE(object sender, EventArgs e)
        {
            string stateID = "DE";
            if (DE.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (DE.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_FL(object sender, EventArgs e)
        {
            string stateID = "FL";
            if (FL.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (FL.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_GA(object sender, EventArgs e)
        {
            string stateID = "GA";
            if (GA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (GA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_HI(object sender, EventArgs e)
        {
            string stateID = "HI";
            if (HI.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (HI.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_ID(object sender, EventArgs e)
        {
            string stateID = "ID";
            if (ID.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (ID.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_IL(object sender, EventArgs e)
        {
            string stateID = "IL";
            if (IL.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (IL.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_IN(object sender, EventArgs e)
        {
            string stateID = "IN";
            if (IN.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (IN.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_IA(object sender, EventArgs e)
        {
            string stateID = "IA";
            if (IA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (IA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_KS(object sender, EventArgs e)
        {
            string stateID = "KS";
            if (KS.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (KS.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_KY(object sender, EventArgs e)
        {
            string stateID = "KY";
            if (KY.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (KY.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_LA(object sender, EventArgs e)
        {
            string stateID = "LA";
            if (LA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (LA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_ME(object sender, EventArgs e)
        {
            string stateID = "ME";
            if (ME.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (ME.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MD(object sender, EventArgs e)
        {
            string stateID = "MD";
            if (MD.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MD.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MA(object sender, EventArgs e)
        {
            string stateID = "MA";
            if (MA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MI(object sender, EventArgs e)
        {
            string stateID = "MI";
            if (MI.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MI.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MN(object sender, EventArgs e)
        {
            string stateID = "MN";
            if (MN.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MN.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MS(object sender, EventArgs e)
        {
            string stateID = "MS";
            if (MS.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MS.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MO(object sender, EventArgs e)
        {
            string stateID = "MO";
            if (MO.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MO.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_MT(object sender, EventArgs e)
        {
            string stateID = "MT";
            if (MT.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (MT.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NE(object sender, EventArgs e)
        {
            string stateID = "NE";
            if (NE.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NE.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NV(object sender, EventArgs e)
        {
            string stateID = "NV";
            if (NV.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NV.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NH(object sender, EventArgs e)
        {
            string stateID = "NH";
            if (NH.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NH.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NJ(object sender, EventArgs e)
        {
            string stateID = "NJ";
            if (NJ.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NJ.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NM(object sender, EventArgs e)
        {
            string stateID = "NM";
            if (NM.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NM.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NY(object sender, EventArgs e)
        {
            string stateID = "NY";
            if (NY.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NY.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_NC(object sender, EventArgs e)
        {
            string stateID = "NC";
            if (NC.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (NC.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_ND(object sender, EventArgs e)
        {
            string stateID = "ND";
            if (ND.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (ND.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_OH(object sender, EventArgs e)
        {
            string stateID = "OH";
            if (OH.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (OH.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_OK(object sender, EventArgs e)
        {
            string stateID = "OK";
            if (OK.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (OK.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_OR(object sender, EventArgs e)
        {
            string stateID = "OR";
            if (OR.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (OR.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_PA(object sender, EventArgs e)
        {
            string stateID = "PA";
            if (PA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (PA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_RI(object sender, EventArgs e)
        {
            string stateID = "RI";
            if (RI.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (RI.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_SC(object sender, EventArgs e)
        {
            string stateID = "SC";
            if (SC.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (SC.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_SD(object sender, EventArgs e)
        {
            string stateID = "SD";
            if (SD.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (SD.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_TN(object sender, EventArgs e)
        {
            string stateID = "TN";
            if (TN.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (TN.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_TX(object sender, EventArgs e)
        {
            string stateID = "TX";
            if (TX.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (TX.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_UT(object sender, EventArgs e)
        {
            string stateID = "UT";
            if (UT.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (UT.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_VT(object sender, EventArgs e)
        {
            string stateID = "VT";
            if (VT.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (VT.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_VA(object sender, EventArgs e)
        {
            string stateID = "VA";
            if (VA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (VA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_WA(object sender, EventArgs e)
        {
            string stateID = "WA";
            if (WA.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (WA.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_WV(object sender, EventArgs e)
        {
            string stateID = "WV";
            if (WV.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (WV.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_WI(object sender, EventArgs e)
        {
            string stateID = "WI";
            if (WI.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (WI.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }
        private void checkbox_WY(object sender, EventArgs e)
        {
            string stateID = "WY";
            if (WY.IsChecked == true)
            {

                mangeStateMarkers(stateID, agentManger.makeStateMarkers(agentManger.queryList(stateID)));
                addStateMarkers(stateMarkers[stateID]);
            }
            if (WY.IsChecked == false)
            {
                removeStateMarkers(stateMarkers[stateID], stateID);
            }
        }


    }
}
