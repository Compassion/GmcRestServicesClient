namespace GmcRestServicesClient.Models
{
    public class ChildBiography
    {
        /// <summary>
        /// Child Key
        /// </summary>
        public string ChildBasic { get; set; }

        /// <summary>
        /// <para>Section containing Christian activites the child participates in.</para>
        /// <para>List of activity values that the child can be engaged in: </para>
        /// <list type="bullet">
        ///   <item><description>Sunday School/Church</description></item> 
        ///   <item><description>Bible Class</description></item>
        ///   <item><description>Camp</description></item>
        ///   <item><description>Youth Group</description></item>
        ///   <item><description>Vacation Bible School Choir</description></item>
        /// </list>
        /// <para>There is also free text for other Christian activities.</para>
        /// </summary>
        public string ChristianActivities { get; set; }

        /// <summary>
        /// <para>Section containing family duties the child participates in.</para>
        /// <para>List of duty values that the child can participate in:</para> 
        /// <list type="bullet">
        ///   <item><description>Washing Clothes</description></item>
        ///   <item><description>Making Beds</description></item>
        ///   <item><description>Cleaning</description></item>
        ///   <item><description>Carries Water</description></item>
        ///   <item><description>Kitchen Help</description></item>
        ///   <item><description>Animal Care</description></item>
        ///   <item><description>Running Errands</description></item>
        ///   <item><description>Child Care</description></item>
        ///   <item><description>Buying/Selling in Market</description></item>
        ///   <item><description>Gathers Firewood</description></item>
        ///   <item><description>Gardening/Farming</description></item>
        ///   <item><description>Sewing</description></item>
        ///   <item><description>Teaching Others</description></item>
        /// </list>
        /// <para>There is also free text for other family duties.</para>

        /// </summary>
        public string FamilyDuties { get; set; }

        /// <summary>
        /// <para>Section containing hobbies and sports the child participates in.</para>
        /// <para>List of hobbies or sports values that a child can participate in:</para>
        /// <list type="bullet">
        ///   <item><description>Art/Drawing</description></item>
        ///   <item><description>Baseball</description></item>
        ///   <item><description>Basketball</description></item>
        ///   <item><description>Bicycling</description></item>
        ///   <item><description>Cars</description></item>
        ///   <item><description>Dolls</description></item>
        ///   <item><description>Group Games</description></item>
        ///   <item><description>Hide and Seek</description></item>
        ///   <item><description>Jacks</description></item>
        ///   <item><description>Jump Rope</description></item>
        ///   <item><description>Listening to Music</description></item>
        ///   <item><description>Marbles</description></item>
        ///   <item><description>Musical Instrument</description></item>
        ///   <item><description>Other Ball Games</description></item>
        ///   <item><description>Other Sports Or Hobbies</description></item>
        ///   <item><description>Ping Pong</description></item>
        ///   <item><description>Play House</description></item>
        ///   <item><description>Reading</description></item>
        ///   <item><description>Rolling a hoop</description></item>
        ///   <item><description>Running</description></item>
        ///   <item><description>Singing</description></item>
        ///   <item><description>Soccer/Footbal</description></item>
        ///   <item><description>Story Telling</description></item>
        ///   <item><description>Swimming</description></item>
        ///   <item><description>Volleyball</description></item>
        ///   <item><description>Walking</description></item>
        ///   <item><description>MusicalInstrument: followed by free text</description></item>
        /// </list>
        /// </summary>
        public string HobbiesAndSports { get; set; }

        /// <summary>
        /// <para>Section containing health condtions of the child.</para>
        /// <para>List of health condition values:</para>
        /// <list type="bullet">
        ///   <item><description>Epilepsy</description></item>
        ///   <item><description>Asthma</description></item>
        ///   <item><description>Polio</description></item>
        ///   <item><description>Developmentally Disabled</description></item>
        ///   <item><description>Speech: (values: Defective, Mute)</description></item>
        ///   <item><description>Hearing Left Ear: (values: Defective, Deaf)</description></item>
        ///   <item><description>Hearing Right Ear: (values: Defective, Deaf)</description></item>
        ///   <item><description>Sight Left Eye: (values: Defective, Blind)</description></item>
        ///   <item><description>Sight Right Eye: (values: Defective, Blind)</description></item>
        ///   <item><description>Regular Medical Treatmnt</description></item>
        ///   <item><description>Regular Medication</description></item>
        ///   <item><description>None</description></item>
        /// </list>
        /// <para>The following can have a value of (Crippled/Birth, Crippled/Disease, Crippled/Injury):</para>
        /// <list type="bullet">
        ///   <item><description>Left Leg due to: </description></item>
        ///   <item><description>Right Leg due to: </description></item>
        ///   <item><description>Left Foot due to: </description></item>
        ///   <item><description>Right Foot due to:</description></item>
        ///   <item><description>Left Arm due to: </description></item>
        ///   <item><description>Right Arm due to: </description></item>
        ///   <item><description>Left Hand due to: </description></item>
        ///   <item><description>Right Hand due to: </description></item>
        ///   <item><description>Spine due to: </description></item>
        /// </list>
        /// <para>There is also free text for diseases: example: Kidney diseases or Congenital Heart Diseases etc.</para>
        /// </summary>
        public string Health { get; set; }

        /// <summary>
        /// <para>Section containing child schooling information</para>
        /// <para>Values can include:</para>
        /// <list type="bullet">
        ///   <item><description>Child Attending School</description></item>
        ///   <item><description>Reason not attending school because: (free text)</description></item>
        /// </list>
        /// <list type="bullet">
        ///   <item><description>School Performance: values: Below Average, Average, Above Average)</description></item>
        ///   <item><description>Child's best subject: (free text)</description></item>
        ///   <item><description>Completion Date: yyyymmdd</description></item>
        /// </list>
        /// <list type="bullet">
        ///   <item><description>US School Equivalent: nn </description></item>
        ///   <item><description>Pre-School: nn</description></item>
        ///   <item><description>Kindergarten: nn</description></item>
        ///   <item><description>Primary School: nn</description></item>
        ///   <item><description>Middle School: nn</description></item>
        ///   <item><description>High School: nn</description></item>
        /// </list>
        /// <list type="bullet">
        ///   <item><description>Vocational School Level: nn</description></item>
        ///   <item><description>Vocatl: Course of Study: (free text)</description></item>
        ///   <item><description>Apprenticeship Level: nn</description></item>
        ///   <item><description>Appren: Course of Study (free text)</description></item>
        ///   <item><description>College/University Level: nn</description></item>
        ///   <item><description>College: Course of Study: (free text)</description></item>
        ///   <item><description>Other School Level: nn</description></item>
        ///   <item><description>Other: Course of Study: (free text)</description></item>
        /// </list>
        /// <list type="bullet">
        ///   <item><description>Future High School Date: yyyymmdd</description></item>
        ///   <item><description>Future HS Course Study: (free text)</description></item>
        ///   <item><description>Future Vocational Date: yyyymmdd</description></item>
        ///   <item><description>Future Voctl Course Study: (free text)</description></item>
        ///   <item><description>Future Bible School date: yyyymmdd</description></item>
        ///   <item><description>Future BS Course Study: (free text)</description></item>
        ///   <item><description>Future University Date: yyyymmdd</description></item>
        ///   <item><description>Future Univ. Course Study: (free text)</description></item>
        ///   <item><description>Future Other School Date: yyyymmdd</description></item>
        ///   <item><description>Future Other School Desc: (free text)</description></item>
        ///   <item><description>Future Other Course Study: (free text)</description></item>
        /// </list>
        /// </summary>
        public string Schooling { get; set; }

        /// <summary>
        /// <para>Section describing the child's guardians.</para>
        /// <para>List of child guardian values:</para>
        /// <list type="bullet">
        ///   <item><description>Mother</description></item>
        ///   <item><description>Father</description></item>
        ///   <item><description>Uncle</description></item>
        ///   <item><description>Aunt</description></item>
        ///   <item><description>Grandfather</description></item>
        ///   <item><description>Grandmother</description></item>
        ///   <item><description>Brother</description></item>
        ///   <item><description>Sister</description></item>
        ///   <item><description>Stepfather</description></item>
        ///   <item><description>Stepmother</description></item>
        ///   <item><description>Godfather</description></item>
        ///   <item><description>Godmother</description></item>
        ///   <item><description>Friends</description></item>
        ///   <item><description>Institutional Worker</description></item>
        ///   <item><description>Foster Parents</description></item>
        ///   <item><description>Other Relatives</description></item>
        /// </list>
        /// </summary>
        public string Guardians { get; set; }

        /// <summary>
        /// <para>Section describing the child's natural parents.</para>
        /// <para>Values can incluide:</para>
        /// <list type="bullet">
        ///   <item><description>Natural Parents together</description></item>
        ///   <item><description>Now Married</description></item>
        ///   <item><description>Were married, now separated by death</description></item>
        ///   <item><description>Now divorced or permanently separated</description></item>
        ///   <item><description>Were never married</description></item>
        ///   <item><description>Father alive</description></item>
        ///   <item><description>Father living with child</description></item>
        /// </list>
        /// </summary>
        public string NaturalParents { get; set; }

        /// <summary>
        /// <para>Section describing the parents' employment.</para>
        /// <para>Values can include:</para>
        /// <list type="bullet">
        ///   <item><description>Father/MG employed</description></item>
        ///   <item><description>Father/MG at times employ</description></item>
        ///   <item><description>Father/MG unemployed</description></item>
        ///   <item><description>No Father nor M.Guardian</description></item>
        ///   <item><description>Father/MG is a Farmer</description></item>
        ///   <item><description>Father/MG sells in market</description></item>
        ///   <item><description>Father/MG church worker</description></item>
        ///   <item><description>Father/MG project worker</description></item>
        ///   <item><description>Father/MG is teacher</description></item>
        ///   <item><description>Father/MG is a laborer</description></item>
        ///   <item><description>Father/MG other employmnt (free text)  [yes, employmnt is spelled this way in Compass and the DVL]</description></item>
        ///   <item><description>Mother/FG employed</description></item>
        /// </list>
        /// </summary>
        public string Employment { get; set; }

        /// <summary>
        /// Number Of Children Living At Home = n
        /// </summary>
        public string FamilySize { get; set; }
    }
}