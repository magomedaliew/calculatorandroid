using System;
using Android.App;
using Android.OS;
using Android.Text;
using Android.Widget;
using Android.Content;
using Android.Runtime;
using Android.Graphics;
using Android.Text.Style;
//using Android.Support.V7.App;
using Android.Graphics.Fonts;
using Android.Views.InputMethods;
using Android.Views;
using Android.Provider;
namespace calculatorandroid
{
  // بِسْمِ اللَّهِ الرَّحْمَـٰنِ الرَّحِيمِ
  [Activity(Label = "@string/A000", MainLauncher = true)] // Theme = "@style/AppTheme",
  public class MainActivity : Activity
  {
    //  * AAAA * AAAA * AAAA * AAAA *
    #region AAAA
    #region A-A_
    private TextView A102 = null!;
    private EditText A103 = null!;
    private GridLayout AA00 = null!;
    private GridLayout A000 = null!;
    private Button A201 = null!, A202 = null!;
    private Button A203 = null!, A204 = null!;
    private Button A205 = null!, A206 = null!;
    private Button A301 = null!, A302 = null!;
    private Button A303 = null!, A304 = null!;
    private Button A401 = null!, A402 = null!;
    private Button A403 = null!, A404 = null!;
    private Button A405 = null!, A406 = null!;
    private Button A407 = null!, A408 = null!;
    private Button A411 = null!, A412 = null!;
    private Button A413 = null!, A414 = null!;
    private Button A415 = null!, A416 = null!;
    private Button A417 = null!, A418 = null!;
    private Button A421 = null!, A422 = null!;
    private Button A423 = null!, A424 = null!;
    private Button A425 = null!, A426 = null!;
    private Button A427 = null!, A428 = null!;
    private Button A431 = null!, A432 = null!;
    private Button A433 = null!, A434 = null!;
    private Button A435 = null!, A436 = null!;
    private Button A437 = null!, A438 = null!;
    private Button A441 = null!, A442 = null!;
    private Button A443 = null!, A444 = null!;
    private Button A445 = null!, A446 = null!;
    private Button A447 = null!, A448 = null!;
    private GridLayout A100 = null!, A200 = null!;
    private GridLayout A300 = null!, A400 = null!;
    private AutoCompleteTextView A101 = null!;
    #endregion
    #region A-A1
    // Strings
    private string CAA = "";
    private string CAB = "";
    private string CAC = "";
    private string CAD = "";
    private string CAF = "";
    private string CAI = "";
    private string CAJ = "";
    private string CAK = "";
    private string CAL = "";
    private string CAM = "";
    private string CAN = "";
    private string CBA = "";
    private string CBB = "";
    private string CBC = "";
    private string CBD = "";
    private string CBE = "";
    private string CBF = "";
    // Booleans
    private bool DAA;
    private bool DAC;
    // Integers
    private int EAA;
    private int EAC;
    private int EAD;
    // Stringarrays
    private string[] FAA = [];
    private string[] FAB = [];
    private string[] FAC = [];
    private string[] FCA = [];
    // Buttonarrays
    private Button[] GAA = [];
    // Delegates
    private delegate void HAA();
    // Bytelists
    private JavaList<byte> IAA = [];
    private JavaList<byte> IAB = [];
    // Colorlists
    private JavaList<Color> JAA = [];
    private JavaList<Color> JAB = [];
    private JavaList<Color> JAC = [];
    // Stringlists
    private JavaList<string> KAA = [];
    private JavaList<string> KAB = [];
    private JavaList<string> KAC = [];
    private JavaList<string> KAD = [];
    private JavaList<string> KAE = [];
    private JavaList<string> KAF = [];
    private JavaList<string> KAH = [];
    private JavaList<string> KAI = [];
    private JavaList<string> KAJ = [];
    private JavaList<string> KAK = [];
    private JavaList<string> KAL = [];
    // Booleanlists
    private JavaList<bool> LAA = [];
    // Integerlists
    private JavaList<int> MAA = [];
    private JavaList<int> MAB = [];
    private JavaList<int> MAC = [];
    private JavaList<int> MAD = [];
    private JavaList<int> MAE = [];
    private JavaList<int> MAF = [];
    private JavaList<int> MAG = [];
    private JavaList<int> MAH = [];
    private JavaList<int> MAI = [];
    private JavaList<int> MAJ = [];
    private JavaList<int> MAM = [];
    private JavaList<int> MAO = [];
    private JavaList<int> MAP = [];
    private JavaList<int> MAQ = [];
    private JavaList<int> MAR = [];
    #endregion
    #region A-A2
    // Parameter Variablen
    private byte A_;
    string[] B1 = [],
      EAA3 = [],
      IGA4 = [],
      W_FA = [];
    private byte B2; 
    private bool B3;
    private int B4, B5, B6, B7, B8, BAA;
    private JavaList<int> C1 = [];
    private JavaList<int> C2 = [];
    private JavaList<int> C3 = [];
    private JavaList<int> C4 = [];
    private JavaList<int> C5 = [];
    private JavaList<int> C6 = [];
    private JavaList<int> C7 = [];

    private SpannableString NAA = null!;
    private SpannableString NAB = null!;
    private SpannableString NBA = null!;
    private SpannableString NBB = null!;
    private SpannableString NBC = null!;
    private SpannableString NBD = null!;
    private SpannableString NBE = null!;
    private SpannableString NBF = null!;

    #endregion
    #region A-AA
    protected override void OnCreate(Bundle? savedInstanceState)
    {
      base.OnCreate(savedInstanceState);
      //Xamarin.Essentials.Platform.Init(this, savedInstanceState);
      // Set our view from the "main" layout resource
      SetContentView(Resource.Layout.activity_main);
      // ActionBar ausblenden, Statusleiste
      if (ActionBar != null)
      {
        ActionBar?.Hide();
      }
      
      #region
      A101 = FindViewById<AutoCompleteTextView>(Resource.Id.A101)!;
      A201 = FindViewById<Button>(Resource.Id.A201)!;
      A202 = FindViewById<Button>(Resource.Id.A202)!;
      A203 = FindViewById<Button>(Resource.Id.A203)!;
      A204 = FindViewById<Button>(Resource.Id.A204)!;
      A205 = FindViewById<Button>(Resource.Id.A205)!;
      A206 = FindViewById<Button>(Resource.Id.A206)!;
      A301 = FindViewById<Button>(Resource.Id.A301)!;
      A302 = FindViewById<Button>(Resource.Id.A302)!;
      A303 = FindViewById<Button>(Resource.Id.A303)!;
      A304 = FindViewById<Button>(Resource.Id.A304)!;
      A401 = FindViewById<Button>(Resource.Id.A401)!;
      A402 = FindViewById<Button>(Resource.Id.A402)!;
      A403 = FindViewById<Button>(Resource.Id.A403)!;
      A404 = FindViewById<Button>(Resource.Id.A404)!;
      A405 = FindViewById<Button>(Resource.Id.A405)!;
      A406 = FindViewById<Button>(Resource.Id.A406)!;
      A407 = FindViewById<Button>(Resource.Id.A407)!;
      A408 = FindViewById<Button>(Resource.Id.A408)!;
      A411 = FindViewById<Button>(Resource.Id.A411)!;
      A412 = FindViewById<Button>(Resource.Id.A412)!;
      A413 = FindViewById<Button>(Resource.Id.A413)!;
      A414 = FindViewById<Button>(Resource.Id.A414)!;
      A415 = FindViewById<Button>(Resource.Id.A415)!;
      A416 = FindViewById<Button>(Resource.Id.A416)!;
      A417 = FindViewById<Button>(Resource.Id.A417)!;
      A418 = FindViewById<Button>(Resource.Id.A418)!;
      A421 = FindViewById<Button>(Resource.Id.A421)!;
      A422 = FindViewById<Button>(Resource.Id.A422)!;
      A423 = FindViewById<Button>(Resource.Id.A423)!;
      A424 = FindViewById<Button>(Resource.Id.A424)!;
      A425 = FindViewById<Button>(Resource.Id.A425)!;
      A426 = FindViewById<Button>(Resource.Id.A426)!;
      A427 = FindViewById<Button>(Resource.Id.A427)!;
      A428 = FindViewById<Button>(Resource.Id.A428)!;
      A431 = FindViewById<Button>(Resource.Id.A431)!;
      A432 = FindViewById<Button>(Resource.Id.A432)!;
      A433 = FindViewById<Button>(Resource.Id.A433)!;
      A434 = FindViewById<Button>(Resource.Id.A434)!;
      A435 = FindViewById<Button>(Resource.Id.A435)!;
      A436 = FindViewById<Button>(Resource.Id.A436)!;
      A437 = FindViewById<Button>(Resource.Id.A437)!;
      A438 = FindViewById<Button>(Resource.Id.A438)!;
      A441 = FindViewById<Button>(Resource.Id.A441)!;
      A442 = FindViewById<Button>(Resource.Id.A442)!;
      A443 = FindViewById<Button>(Resource.Id.A443)!;
      A444 = FindViewById<Button>(Resource.Id.A444)!;
      A445 = FindViewById<Button>(Resource.Id.A445)!;
      A446 = FindViewById<Button>(Resource.Id.A446)!;
      A447 = FindViewById<Button>(Resource.Id.A447)!;
      A448 = FindViewById<Button>(Resource.Id.A448)!;
      A102 = FindViewById<TextView>(Resource.Id.A102)!;
      A103 = FindViewById<EditText>(Resource.Id.A103)!;
      AA00 = FindViewById<GridLayout>(Resource.Id.AA00)!;
      A000 = FindViewById<GridLayout>(Resource.Id.A000)!;
      A100 = FindViewById<GridLayout>(Resource.Id.A100)!;
      A200 = FindViewById<GridLayout>(Resource.Id.A200)!;
      A300 = FindViewById<GridLayout>(Resource.Id.A300)!;
      A400 = FindViewById<GridLayout>(Resource.Id.A400)!;
      #endregion
      #region
      A101.Text = "";
      A411.Text = "";
      A412.Text = "";
      A413.Text = "";
      A414.Text = "";
      A415.Text = "";
      A416.Text = "";
      A417.Text = "";
      A418.Text = "";
      A421.Text = "";
      A422.Text = "";
      A423.Text = "";
      A424.Text = "";
      A425.Text = "";
      A426.Text = "";
      A427.Text = "";
      A428.Text = "";
      A431.Text = "";
      A432.Text = "";
      A433.Text = "";
      A434.Text = "";
      A435.Text = "";
      A436.Text = "";
      A437.Text = "";
      A438.Text = "";
      A441.Text = "";
      A442.Text = "";
      A443.Text = "";
      A444.Text = "";
      A445.Text = "";
      A446.Text = "";
      A447.Text = "";
      A448.Text = "";
      #endregion
      #region
      A101.Click += (o, e) => ABAA();
      A103.Click += (o, e) => ABAB();
      A201.Click += (o, e) => ACAA();
      A202.Click += (o, e) => ACAB();
      A203.Click += (o, e) => ACAC();
      A204.Click += (o, e) => ACAD();
      A205.Click += (o, e) => ACAE();
      A206.Click += (o, e) => ACAF();
      A301.Click += (o, e) => ADAA();
      A302.Click += (o, e) => ADAB();
      A303.Click += (o, e) => ADAC();
      A304.Click += (o, e) => ADAD();
      A401.Click += (o, e) => AFAA();
      A402.Click += (o, e) => AFAB();
      A403.Click += (o, e) => AFAC();
      A404.Click += (o, e) => AFAD();
      A405.Click += (o, e) => AFAE();
      A406.Click += (o, e) => AFAF();
      A407.Click += (o, e) => AFAG();
      A408.Click += (o, e) => AFAH();
      A432.Click += (o, e) => AEAF();
      A301.LongClick += (o, e) => AEAH();
      A304.LongClick += (o, e) => AEAB();
      A101.FocusChange += (o, e) => ABAA();
      A103.FocusChange += (o, e) => ABAB();
      A101.TextChanged += (o, e) => ABAE();
      A103.TextChanged += (o, e) => ABAF();
      A411.Click += (o, e) => AEBA(A411.Text);
      A412.Click += (o, e) => AEBA(A412.Text);
      A413.Click += (o, e) => AEBA(A413.Text);
      A414.Click += (o, e) => AEBA(A414.Text);
      A415.Click += (o, e) => AEBA(A415.Text);
      A416.Click += (o, e) => AEBA(A416.Text);
      A417.Click += (o, e) => AEBA(A417.Text);
      A418.Click += (o, e) => AEBA(A418.Text);
      A421.Click += (o, e) => AEBA(A421.Text);
      A422.Click += (o, e) => AEBA(A422.Text);
      A423.Click += (o, e) => AEBA(A423.Text);
      A424.Click += (o, e) => AEBA(A424.Text);
      A425.Click += (o, e) => AEBA(A425.Text);
      A426.Click += (o, e) => AEBA(A426.Text);
      A427.Click += (o, e) => AEBA(A427.Text);
      A428.Click += (o, e) => AEBA(A428.Text);
      A431.Click += (o, e) => AEBA(A431.Text);
      A432.Click += (o, e) => AEBA(A432.Text);
      A433.Click += (o, e) => AEBA(A433.Text);
      A434.Click += (o, e) => AEBA(A434.Text);
      A435.Click += (o, e) => AEBA(A435.Text);
      A436.Click += (o, e) => AEBA(A436.Text);
      A437.Click += (o, e) => AEBA(A437.Text);
      A438.Click += (o, e) => AEBA(A438.Text);
      A441.Click += (o, e) => AEBA(A441.Text);
      A442.Click += (o, e) => AEBA(A442.Text);
      A443.Click += (o, e) => AEBA(A443.Text);
      A444.Click += (o, e) => AEBA(A444.Text);
      A445.Click += (o, e) => AEBA(A445.Text);
      A446.Click += (o, e) => AEBA(A446.Text);
      A447.Click += (o, e) => AEBA(A447.Text);
      A448.Click += (o, e) => AEBA(A448.Text);
      #endregion
      #region
      FAB = ["a", Resources!.GetText(Resource.String.B001), "1",
      "ax", Resources!.GetText(Resource.String.B002), "1",
      "ay", Resources!.GetText(Resource.String.B003), "1",
      "az", Resources!.GetText(Resource.String.B004), "1",
      "c", Resources!.GetText(Resource.String.B005), "0",
      "Ek1", Resources!.GetText(Resource.String.B006), "2",
      "Ek2", Resources!.GetText(Resource.String.B007), "2",
      "ΔEk", Resources!.GetText(Resource.String.B008), "2",
      "Ep1", Resources!.GetText(Resource.String.B009), "2",
      "Ep2", Resources!.GetText(Resource.String.B010), "2",
      "ΔEp", Resources!.GetText(Resource.String.B011), "2",
      "F", Resources!.GetText(Resource.String.B012), "3",
      "Fx", Resources!.GetText(Resource.String.B013), "3",
      "Fy", Resources!.GetText(Resource.String.B014), "3",
      "Fz", Resources!.GetText(Resource.String.B015), "3",
      "Ff", Resources!.GetText(Resource.String.B016), "4",
      "Ffx", Resources!.GetText(Resource.String.B017), "4",
      "Ffy", Resources!.GetText(Resource.String.B018), "4",
      "Ffz", Resources!.GetText(Resource.String.B019), "4",
      "|Fn|", Resources!.GetText(Resource.String.B020), "5",
      "Frg", Resources!.GetText(Resource.String.B021), "6",
      "Frgx", Resources!.GetText(Resource.String.B022), "6",
      "Frgy", Resources!.GetText(Resource.String.B023), "6",
      "Frgz", Resources!.GetText(Resource.String.B024), "6",
      "Frh", Resources!.GetText(Resource.String.B025), "7",
      "Frhx", Resources!.GetText(Resource.String.B026), "7",
      "Frhy", Resources!.GetText(Resource.String.B027), "7",
      "Frhz", Resources!.GetText(Resource.String.B028), "7",
      "Frr", Resources!.GetText(Resource.String.B029), "8",
      "Frrx", Resources!.GetText(Resource.String.B030), "8",
      "Frry", Resources!.GetText(Resource.String.B031), "8",
      "Frrz", Resources!.GetText(Resource.String.B032), "8",
      "Ft", Resources!.GetText(Resource.String.B033), "9",
      "Ftx", Resources!.GetText(Resource.String.B034), "9",
      "Fty", Resources!.GetText(Resource.String.B035), "9",
      "Ftz", Resources!.GetText(Resource.String.B036), "9",
      "k" ,Resources!.GetText(Resource.String.B037), "0",
      "M" ,Resources!.GetText(Resource.String.B038), "0",
      "m" ,Resources!.GetText(Resource.String.B039), "0",
      "μg" ,Resources!.GetText(Resource.String.B040), "0",
      "μh" ,Resources!.GetText(Resource.String.B041), "0",
      "μr" ,Resources!.GetText(Resource.String.B042), "0",
      "n" ,Resources!.GetText(Resource.String.B043), "0",
      "P" ,Resources!.GetText(Resource.String.B044), "0",
      "p" ,Resources!.GetText(Resource.String.B045), "10",
      "px" ,Resources!.GetText(Resource.String.B046), "10",
      "py" ,Resources!.GetText(Resource.String.B047), "10",
      "pz" ,Resources!.GetText(Resource.String.B048), "10",
      "s1" ,Resources!.GetText(Resource.String.B049), "11",
      "sx1" ,Resources!.GetText(Resource.String.B050), "11",
      "sy1" ,Resources!.GetText(Resource.String.B051), "11",
      "sz1" ,Resources!.GetText(Resource.String.B052), "11",
      "s2" ,Resources!.GetText(Resource.String.B053), "12",
      "sx2" ,Resources!.GetText(Resource.String.B054), "12",
      "sy2" ,Resources!.GetText(Resource.String.B055), "12",
      "sz2" ,Resources!.GetText(Resource.String.B056), "12",
      "Δs" ,Resources!.GetText(Resource.String.B057), "13",
      "Δsx" ,Resources!.GetText(Resource.String.B058), "13",
      "Δsy" ,Resources!.GetText(Resource.String.B059), "13",
      "Δsz" ,Resources!.GetText(Resource.String.B060), "13",
      "t1" ,Resources!.GetText(Resource.String.B061), "14",
      "t2" ,Resources!.GetText(Resource.String.B062), "14",
      "Δt" ,Resources!.GetText(Resource.String.B063), "14",
      "V" ,Resources!.GetText(Resource.String.B064), "0",
      "v" ,Resources!.GetText(Resource.String.B065), "15",
      "vx" ,Resources!.GetText(Resource.String.B066), "15",
      "vy" ,Resources!.GetText(Resource.String.B067), "15",
      "vz" ,Resources!.GetText(Resource.String.B068), "15",
      "v1" ,Resources!.GetText(Resource.String.B069), "16",
      "vx1" ,Resources!.GetText(Resource.String.B070), "16",
      "vy1" ,Resources!.GetText(Resource.String.B071), "16",
      "vz1" ,Resources!.GetText(Resource.String.B072), "16",
      "v2" ,Resources!.GetText(Resource.String.B073), "17",
      "vx2" ,Resources!.GetText(Resource.String.B074), "17",
      "vy2" ,Resources!.GetText(Resource.String.B075), "17",
      "vz2" ,Resources!.GetText(Resource.String.B076), "17",
      "Δv" ,Resources!.GetText(Resource.String.B077), "18",
      "Δvx" ,Resources!.GetText(Resource.String.B078), "18",
      "Δvy" ,Resources!.GetText(Resource.String.B079), "18",
      "Δvz" ,Resources!.GetText(Resource.String.B080), "18",
      "{v}" ,Resources!.GetText(Resource.String.B081), "19",
      "{vx}" ,Resources!.GetText(Resource.String.B082), "19",
      "{vy}" ,Resources!.GetText(Resource.String.B083), "19",
      "{vz}" ,Resources!.GetText(Resource.String.B084), "19",
      "W" ,Resources!.GetText(Resource.String.B085), "2",
      "θ" ,Resources!.GetText(Resource.String.B086), "0",
      "ϕ" ,Resources!.GetText(Resource.String.B087), "0"];
      EAA3 = [
      "Δs = s2 - s1   =>   Δs = s2 - s1",
      "Δs = s2 - s1   =>   s1 = s2 - Δs",
      "Δs = s2 - s1   =>   s2 = s1 + Δs",
      "Δt = t2 - t1   =>   Δt = t2 - t1",
      "Δt = t2 - t1   =>   t1 = t2 - Δt",
      "Δt = t2 - t1   =>   t2 = t1 + Δt",
      "Δv = v2 - v1   =>   Δv = v2 - v1",
      "Δv = v2 - v1   =>   v1 = v2 - Δv",
      "Δv = v2 - v1   =>   v2 = v1 + Δv",
      "{v} = (v1 + v2) : 2   =>   {v} = (v1 + v2) : 2",
      "{v} = (v1 + v2) : 2   =>   v1 = 2 · {v} - v2",
      "{v} = (v1 + v2) : 2   =>   v2 = 2 · {v} - v1",
      "Δv = 2 (v2 - {v})   =>   Δv = 2 · (v2 - {v}) *",
      "Δv = 2 (v2 - {v})   =>   v2 = Δv : 2 + {v} *",
      "Δv = 2 (v2 - {v})   =>   {v} = v2 - Δv : 2 *",
      "Δv = 2 ({v} - v1)   =>   Δv = 2 · ({v} - v1) *",
      "Δv = 2 ({v} - v1)   =>   v1 = {v} - Δv : 2 *",
      "Δv = 2 ({v} - v1)   =>   {v} = v1 + Δv : 2 *",
      "Δv {v} = (v2 ^ 2 - v1 ^ 2) : 2 *",
      "{v} = Δs : Δt   =>   {v} = Δs : Δt",
      "{v} = Δs : Δt   =>   Δs = Δt · {v}",
      "{v} = Δs : Δt   =>   Δt = Δs : {v}",
      "a = Δv : Δt   =>   a = Δv : Δt",
      "a = Δv : Δt   =>   Δv = a · Δt",
      "a = Δv : Δt   =>   Δt = Δv : a",
      "F = a m   =>   F = a · m",
      "F = a m   =>   a = F : m",
      "F = a m   =>   m = F : a",
      "W = F Δs   =>   W = F · Δs",
      "W = F Δs   =>   F = W : Δs",
      "W = F Δs   =>   Δs = W : F",
      "W = ΔEk   =>   W = ΔEk",
      "W = ΔEk   =>   ΔEk = W",
      "W = -ΔEp   =>   W = -ΔEp",
      "W = -ΔEp   =>   ΔEp = -W",
      "ΔEk = Ek2 - Ek1   =>   ΔEk = Ek2 - Ek1",
      "ΔEk = Ek2 - Ek1   =>   Ek1 = Ek2 - ΔEk",
      "ΔEk = Ek2 - Ek1   =>   Ek2 = Ek1 + ΔEk",
      "ΔEp = Ep2 - Ep1   =>   ΔEp = Ep2 - Ep1",
      "ΔEp = Ep2 - Ep1   =>   Ep1 = Ep2 - ΔEp",
      "ΔEp = Ep2 - Ep1   =>   Ep2 = Ep1 + ΔEp",
      "P = W : Δt   =>   P = W : Δt",
      "P = W : Δt   =>   Δt = W : P",
      "P = W : Δt   =>   W = P · Δt",
      "c = n : V   =>   c = n : V",
      "c = n : V   =>   n = c · V",
      "c = n : V   =>   V = n : c",
      "M = m : n   =>   M = m : n",
      "M = m : n   =>   m = M · n",
      "M = m : n   =>   n = m : M",
      "v = Δs : Δt   =>   v = Δs : Δt",
      "v = Δs : Δt   =>   Δs = v · Δt",
      "v = Δs : Δt   =>   Δt = Δs : v",
      "p = m v   =>   p = m · v",
      "p = m v   =>   m = p : v",
      "p = m v   =>   v = p : m",
      "F = -k Δs   =>   F = -k · Δs",
      "F = -k Δs   =>   k = -F : Δs",
      "F = -k Δs   =>   Δs = -F : k",
      "P = F {v}   =>   P = F · {v} *",
      "P = F {v}   =>   F = P : {v} *",
      "P = F {v}   =>   {v} = P : F *",
      "W = m Δv {v}   =>   W = m · Δv · {v} *",
      "W = m Δv {v}   =>   m = W : Δv : {v} *",
      "W = m Δv {v}   =>   Δv = W : m : {v} *",
      "W = m Δv {v}   =>   {v} = W : m : Δv *",
      "W = m Δv (v1 + Δv : 2)   =>   W = m · Δv · (v1 + Δv : 2) *",
      "W = m Δv (v1 + Δv : 2)   =>   m = W : Δv : (v1 + Δv : 2) *",
      "W = m Δv (v1 + Δv : 2)   =>   v1 = W : m : Δv - Δv : 2 *",
      "W = m Δv (v1 + Δv : 2)   =>   Δv = -v1 ± √(v1 ^ 2 + 2 · W : m) *",
      "W = m Δv (v2 - Δv : 2)   =>   W = m · Δv (v2 - Δv : 2)   *",
      "W = m Δv (v2 - Δv : 2)   =>   m = W : Δv : (v2 - Δv : 2) *",
      "W = m Δv (v2 - Δv : 2)   =>   v2 = W : m : Δv + Δv : 2 *",
      "W = m Δv (v2 - Δv : 2)   =>   Δv = v2 ± √(v2 ^ 2 - 2 · W : m) *",
      "F = √(-k W)   =>   F = √(-k · W) *",
      "F = √(-k W)   =>   k = -(F ^ 2) : W *",
      "F = √(-k W)   =>   W = -(F ^ 2) : k *",
      "Δs = √(-W : k)   =>   Δs = √(-W : k) *",
      "Δs = √(-W : k)   =>   k = -W : Δs ^ 2 *",
      "Δs = √(-W : k)   =>   W = -k · (Δs ^ 2) *",
      "W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   W = m (v2 ^ 2 - v1 ^ 2) : 2 *",
      "W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   m = 2 W : (v2 ^ 2 - v1 ^ 2) *",
      "W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   v1 = √(v2 ^ 2 - 2 W : m) *",
      "W = m (v2 ^ 2 - v1 ^ 2) : 2   =>   v2 = √(v1 ^ 2 + 2 W : m) *",
      "F = |Fn| μg   =>   F = |Fn| μg *",
      "F = |Fn| μg   =>   |Fn| = F : μg *",
      "F = |Fn| μg   =>   μg = F : |Fn| *",
      "F = |Fn| μh   =>   F = |Fn| μh *",
      "F = |Fn| μh   =>   |Fn| = F : μh *",
      "F = |Fn| μh   =>   μh = F : |Fn| *",
      "F = |Fn| μr   =>   F = |Fn| μr *",
      "F = |Fn| μr   =>   |Fn| = F : μr *",
      "F = |Fn| μr   =>   μr = F : |Fn| *",
      "W = |Fn| μg Δs   =>   W = |Fn| μg Δs *",
      "W = |Fn| μg Δs   =>   |Fn| = W : μg : Δs *",
      "W = |Fn| μg Δs   =>   μg = W : |Fn| : Δs *",
      "W = |Fn| μg Δs   =>   Δs = W : |Fn| : μg *",
      "W = |Fn| μh Δs   =>   W = |Fn| μh Δs *",
      "W = |Fn| μh Δs   =>   |Fn| = W : μh : Δs *",
      "W = |Fn| μh Δs   =>   μh = W : |Fn| : Δs *",
      "W = |Fn| μh Δs   =>   Δs = W : |Fn| : μh *",
      "W = |Fn| μr Δs   =>   W = |Fn| μr Δs *",
      "W = |Fn| μr Δs   =>   |Fn| = W : μr : Δs *",
      "W = |Fn| μr Δs   =>   μr = W : |Fn| : Δs *",
      "W = |Fn| μr Δs   =>   Δs = W : |Fn| : μr *",
      "",
      "",
      "",
      "",
      "",
     Resources!.GetText(Resource.String.B000)];
      IGA4 = [
      "", "a", "W", "F", "Ff", "|Fn|", "Frg", "Frh", "Frr", "Ft",
      "p", "s1", "s2", "Δs", "Δt", "v", "v1", "v2", "Δv", "{v}"];
      W_FA = [
      "a", "c", "F", "k", "M", "m", "n", "P",
      "p", "V", "v", "W", "θ", "ϕ", "ax", "ay", "az", "Ff", "Ft",
      "Fx", "Fy", "Fz", "μg", "μh", "μr", "px", "py", "pz", "s1",
      "s2", "Δs", "t1", "t2", "Δt", "v1", "v2", "vx", "vy", "vz",
      "Δv", "Ek1", "Ek2", "ΔEk", "Ep1", "Ep2", "ΔEp", "Ffx", "Ffy",
      "Ffz", "Frg", "Frh", "Frr", "Ftx", "Fty", "Ftz", "sx1", "sy1",
      "sz1", "sx2", "sy2", "sz2", "Δsx", "Δsy", "Δsz", "vx1", "vy1",
      "vz1", "vx2", "vy2", "vz2", "Δvx", "Δvy", "Δvz", "{v}", "Frgx",
      "Frgy", "Frgz", "Frhx", "Frhy", "Frhz", "Frrx", "Frry", "Frrz",
      "|Fn|", "{vx}", "{vy}", "{vz}"];
      GAA = [
      A401, A402, A403, A404, A405, A406, A407, A408,
      A411, A412, A413, A414, A415, A416, A417, A418,
      A421, A422, A423, A424, A425, A426, A427, A428,
      A431, A432, A433, A434, A435, A436, A437, A438,
      A441, A442, A443, A444, A445, A446, A447, A448];
      #endregion
      #region
      AFAA(); CBA = ""; CBB = ""; CBC = "";
      CBD = ""; CBE = ""; CBF = "";
      //AB1.Background.SetAlpha(0); !!!!!    Opacity   !!!!!  
      #endregion
    }
    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    {
      //Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
      base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    }
    #endregion
    #region A-AB
    private void ABAA()
    {
      A101.SetCursorVisible(true); A103.SetCursorVisible(false);
    }
    private void ABAB()
    {
      A101.SetCursorVisible(false);
      if (A303.Text == "A1") { A103.SetCursorVisible(true); } else { A103.SetCursorVisible(false); }
      if (DAA == true) { A103.ShowSoftInputOnFocus = false; } else { A103.ShowSoftInputOnFocus = true; }
    }
    private void ABAE()
    {
      JavaList<string> ab = [];
      try
      {
        //1     Löschen alter Definitionen
        AEAG();
        //2     Split von A201-Text
        FAA = A101!.Text!.TrimEnd(' ').Split(' ');

        //3     Aufgabe-Platz-Zeiger
        if (A101.Text ==Resources!.GetText(Resource.String.A021) |
            A101.Text ==Resources!.GetText(Resource.String.A022))
        {
          A103.Hint =Resources!.GetText(Resource.String.A032);
          A103.Visibility = ViewStates.Visible; return;
        }
        //4     Gleichung-Platz-Zeiger
        if (A101.Text.Length > 2)
        {
          if (A101.Text[..2] == Resources!.GetText(Resource.String.A021) |
              A101.Text[..2] == Resources!.GetText(Resource.String.A022))
          {
            A103.Hint =Resources!.GetText(Resource.String.A033);
            A103.Visibility = ViewStates.Visible; return;
          }
        }
        //5     Formelsuche
        if (FAA.Length > 0) { EAAA(); EAAB(); }
        //6     Filterung der Kods nach eingegebene Zeichen
        if (CAI != "")
        {
          for (int i = 0; i < FAC.Length - 5; i += 5)
          {
            if (FAC[i].Length >= A101.Text.Length)
            { if (A101.Text == FAC[i][..A101.Text.Length]) { ab.Add(FAC[i]); } }
          }
        }
        //7     Auswahl eines Vorschlags
        A101.Adapter = new ArrayAdapter<string>(this, Resource.Layout.listitemac, ab);
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " A1"; }
    }
    private void ABAF()
    {

    }
    #endregion
    #region A-AC
    private void ACAA()
    {
      try
      {
        A303.Text = "A3";

        string url = "https://docs.google.com/document/d/1MJnRJCqZtw8aWzmZuoKwRywiKrKXue8HVNvXfWA0PSc/edit?";
        Uri uri = new(url);
        string htmlText = $"<a href='{uri}'>Privacy Policy</a>";

        if (CBA == "")
        {
          for (int i = 0; i < 5; i++)
          {
            CBA += Resources!.GetStringArray(Resource.Array.T001)[i] + "<br><br>";
          }
        }

        // Kombiniere CBA und htmlText zu einem HTML-String
        string combinedHtml = CBA + htmlText;

        if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Q)
        {
          A103.TextFormatted = Html.FromHtml(combinedHtml, FromHtmlOptions.ModeLegacy);
        }
        A103.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
        AEBC(8, 0);
      }
      catch
      {
        A103.Text = Resources!.GetText(Resource.String.A034) + " B5";
      }
    }



//•	mipmap-mdpi: 48x48 px

//•	mipmap-hdpi: 72x72 px

//•	mipmap-xhdpi: 96x96 px

//•	mipmap-xxhdpi: 144x144 px

//•	mipmap-xxxhdpi: 192x192 px


    //private void ACAA()
    //{
    //  try
    //  {
    //    A303.Text = "A3";

    //    string url = "https://docs.google.com/document/d/1MJnRJCqZtw8aWzmZuoKwRywiKrKXue8HVNvXfWA0PSc/edit?"; 
    //    Uri uri = new(url);
    //    string htmlText = $"<a href='{uri}'>Privacy Policy</a>";

    //    if (CBA == "")
    //    {
    //      for (int i = 0; i < 5; i++)
    //      { CBA += Resources!.GetStringArray(Resource.Array.T001)[i] + '\n' + '\n'; }
    //      //NBA = new SpannableString(CBA);
    //      //NBA.SetSpan(new ForegroundColorSpan(Color.LightGray), 0, CBA.Length, SpanTypes.ExclusiveInclusive);
    //    }

    //    if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.Q)
    //    {
    //      A103.TextFormatted = Html.FromHtml(htmlText, FromHtmlOptions.ModeLegacy);
    //    }
    //    A103.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
    //    CBA += htmlText; A103.Text = CBA; AEBC(8, 0);
    //    //A103.TextFormatted = NBA;
    //  }
    //  catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B5"; }
    //}
    private void ACAB()
    {
      try
      {
        A303.Text = "A3";
        if (CBB == "")
        {
          int aa, ab;
          CBB = Resources!.GetString(Resource.String.A016) + '\n' + '\n' + "c = n : V" + '\n' + '\n' + "M = m : n";
          NBB = new SpannableString(CBB); aa = 0; ab = Resources!.GetString(Resource.String.A016).Length;
          NBB.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive); aa = ab;
          ab = CBB.Length; NBB.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
        }
        A103.TextFormatted = NBB; AEBC(8, 0);
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B6"; }
    }
    private void ACAC()
    {
      try
      {
        A303.Text = "A3";
        if (CBC == "")
        {
          for (int i = 0; i < 2; i++)
          { CBC += Resources!.GetStringArray(Resource.Array.T002)[i] + '\n' + '\n'; }
          //CBC += "   0 · ∞ = ₪\n   0 : 0 = ₪\n   0 ^ 0 = ₪\n   1 ^ ∞ = ₪\n   ∞ - ∞ = ₪\n   ∞ : ∞ = ₪\n   ∞ ^ 0 = ₪";
          NBC = new SpannableString(CBC);
          NBC.SetSpan(new ForegroundColorSpan(Color.LightGray), 0, CBC.Length, SpanTypes.ExclusiveInclusive);
        }
        A103.TextFormatted = NBC; AEBC(8, 0);
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B7"; }
    }
    private void ACAD()
    {
      try
      {
        A303.Text = "A3";
        if (CBD == "")
        {
          int aa, ab;
          CBD = Resources!.GetString(Resource.String.A016) + '\n' + '\n' + "a = Δv : Δt" + '\n' + '\n' +
            "ΔEk = Ek2 - Ek1" + '\n' + '\n' + "ΔEp = Ep2 - Ep1" + '\n' + '\n' + "F = a m" + '\n' + '\n' +
               "Ff = -k Δs" + '\n' + '\n' + "Frg = μg |Fn|" + '\n' + '\n' + "Frh = μh |Fn|" + '\n' + '\n' +
               "Frr = μr |Fn|" + '\n' + '\n' + "P = W : Δt" + '\n' + '\n' + "p = m v" + '\n' + '\n' +
               "Δs = s2 - s1" + '\n' + '\n' + "Δt = t2 - t1" + '\n' + '\n' + "v = Δs : Δt" + '\n' + '\n' +
               "Δv = v2 - v1" + '\n' + '\n' + "{v} = Δs : Δt" + '\n' + '\n' + "{v} = (v1 + v2) : 2" +
               '\n' + '\n' + "W = F Δs" + '\n' + '\n' + "W = ΔEk" + '\n' + '\n' + "W = -ΔEp";
          NBD = new SpannableString(CBD); aa = 0; ab = Resources.GetString(Resource.String.A016).Length;
          NBD.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive); aa = ab;
          ab = CBD.Length;
          NBD.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
        }
        A103.TextFormatted = NBD; AEBC(8, 0);
      }
      catch
      {
        A103.Text =Resources!.GetText(Resource.String.A034) + " B8";
      }
    }
    private void ACAE()
    {
      try
      {
        A303.Text = "A3";
        if (CBE == "")
        {
          int aa, ab;
          for (int i = 0; i < 22; i++)
          { CBE += Resources!.GetStringArray(Resource.Array.T003)[i] + '\n' + '\n'; }
          NBE = new SpannableString(CBE);
          aa = 0; ab = Resources!.GetStringArray(Resource.Array.T003)[0].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[1].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[2].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[3].Length + 2;
          ab += Resources.GetStringArray(Resource.Array.T003)[4].Length + 2;
          ab += Resources.GetStringArray(Resource.Array.T003)[5].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[6].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[7].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[8].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[9].Length + 2;
          ab += Resources.GetStringArray(Resource.Array.T003)[10].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[11].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[12].Length + 2;
          ab += Resources.GetStringArray(Resource.Array.T003)[13].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[14].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[15].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[16].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[17].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[18].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[19].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[20].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.Gold), aa, ab, SpanTypes.ExclusiveInclusive);
          aa = ab; ab += Resources.GetStringArray(Resource.Array.T003)[21].Length + 2;
          NBE.SetSpan(new ForegroundColorSpan(Color.LightGray), aa, ab, SpanTypes.ExclusiveInclusive);
        }
        A103.TextFormatted = NBE; AEBC(8, 0);
      }
      catch
      {
        A103.Text =Resources!.GetText(Resource.String.A034) + " B9";
      }
    }
    private void ACAF()
    {
      try
      {
        A303.Text = "A3"; //A103.LineHeight = 60;
        if (CBF == "")
        {
          int[] aa = new int[37]; aa[0] = 0;
          // Text
          CBF = Resources!.GetString(Resource.String.A016) + "\n" + "\n"; aa[1] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C001) + "\n" + "\n"; aa[2] = CBF.Length;
          CBF += "a = a" + "\n" + "\n";
          aa[3] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C002) + "\n" + "\n"; aa[4] = CBF.Length;
          CBF += "a = b\n\n";
          aa[5] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C003) + "\n"; aa[6] = CBF.Length;
          CBF += "a ± 0 = a\n";
          CBF += "a · 0 = 0\n";
          CBF += "a : 0 = ∞\n";
          CBF += "a ^ 0 = 1\n\n";
          aa[7] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C004) + "\n"; aa[8] = CBF.Length;
          CBF += "a · 1 = a\n";
          CBF += "a : 1 = a\n";
          CBF += "a ^ 1 = a\n\n";
          aa[9] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C005) + "\n"; aa[10] = CBF.Length;
          CBF += "e = 2,718281828\n\n";
          aa[11] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C006) + "\n"; aa[12] = CBF.Length;
          CBF += "π = 3,141592654\n\n";
          aa[13] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C007) + "\n"; aa[14] = CBF.Length;
          CBF += "a + -b = a - b\n";
          CBF += "a - -b = a + b\n";
          CBF += "a · -b = -a · b\n";
          CBF += "-a · -b = a · b\n\n";
          aa[15] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C008) + "\n"; aa[16] = CBF.Length;
          CBF += "(a) = a" + '\n';
          CBF += "a + (b +- c) = a + b +- c\n";
          CBF += "a - (b +- c) = a - b -+ c\n";
          CBF += "a · (b ·: c) = a · b ·: c\n";
          CBF += "a : (b ·: c) = a : b :· c\n\n";
          aa[17] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C009) + "\n"; aa[18] = CBF.Length;
          CBF += "|-a| = |a|\n";
          CBF += "|a| = a   (a ≥ 0)\n";
          CBF += "|a| = -a   (a < 0)\n\n";
          aa[19] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C010) + "\n"; aa[20] = CBF.Length;
          CBF += "a - a = 0\n";
          CBF += "a / a = 1\n\n";
          aa[21] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C011) + "\n"; aa[22] = CBF.Length;
          CBF += "0 · ∞ = ₪\n";
          CBF += "0 : 0 = ₪\n";
          CBF += "0 ^ 0 = ₪\n";
          CBF += "1 ^ ∞ = ₪\n";
          CBF += "∞ - ∞ = ₪\n";
          CBF += "∞ : ∞ = ₪\n";
          CBF += "∞ ^ 0 = ₪\n\n";
          aa[23] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C012) + "\n"; aa[24] = CBF.Length;
          CBF += "b + a = a + b\n";
          CBF += "b · a = a · b\n\n";
          aa[25] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C013) + "\n"; aa[26] = CBF.Length;
          CBF += "a +- b = c\n";
          CBF += "a ·: b = c\n";
          CBF += "a ˄˅ b = c\n\n";
          aa[27] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C014) + "\n"; aa[28] = CBF.Length;
          CBF += "cos(a) = b\n";
          CBF += "sin(a) = b\n";
          CBF += "tan(a) = b\n";
          CBF += "cot(a) = b\n";
          CBF += "acos(a) = b\n";
          CBF += "asin(a) = b\n";
          CBF += "atan(a) = b\n";
          CBF += "acot(a) = b\n\n";
          aa[29] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C015) + "\n"; aa[30] = CBF.Length;
          CBF += "ln(a) = b\n";
          CBF += "ln(0) = -∞\n";
          CBF += "ln(e) = 1\n";
          CBF += "log(a) = b\n";
          CBF += "log(a ' b) = с\n\n";
          aa[31] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C016) + "\n"; aa[32] = CBF.Length;
          CBF += "a! = a · (a - 1) · ... · 1    a < 170\n\n";
          aa[33] = CBF.Length;
          CBF += Resources!.GetString(Resource.String.C017) + "\n"; aa[34] = CBF.Length;
          CBF += "a´ = 0\n\n";
          aa[35] = CBF.Length;

          CBF += Resources!.GetString(Resource.String.C018) + "\n";
          CBF += "a · c + b · c = (a + b) · c\n";
          aa[36] = CBF.Length;

          NBF = new SpannableString(CBF);
          NBF.SetSpan(new ForegroundColorSpan(Color.LightGray), aa[0], aa[1], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.Blue), aa[1], aa[2], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[2], aa[3], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.Blue), aa[3], aa[4], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[4], aa[5], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[5], aa[6], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[6], aa[7], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[7], aa[8], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[8], aa[9], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[9], aa[10], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[10], aa[11], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[11], aa[12], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[12], aa[13], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[13], aa[14], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[14], aa[15], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[15], aa[16], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[16], aa[17], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[17], aa[18], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[18], aa[19], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[19], aa[20], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[20], aa[21], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[21], aa[22], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[22], aa[23], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[23], aa[24], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[24], aa[25], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[25], aa[26], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[26], aa[27], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[27], aa[28], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[28], aa[29], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[29], aa[30], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[30], aa[31], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[31], aa[32], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[32], aa[33], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SeaGreen), aa[33], aa[34], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.SkyBlue), aa[34], aa[35], SpanTypes.ExclusiveInclusive);
          NBF.SetSpan(new ForegroundColorSpan(Color.LightGray), aa[35], aa[36], SpanTypes.ExclusiveInclusive);
        }
        A103.TextFormatted = NBF; AEBC(8, 0);
      }
      catch
      {
        A103.Text = Resources!.GetText(Resource.String.A034) + " B10";
      }
    }
    #endregion
    #region A-AD
    private void ADAA()
    {
      try
      {
        if (A301.Text == Resources!.GetString(Resource.String.A003))
        {
          if (A102.Text == "") { DAAA(); return; }
          if (A102.Text != "") { EAAE(); return; }
        }
        if (A301.Text == Resources!.GetString(Resource.String.A005)) { AEAE(); return; }
        if (A301.Text == Resources!.GetString(Resource.String.A009)) { AEAE(); return; }
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B1"; }
    }
    private void ADAB()
    {
      try
      {
        DAA = false;
        A101.Text = ""; AEAG(); A303.Text = "A1"; AEBD(2);
        A101.Hint =Resources!.GetText(Resource.String.A031);
        A103.Hint =Resources!.GetText(Resource.String.A032);
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B2"; }
    }
    private void ADAC()
    {
      try
      {
        if (A303.Text == "A1" | A303.Text == "A3")
        {
          A201.Text =Resources!.GetText(Resource.String.A011);
          A202.Text =Resources!.GetText(Resource.String.A017);
          A203.Text =Resources!.GetText(Resource.String.A012);
          A204.Text =Resources!.GetText(Resource.String.A018);
          A205.Text =Resources!.GetText(Resource.String.A013);
          A206.Text =Resources!.GetText(Resource.String.A019);
          // Reihenfolge !!!
          A303.Text = "A2"; AEAB(); AEBC(0, 8); AEBD(0); DAA = true;
          //if (A301.Text == Resources!.GetString(Resource.String.A003))
          //{ NBB = new SpannableString(A103.Text); } //  AEAD();
        }
        else
        {
          if (A303.Text == "A2")
          {
            A303.Text = "A1"; AEAA(); AEBC(8, 0); AEBD(2);
            if (A301.Text == Resources!.GetString(Resource.String.A003)) { A103.Text = ""; }
            if (A301.Text == Resources!.GetString(Resource.String.A005)) { A103.TextFormatted = NAA; }
            if (A301.Text == Resources!.GetString(Resource.String.A009)) { A103.TextFormatted = NAB; }
          }
        }
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B3"; }
    }
    private void ADAD()
    {
      try
      {
        if (DAA == false) { AEAA(); return; }
        if (A304.Text == "B1") { AFAB(); return; }
        if (A304.Text == "B2") { AFAC(); return; }
        if (A304.Text == "B3") { AFAD(); return; }
        if (A304.Text == "B4") { AFAE(); return; }
        if (A304.Text == "B5") { AFAF(); return; }
        if (A304.Text == "B6") { AFAG(); return; }
        if (A304.Text == "B7") { AFAH(); return; }
        if (A304.Text == "B8") { AFAA(); return; }
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B4"; }
    }
    #endregion
    #region A-AE
    private void AEAA()
    {
      // C10-Keyboard einschalten
      GridLayout.LayoutParams aa = new()
      {
        RowSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 5f),
        ColumnSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 1f)
      };
      A400.LayoutParameters = aa; DAA = true;
      A101.ShowSoftInputOnFocus = false; A103.ShowSoftInputOnFocus = false;
      //FAA = new Timer(100); FAA.Elapsed += AYYY; FAA.Start();
    }
    private void AEAB()
    {
      // C10-Keyboard ausschalten
      GridLayout.LayoutParams aa = new()
      {
        RowSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 0f),
        ColumnSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 1f)
      };
      A400.LayoutParameters = aa; DAA = false;
      A101.ShowSoftInputOnFocus = true; A103.ShowSoftInputOnFocus = true;
    }
    private void AEAC()
    {
      // Google-Keyboard einschalten
      InputMethodManager aa = (InputMethodManager)this!.GetSystemService(Context.InputMethodService)!;
      aa.ShowSoftInput(A101, ShowFlags.Forced); aa.ShowSoftInput(A103, ShowFlags.Forced);
      //A101.ShowSoftInputOnFocus = true; A103.ShowSoftInputOnFocus = true;

      //InputMethodManager inputManager = (InputMethodManager)this.GetSystemService(Context.InputMethodService);
      //inputManager.ShowSoftInput(AC1, ShowFlags.Forced);


      //Google-Keyboard ausschalten
      //aa.HideSoftInputFromWindow(A101.WindowToken, HideSoftInputFlags.None);
      //aa.HideSoftInputFromWindow(A103.WindowToken, HideSoftInputFlags.None);
      //A101.ShowSoftInputOnFocus = false; A103.ShowSoftInputOnFocus = false;
      //Google-Keyboard umschalten
      //aa.ToggleSoftInput(ShowFlags.Forced, HideSoftInputFlags.None);
    }
    private void AEAE()
    {
      try
      {
        if (CAA == "") { return; }
        ; string ab; int ad = 0, ae = 0; ab = "";
        A103.Text = ""; A103.Background = GetDrawable(Resource.Drawable.color6);
        if (A301.Text == Resources!.GetString(Resource.String.A009))
        {
          for (int i = 0; i < KAA.Count; i++)
          {
            ab += KAA[i]!.Replace(GetString(Resource.String.A041), 
              Resources!.GetString(Resource.String.A042)) + '\n';
            ab += KAB[i] + '\n' + '\n';
          }
          NAA = new SpannableString(ab);
          for (int i = 0; i < KAA.Count; i++)
          {
            ad = ae; ae += KAA[i]!.Length + 1;
            NAA.SetSpan(new ForegroundColorSpan(Color.Blue), ad, ae, SpanTypes.ExclusiveInclusive);
            ad = ae; ae += KAB[i]!.Length + 2;
            NAA.SetSpan(new ForegroundColorSpan(Color.DeepSkyBlue), ad, ae, SpanTypes.ExclusiveInclusive);
          }
          A301.SetTextColor(Color.Magenta); A301.Text = Resources!.GetString(Resource.String.A005);
          NAA.SetSpan(new FontStyle(100, FontSlant.Upright), 0, ab.Length,
              SpanTypes.ExclusiveInclusive); A103.TextFormatted = NAA;
        }
        else
        {
          for (int i = 0; i < KAL.Count; i++) { ab += KAL[i]; }
          NAB = new SpannableString(ab); ad = 0; ae = 0;
          for (int i = 0; i < KAL.Count; i++)
          {
            ad = ae; ae += KAL[i]!.Length;
            NAB.SetSpan(new ForegroundColorSpan(JAC[i]), ad, ae, SpanTypes.ExclusiveInclusive);
          }
          A301.SetTextColor(Color.Magenta); A301.Text = Resources!.GetString(Resource.String.A009);
          NAB.SetSpan(new FontStyle(100, FontSlant.Upright), 0, ab.Length,
              SpanTypes.ExclusiveInclusive); A103.TextFormatted = NAB;
        }
      }
      catch { A103.Text =Resources!.GetText(Resource.String.A034) + " B1"; }
    }
    private void AEAF()
    {
      //try
      //{
      //    if (B36.Text == "<x")
      //    {
      //        if (AAA2 == -1 & A201.Text.Length > 0) { A201.Text = A201.Text.Remove(A201.Text.Length - 1, 1); }
      //        if (AAA2 == -2 & A203.Text.Length > 0)
      //        {
      //            int ab = A203.SelectionStart - 1; A203.Text = A203.Text.Remove(ab, 1); A203.SetSelection(ab);
      //        }
      //        if (AAA2 > 0 & EAA4[AAA2 - 1].Length > 6)
      //        {
      //            Source6.RemoveAt(AAA2 - 1); EAA4[AAA2 - 1] = EAA4[AAA2 - 1].Remove(EAA4[AAA2 - 1].Length - 1, 1);
      //            Source6.Insert(AAA2 - 1, new Adapter1ViewHolder { LVL1 = EAA4[AAA2 - 1], LVL2 = FAB[DAA17[AAA2 - 1] + 1] });
      //            LV1.Adapter = new Adapter1(this, Source6); LV1.SetSelection(AAA2 - 1);
      //        }
      //    }
      //    if (B36.Text != "<x") { AEBA(B36.Text); } // ←
      //}
      //catch { } //A203.SelectionStart
    }
    private void AEAG()
    {
      A102.Text = ""; A103.Text = "";
      CAA = ""; A301.Enabled = true; A301.SetTextColor(Color.White);
      A301.Text =Resources!.GetText(Resource.String.A003);
    }
    private void AEAH()
    {
      A301.Text = Resources!.GetString(Resource.String.A003); A103.Text = ""; A301.SetTextColor(Color.White);
    }
    private void AEBA(string a)
    {
      try
      {
        CAK = a; CAL = ""; CAM = ""; CAN = ""; EAC = a.Length; EAD = 0; // "┃", "│",
        if (a == "")
        {
          CAK = " "; EAC = 1;
        }
        if (a == "  ")
        {
          CAK = "\n"; EAC = 1;
        }
        if (a == " |")
        {
          CAK = "┃"; EAC = 1;
        }
        if (a == "| ")
        {
          CAK = "│"; EAC = 1;
        }
        if (a == "GB")
        {
          return;
        }
        if (a == "🌐")
        {
          AEAB(); AEAC(); return;
        }
        if (A304.Text == "B1")
        {
          if (a == " — ") { CAK = " - "; EAC = 3; }
          if (a == "√") { CAK = "√()"; EAC = 2; }
        }
        if (A304.Text == "B2")
        {
          if (a == "exp") { CAK = "e"; EAC = 1; }
          if (a == "√()") { CAK = "√(')"; EAC = 2; }
          if (a == "ln") { CAK = "ln()"; EAC = 3; }
          if (a == "Ʃ()") { CAK = "Ʃ('')"; EAC = 2; }
          if (a == "∏()") { CAK = "∏('')"; EAC = 2; }
          if (a == "lim") { CAK = "lim(')"; EAC = 4; }
          if (a == "log") { CAK = "log(')"; EAC = 4; }
          if (a == "ʃ()") { CAK = "ʃ(''d())"; EAC = 2; }
          if (a == "cos") { CAK = "cos()"; EAC = 4; }
          if (a == "sin") { CAK = "sin()"; EAC = 4; }
          if (a == "tan") { CAK = "tan()"; EAC = 4; }
          if (a == "cot") { CAK = "cot()"; EAC = 4; }
          if (a == "acos") { CAK = "acos()"; EAC = 5; }
          if (a == "asin") { CAK = "asin()"; EAC = 5; }
          if (a == "atan") { CAK = "atan()"; EAC = 5; }
          if (a == "acot") { CAK = "acot()"; EAC = 5; }
        }
        if (A101.IsCursorVisible == true) { CAL = A101.Text!; EAD = A101.SelectionStart; }
        if (A103.IsCursorVisible == true) { CAL = A103.Text!; EAD = A103.SelectionStart; }
        if (a == " " & CAL.Length > 0)
        {
          CAL = CAL.Remove(EAD - 1, 1);
          if (A101.IsCursorVisible == true) { A101.Text = CAL; A101.SetSelection(EAD - 1); return; }
          if (A103.IsCursorVisible == true) { A103.Text = CAL; A103.SetSelection(EAD - 1); return; }
        }
        CAM = CAL[..EAD]; CAN = CAL[EAD..]; //  ac = ab.Substring(0, af); ad = ab.Substring(af); <x
        if (A101.IsCursorVisible == true) { A101.Text = CAM + CAK + CAN; A101.SetSelection(CAM.Length + EAC); }
        if (A103.IsCursorVisible == true) { A103.Text = CAM + CAK + CAN; A103.SetSelection(CAM.Length + EAC); }
      }
      catch { }
    }
    private void AEBB(string[] a)
    {
      for (int i = 0; i < 32; i++) { GAA[i + 8].Text = a[i]; }
    }
    private void AEBC(float a, float b)
    {
      GridLayout.LayoutParams aa = new()
      {
        RowSpec = GridLayout.InvokeSpec(GridLayout.Undefined, a),
        ColumnSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 1f)
      };
      GridLayout.LayoutParams ab = new()
      {
        RowSpec = GridLayout.InvokeSpec(GridLayout.Undefined, b),
        ColumnSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 1f)
      };
      A100.LayoutParameters = aa; A200.LayoutParameters = ab;
    }
    private void AEBD(float a)
    {
      GridLayout.LayoutParams aa = new()
      {
        RowSpec = GridLayout.InvokeSpec(GridLayout.Undefined, a),
        ColumnSpec = GridLayout.InvokeSpec(GridLayout.Undefined, 1f)
      };
      A000.LayoutParameters = aa;
    }

    //private void AYYY(Object source, ElapsedEventArgs e)
    //{
    //    EAC += 1; A103.Text += EAC.ToString() + '\n';
    //    if (EAC == 10) { FAA.Stop(); EAC = 0; return; }
    //}
    #endregion
    #region A-AF
    private void AFAA()
    {
      A304.Text = "B1";
      FCA = ["1", "2", "3", "4", " + ", " — ", "-",
        Resources!.GetString(Resource.String.A042),
        "5", "6", "7", "8", " * ", " : ", "!", " = ",
        "9", "0", "e", "π", " ˄ ", " ˅ ", "√", "  ",
        "(", " |", "| ", ")", "∞", "Δ", "", " "];
      AEBB(FCA); DAA = true;
      A101.ShowSoftInputOnFocus = false;
      A103.ShowSoftInputOnFocus = false;
      A401.Text = "±"; A402.Text = "f";
      A403.Text = "a"; A404.Text = "A";
      A405.Text = "ö"; A406.Text = "Ö";
      A407.Text = "≡"; A408.Text = "✨";
      A101.SetCursorVisible(false); A103.SetCursorVisible(true);
      for (int i = 0; i < 8; i++) { GAA[i].SetTextColor(Color.LightGray); }
      for (int i = 8; i < 40; i++) { GAA[i].SetTextColor(Color.DeepSkyBlue); }
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
      // GAA[i].SetTextColor(Color.Argb(100, 100, 100, 100));
    }
    private void AFAB()
    {
      A304.Text = "B2";
      FCA = [
        "√()", "","Ʃ()", "", "∏()", "", "ʃ()", "",
        "", "lim","", "log", "", "ln", "", "exp",
        "cos", "", "sin", "", "tan", "", "cot", "",
        "", "acos", "", "asin", "", "atan", "", "acot"];
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.DeepSkyBlue);
      }
      AEBB(FCA);
      A438.SetBackgroundColor(Android.Graphics.Color.White);
      A447.SetBackgroundColor(Android.Graphics.Color.White);
      A448.SetBackgroundColor(Android.Graphics.Color.White);
    }
    private void AFAC()
    {
      A304.Text = "B3";
      FCA = ["a", "b", "c", "d", "e", "f", "g", "h",
        "i", "j", "k", "l", "m", "n", "o", "p",
        "q", "r", "s", "t", "u", "v", "w", "  ",
        "x", "y", "z", "_", "🌐", "GB", "", " "];
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.Gray);
      }
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
      A446.SetTextColor(Color.Aquamarine); AEBB(FCA);
    }
    private void AFAD()
    {
      A304.Text = "B4";
      FCA = ["A", "B", "C", "D", "E", "F", "G", "H",
        "I", "J", "K", "L", "M", "N", "O", "P",
        "Q", "R", "S", "T", "U", "F", "W", "  ",
        "X", "Y", "Z", "_", "🌐", "GB", "", " "];
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.Gray);
      }
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
      A446.SetTextColor(Color.Aquamarine); AEBB(FCA);
    }
    private void AFAE()
    {
      A304.Text = "B5";
      FCA = [
        "ä", "а́", "ã", "å", "ā", "â", "à", "æ",
        "é", "ё", "є", "ї", "и́", "ñ", "ń", "ö",
        "о́", "ѳ", "š", "ś", "ç", "ü", "ý", "  ",
        "ъ", "ы́", "э́", "ю́", "я́", "$", "", " "];
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.SeaGreen);
      }
      AEBB(FCA);
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
    }
    private void AFAF()
    {
      A304.Text = "B6";
      FCA = [
        "Ä", "Á", "Ã", "Å", "Ā", "Â", "À", "Æ",
        "É", "Ё", "Є", "Ї", "И́", "Ñ", "Ń", "Ö",
        "Ó", "Ѳ", "Š", "Ś", "Ç", "Ü", "У́", "  ",
        "Ъ", "Ы́", "Э́", "Ю́", "Я́", "€", "", " "];
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.SeaGreen);
      }
      AEBB(FCA);
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
    }
    private void AFAG()
    {
      A304.Text = "B7";
      FCA = [
        " ± ", " < ", " > ", "~", "%", "∂", ".", "#",
        " ≠ ", " ≤ ", " ≥ ", "≈", "°", "θ", ",", "&",
        " ≡ ", " << ", " >> ", "÷", "×", "ϕ", "→", "  ",
        "₪", "○", "□", "@", "µ", "λ", "", " "]; //
      for (int i = 8; i < 40; i++)
      {
        GAA[i].SetTextColor(Color.DarkOrchid);
      }
      AEBB(FCA);
      A438.Background = GetDrawable(Resource.Drawable.a_b_a_a_a);
      A447.Background = GetDrawable(Resource.Drawable.a_b_a_a_b);
      A448.Background = GetDrawable(Resource.Drawable.a_b_a_a_c);
    }
    private void AFAH()
    {
      A304.Text = "B8";
      FCA = [
        "✨", "🌍", "☀️", "⛈️", "❄️", "🏠", "🌳", "🌺",
        "🏍", "🚗", "🚚", "🚆", "🚢", "🚁", "🛫", "🚀",
        "🍧", "🧁", "🍎", "🍇", "🍓", "🍌", "🍀", "🍁",
        "💎", "🕒", "📏", "✏️", "📃", "📒", "📊", "💰"];
      AEBB(FCA);
      A438.SetBackgroundColor(Android.Graphics.Color.White);
      A447.SetBackgroundColor(Android.Graphics.Color.White);
      A448.SetBackgroundColor(Android.Graphics.Color.White);
    }
    #endregion
    #endregion
    // * BBBB * BBBB * BBBB * BBBB *
    #region BBBB

    #endregion
    // * CCCC * CCCC * CCCC * CCCC *
    #region CCCC

    #endregion
    // * DDDD * DDDD * DDDD * DDDD *
    #region DDDD
    #region D-AA
    private void DAAA()
    {
      if (A101.Text!.Length > 1)
      {
        if (A101.Text[..2] == Resources!.GetText(Resource.String.A023) |
              A101.Text[..2] == Resources!.GetText(Resource.String.A024))
        {
          string[] aa; aa = A101.Text.Split(":"); CAB = aa[1];
        }
        else
        {
          if (A101.Text != Resources!.GetString(Resource.String.A021) &
              A101.Text != Resources!.GetString(Resource.String.A022)) { return; }
        }
      }
      if (A102.Text != "" | A103.Text == "") { return; }
      CAA = A103.Text!; CAA = CAA.Replace("\n", ""); DAAB();
    }
    private void DAAB()
    {
      // Symbolen
      JAA.Clear(); JAB.Clear();
      JAC.Clear(); KAA.Clear();
      KAB.Clear(); KAC.Clear();
      KAD.Clear(); KAE.Clear();
      KAF.Clear(); KAH.Clear();
      KAI.Clear(); KAJ.Clear();
      KAK.Clear(); KAL.Clear();
      MAQ.Clear(); MAR.Clear();
      MAQ.Add(0); EAA = 0;
      // Symbolen !!! Reihenfolge
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("*", "·");
      CAA = CAA.Replace("/", ":");
      CAA = CAA.Replace("^", "˄");
      CAA = CAA.Replace("+∞", "▪");
      CAA = CAA.Replace("+", " + ");
      CAA = CAA.Replace("±", " ± ");
      CAA = CAA.Replace("∓", " ∓ ");
      CAA = CAA.Replace("·", " · ");
      CAA = CAA.Replace(":", " : ");
      CAA = CAA.Replace("˄", " ˄ ");
      CAA = CAA.Replace("˅", " ˅ ");
      CAA = CAA.Replace("˟", " ˟ ");
      CAA = CAA.Replace("'", " ' ");
      CAA = CAA.Replace("→", " → ");
      CAA = CAA.Replace("=", " = ");
      CAA = CAA.Replace("≠", " ≠ ");
      CAA = CAA.Replace("<", " < ");
      CAA = CAA.Replace(">", " > ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace("  ", " ");
      CAA = CAA.Replace(" ", " · ");
      CAA = CAA.Replace(" · + · ", " + ");
      CAA = CAA.Replace(" · ± · ", " ± ");
      CAA = CAA.Replace(" · ∓ · ", " ∓ ");
      CAA = CAA.Replace(" · - · ", " - ");
      CAA = CAA.Replace(" · · · ", " · ");
      CAA = CAA.Replace(" · : · ", " : ");
      CAA = CAA.Replace(" · ˄ · ", " ˄ ");
      CAA = CAA.Replace(" · ˅ · ", " ˅ ");
      CAA = CAA.Replace(" · ˟ · ", " ˟ ");
      CAA = CAA.Replace(" · = · ", " = ");
      CAA = CAA.Replace(" · ≠ · ", " ≠ ");
      CAA = CAA.Replace(" · < · ", " < ");
      CAA = CAA.Replace(" · > · ", " > ");
      CAA = CAA.Replace(" · ' · ", " ' ");
      CAA = CAA.Replace(" · → · ", " → ");
      CAA = CAA.Replace("▪", "+∞");
      CAA = CAA.Replace("( ", "(");
      CAA = CAA.Replace(" )", ")");
      CAA = CAA.Replace("--", "- -");
      CAA = CAA.TrimStart(' ');
      CAA = CAA.TrimEnd(' ');
      KAB.Add(GetString(Resource.String.A035) + "  : a = a");
      KAA.Add(CAA); DAAC();
    }
    private void DAAC()
    {
      while (EAA < KAA.Count)
      {
        // es gibt gar keine Varianten
        //DAAG(new HAA(DBAA));
        DAAH(new HAA(DBCA));
        // es gibt vielleicht Varianten

        // es gibt beistimmt Varianten
        DAAG(new HAA(DBXA));
        DAAE(); EAA += 1;
      }
      A301.Text = Resources!.GetText(Resource.String.A009); AEAE();
    }
    private void DAAD()
    {
      if (CAJ == CAA & KAA.Count > 1) { return; } else { CAJ = CAA; }
      ; KAH.Clear();
      KAI.Clear(); MAA.Clear(); MAB.Clear(); MAC.Clear(); MAD.Clear(); MAE.Clear();
      MAF.Clear(); MAG.Clear(); MAH.Clear(); MAI.Clear(); MAJ.Clear(); MAM.Clear();
      LAA.Clear(); IAA.Clear(); IAB.Clear(); B4 = -1; KAH.Add(CAA); KAI.Add("");
      MAE.Add(0); MAA.Add(0);
      // 1     Ausdruckteile
      do
      {
        // 1.1     Anweisungen, Deklaration
        B4 += 1; B5 = MAA[B4]; B6 = B5; B7 = KAH[B4]!.Length; B8 = B7; B3 = false; B2 = 0;
        C1.Clear(); C2.Clear(); C3.Clear(); C4.Clear(); C5.Clear(); C6.Clear(); C7.Clear();
        // 1.2     Funktionen
        if (CAA.Substring(B5, 1) != "-")
        {
          if (B7 > 1)
          {
            if (CAA.Substring(B5, 1) == "(") { B6 += 1; B8 -= 2; MAB.Add(1); }
            if (CAA.Substring(B5, 1) == "┃") { B6 += 1; B8 -= 2; MAB.Add(2); }
          }
          if (B7 > 2)
          {
            if (CAA.Substring(B5, 2) == "√(") { B6 += 2; B8 -= 3; MAB.Add(3); }
            if (CAA.Substring(B5, 2) == "d(") { B6 += 2; B8 -= 3; MAB.Add(4); }
            if (CAA.Substring(B5, 2) == "ʃ(") { B6 += 2; B8 -= 3; MAB.Add(5); }
            if (CAA.Substring(B5, 2) == "Ʃ(") { B6 += 2; B8 -= 3; MAB.Add(6); }
            if (CAA.Substring(B5, 2) == "∏(") { B6 += 2; B8 -= 3; MAB.Add(7); }
          }
          if (B7 > 4)
          {
            if (CAA.Substring(B5, 3) == "ln(") { B6 += 3; B8 -= 4; MAB.Add(8); }
            if (CAA.Substring(B5, 4) == "log(") { B6 += 4; B8 -= 5; MAB.Add(9); }
            if (CAA.Substring(B5, 4) == "lim(") { B6 += 4; B8 -= 5; MAB.Add(10); }
            if (CAA.Substring(B5, 4) == "cos(") { B6 += 4; B8 -= 5; MAB.Add(11); }
            if (CAA.Substring(B5, 4) == "sin(") { B6 += 4; B8 -= 5; MAB.Add(12); }
            if (CAA.Substring(B5, 4) == "tan(") { B6 += 4; B8 -= 5; MAB.Add(13); }
            if (CAA.Substring(B5, 4) == "cot(") { B6 += 4; B8 -= 5; MAB.Add(14); }
          }
          if (B7 > 6)
          {
            if (CAA.Substring(B5, 5) == "acos(") { B6 += 5; B8 -= 6; MAB.Add(15); }
            if (CAA.Substring(B5, 5) == "asin(") { B6 += 5; B8 -= 6; MAB.Add(16); }
            if (CAA.Substring(B5, 5) == "atan(") { B6 += 5; B8 -= 6; MAB.Add(17); }
            if (CAA.Substring(B5, 5) == "acot(") { B6 += 5; B8 -= 6; MAB.Add(18); }
          }
        }
        if (CAA.Substring(B5, 1) == "-")
        {
          if (B7 > 2)
          {
            if (CAA.Substring(B5, 2) == "-(") { B6 += 2; B8 -= 3; MAB.Add(1); }
            if (CAA.Substring(B5, 2) == "-┃") { B6 += 2; B8 -= 3; MAB.Add(2); }
          }
          if (B7 > 4)
          {
            if (CAA.Substring(B5, 3) == "-√(") { B6 += 3; B8 -= 4; MAB.Add(3); }
            if (CAA.Substring(B5, 3) == "-d(") { B6 += 3; B8 -= 4; MAB.Add(4); }
            if (CAA.Substring(B5, 3) == "-ʃ(") { B6 += 3; B8 -= 4; MAB.Add(5); }
            if (CAA.Substring(B5, 3) == "-Ʃ(") { B6 += 3; B8 -= 4; MAB.Add(6); }
            if (CAA.Substring(B5, 3) == "-∏(") { B6 += 3; B8 -= 4; MAB.Add(7); }
            if (CAA.Substring(B5, 4) == "-ln(") { B6 += 4; B8 -= 5; MAB.Add(8); }
          }
          if (B7 > 6)
          {
            if (CAA.Substring(B5, 5) == "-log(") { B6 += 5; B8 -= 6; MAB.Add(9); }
            if (CAA.Substring(B5, 5) == "-lim(") { B6 += 5; B8 -= 6; MAB.Add(10); }
            if (CAA.Substring(B5, 5) == "-cos(") { B6 += 5; B8 -= 6; MAB.Add(11); }
            if (CAA.Substring(B5, 5) == "-sin(") { B6 += 5; B8 -= 6; MAB.Add(12); }
            if (CAA.Substring(B5, 5) == "-tan(") { B6 += 5; B8 -= 6; MAB.Add(13); }
            if (CAA.Substring(B5, 5) == "-cot(") { B6 += 5; B8 -= 6; MAB.Add(14); }
            if (CAA.Substring(B5, 6) == "-acos(") { B6 += 6; B8 -= 7; MAB.Add(15); }
            if (CAA.Substring(B5, 6) == "-asin(") { B6 += 6; B8 -= 7; MAB.Add(16); }
            if (CAA.Substring(B5, 6) == "-atan(") { B6 += 6; B8 -= 7; MAB.Add(17); }
            if (CAA.Substring(B5, 6) == "-acot(") { B6 += 6; B8 -= 7; MAB.Add(18); }
          }
        }
        // 1.3     Funktionsgültigkeit
        if (B5 < B6) { B2 = 1; B3 = true; }
        switch (CAA.Substring(B6, 1))
        {
          case "(": B2 += 1; break;
          case "┃": B2 += 1; break;
        }
        // 1.4     Operatoren
        if (B8 > 1) // wenn bb = true dann B8 > 1
        {
          for (int i = B6; i < B6 + B8 - 1; i += 1)
          {
            switch (CAA.Substring(i, 1))
            {
              case "(": B2 += 1; break;
              case ")": B2 -= 1; break;
              case "┃": B2 += 1; break;
              case "│": B2 -= 1; break;
            }
            if (B2 == 0)
            {
              switch (CAA.Substring(i, 2))
              {
                case "' ": C1.Add(i); break;
                case "→ ": C2.Add(i); break;
                case "= ": C3.Add(i); break;
                case "≠ ": C3.Add(i); break;
                case "< ": C3.Add(i); break;
                case "> ": C3.Add(i); break;
                case "+ ": C4.Add(i); break;
                case "± ": C4.Add(i); break;
                case "∓ ": C4.Add(i); break;
                case "- ": C4.Add(i); break;
                case "· ": C5.Add(i); break;
                case ": ": C5.Add(i); break;
                case "˄ ": C6.Add(i); break;
                case "˅ ": C6.Add(i); break;
                case "˟ ": C6.Add(i); break;
              }

              // KAB zurücksetzen bei Funktionen f(1) o f(2)
              if (B3 == true) { MAB.RemoveAt(MAB.Count - 1); B3 = false; }
            }
          }
        }
        // 1.5     Operatorengruppenwahl
        if (C6.Count > 0) { B2 = 6; C7 = C6; }
        if (C5.Count > 0) { B2 = 5; C7 = C5; }
        if (C4.Count > 0) { B2 = 4; C7 = C4; }
        if (C3.Count > 0) { B2 = 3; C7 = C3; }
        if (C2.Count > 0) { B2 = 2; C7 = C2; }
        if (C1.Count > 0) { B2 = 1; C7 = C1; }
        // 1.6     Funktionslosigkeit
        if (B3 == false) { B6 = B5; B8 = B7; MAB.Add(0); }
        // 1.7
        if (C7.Count == 0)
        {
          if (B3 == true)
          {
            KAH.Add(CAA.Substring(B6, B8));
            KAI.Add(""); // Operator
            MAA.Add(B6); // Teilungsanfang
            MAE.Add(B4); // Quellenausdruck
            MAH.Add(1); // Ausgangsteilenanzahl
            MAI.Add(KAI.Count - 1); // Ausgangsteilenanfangsindex
          }
          else
          {
            MAH.Add(0); // Ausgangsteilenanzahl
            MAI.Add(B4); // Ausgangsteilenanfangsindex
          }
          MAC.Add(B5); // Eingangsanfang
          MAD.Add(B7); // Eingangslänge
          MAF.Add(B6); // Ausgangsanfang
          MAG.Add(B8); // Ausgangslänge
          IAB.Add(0); // Operatorengruppe
          if (double.TryParse(KAH[B4], out _) == true) { MAJ.Add(1); } else { MAJ.Add(0); } // Eingangsteil-Zahl
          if (KAH[B4] == CAB | KAH[B4] == "-" + CAB) { MAM.Add(1); } else { MAM.Add(0); } // Gesuchte Variable in Gleichung
        }
        //1.8  Reihenfolge !!!
        if (C7.Count > 0)
        {
          C7.Insert(0, B6); C7.Add(B6 + B8);
          MAJ.Add(0); MAM.Add(0); // HAK.Add(0); // betreffen nicht
          //1.8.1     Eigenschaften des Eingangsausdrucksubstrings
          MAC.Add(B5); // 5 Eingangsanfang
          MAD.Add(B7); // 6 Eingangslänge
          MAF.Add(B6); // 7 Ausgangsanfang
          MAG.Add(B8); // 8 Ausgangslänge
          IAB.Add(B2); // 9 Ausgangsoperatorengruppe
          MAH.Add(C7.Count - 1); // 10 Ausgangsteilenanzahl
          MAI.Add(KAI.Count); // 11 Ausgangsteilenanfangsindex
          //1.8.2     Ausgangsausdrucksubstringe
          for (int i = 1; i < C7.Count; i++)
          {
            if (i == 1)
            {
              KAH.Add(CAA.Substring(B6, C7[i] - B6 - 1));
              KAI.Add(""); // 1 Operator
              MAE.Add(B4); // 2 Quellenausdruck
              MAA.Add(B6); // 3 Teilungsanfang
            }
            if (i > 1 & i < C7.Count - 1)
            {
              KAH.Add(CAA.Substring(C7[i - 1] + 2, C7[i] - C7[i - 1] - 3));
              KAI.Add(CAA.Substring(C7[i - 1], 1)); // 1 Operator
              MAE.Add(B4); // 2 Quellenausdruck
              MAA.Add(C7[i - 1] + 2); // 3 Teilungsanfang
            }
            if (i == C7.Count - 1)
            {
              KAH.Add(CAA.Substring(C7[i - 1] + 2, C7[i] - C7[i - 1] - 2));
              KAI.Add(CAA.Substring(C7[i - 1], 1)); //1 Operator
              MAE.Add(B4); // 2 Quellenausdruck
              MAA.Add(C7[i - 1] + 2); // 3 Teilungsanfang
            }
          }
        }
        //1.9     Gemeinsame Eigenschaften auch wenn: aacab[1] = false & aacab[2] = false
        if (CAA.Substring(B5, 1) == "-") { IAA.Add(2); } else { IAA.Add(0); } // Vorzeichen vor Eingangsteiles
        LAA.Add(false); //17 Gesuchte Variable in Gleichung im Nenner (Hinzufügen False ohne Bedingungen)
                        // 1.10    Ende der Schleife
        if (B4 == KAH.Count - 1) { break; }
      }
      while (B4 < KAH.Count);
      //2     Eigenschaftenkorrektur
      for (int i = 0; i < KAH.Count; i++)
      {
        //Vorzeichen
        if (IAB[i] == 6)
        {
          if (IAA[i] == 0) { IAA[i] = 1; } else { if (IAA[i] == 2) { IAA[i] = 3; } }
          if (IAB[MAE[i]] == 5 & i == MAI[MAE[i]]) { IAA[MAE[i]] = IAA[i]; }
          // wenn Operatorengruppe 6 in Anfangsposition bei Operatorengruppe 5
        }
        //Gesuchte Variable
        if (MAM[i] == 1)
        {
          int am, an; am = i; an = 1;
          do { an += 1; MAM[MAE[am]] += an; am = MAE[am]; } while (am > 0);
          if (KAI[i] == ":") { am = i; do { LAA[MAE[am]] = true; am = MAE[am]; } while (am > 0); }
          if (KAI[MAE[i]] == ":" & IAB[MAE[i]] == 6) { am = i; do { LAA[MAE[am]] = true; am = MAE[am]; } while (am > 0); }
        }
      }
    }
    private void DAAE()
    {
      string aa; string[] ab;
      if (KAC.Count > 0)
      {
        for (int i = 0; i < KAC.Count; i++)
        {
          KAA.Insert(EAA + i + 1, KAC[i]!); ab = KAB[EAA]!.Split(":");
          aa = ab[0][..^1] + "." + (i + 1).ToString() + " : " + KAD[i];
          if (EAA == 0) // .Remove(ab[0].Length - 1, 1)
          {
            aa = aa.Replace(Resources!.GetText(Resource.String.A035) +
                " .", Resources.GetText(Resource.String.A035) + " ");
          }
          KAB.Insert(EAA + i + 1, aa); KAL.Add("\n" + "\n" + aa); JAC.Add(Color.Blue);
          for (int j = 0; j < MAR[i]; j++) { KAL.Add(KAK[j]!); JAC.Add(JAB[j]); }
          for (int j = 0; j < MAR[i]; j++) { KAK.RemoveAt(0); JAB.RemoveAt(0); }
        }
      }
      MAR.Clear(); KAC.Clear(); KAD.Clear();
    }
    private void DAAF()
    {
      //Prüfen, ob der Ergebnis schon in der Liste ist
      DAC = true;
      if (KAA.Count > 1)
      { for (int i = 0; i < KAA.Count; i++) { if (KAA[i] == CAA) { DAC = false; break; } } }
      if (KAA.Count > 1)
      { for (int i = 0; i < KAC.Count; i++) { if (KAC[i] == CAA) { DAC = false; break; } } }
      if (DAC == true) { KAE.Add(CAA); KAF.Add(CAC); } else { CAA = KAH[0]!; }
    }
    private void DAAG(HAA b)
    {
      CAA = KAA[EAA]!.Replace(Resources!.GetText(Resource.String.A041), Resources.GetText(Resource.String.A042));
      KAE.Clear(); KAF.Clear(); DAAD(); DAC = true; b();
      if (KAE.Count > 0 & DAC == true)
      {
        for (int i = 0; i < KAJ.Count; i++) { KAK.Add(KAJ[i]!); JAB.Add(JAA[i]); }
        MAR.Add(KAJ.Count); KAC.Add(KAE[0]!); KAD.Add(CAC);
      }
      else { DAC = false; }
      ; KAJ.Clear(); JAA.Clear();
    }
    private void DAAH(HAA b)
    {
      int aa = 0; KAE.Clear(); KAJ.Clear(); JAA.Clear(); KAF.Clear(); KAE.Add(KAA[EAA]!); KAF.Add("a = b");
      while (aa < KAE.Count)
      {
        CAA = KAE[aa]!.Replace(Resources!.GetText(Resource.String.A041), Resources.GetText(Resource.String.A042));
        DAAD(); b(); if (CAA != KAE[aa]) { KAE.Add(CAA); KAF.Add(CAC); aa += 1; } else { KAF.Add(CAC); break; }
      }
      DAC = false; if (KAE.Count > 1) { DAAF(); }
      if (DAC == true)
      {
        for (int i = 0; i < KAJ.Count; i++) { KAK.Add(KAJ[i]!); JAB.Add(JAA[i]); }
        MAR.Add(KAJ.Count); KAC.Add(KAE[KAE.Count - 1]!); KAD.Add(KAF[KAF.Count - 1]!);
      }
      KAJ.Clear(); JAA.Clear();
    }
    #endregion
    #region D-AB
    private void DBAA()
    {
      if (IAB[0] == 3 & MAH[0] == 2) // Operatorengruppe ist 3 <=> und es gibt nur 2 Seiten linke und rechte
      {
        int ea;
        if (MAM[2] > 1) // Rechte Seite enthält eine Gesuchte
        {
          if (MAM[2] == MAM[MAI[2]] + 1) // Nur erster Term in der rechten Seite enthält oder ist eine Gesuchte
          {
            // a = b +- c => a - b = +- c
            if (IAB[2] == 4) // Operatorengruppe der rechten Seite ist 4: +-
            {
              // a = b + c => a - b = c
              if (KAI[MAI[2] + 1] == "+") // Zweiter Operator der rechten Seite ist +
              {
                DCBB(" - " + KAH[MAI[2]], MAC[MAI[2]], MAD[MAI[2]] + 3, MAC[2] - 3);
                CAC = "a = b + c => a - b = c"; DDED("a = `b + `c` => `a` - b` = c"); return;
              }
              // a = b - c => a - b = 0 - c
              if (KAI[MAI[2] + 1] == "-") // Zweiter Operator der rechten Seite ist -
              {
                DCCA([" - " + KAH[MAI[2]], "0"], MAC[MAI[2]], MAD[MAI[2]], MAC[2] - 3, MAC[2]);
                CAC = "a = b - c => a - b = 0 - c"; DDEF("a = `b` - c` => `a` - b` = `0` - c"); 
                return;
              }
            }
            // a = x ° b => a - x ° b = 0
            if (IAB[2] > 4) //  Operatorengruppe der rechten Seite ist größer als 4: ·: ˄˅
            {
              // a = x ° b => x ° b = a
              if (MAM[1] == 0) // Linke Seite enthält oder ist keine Gesuchte
              {
                DCBB(KAH[2] + " = ", MAC[2] - 3, MAD[2] + 3, MAC[1]);
                CAC = "a = b => b = a"; DDCA("a` = b` => `b = `a"); return;
              }
              // x = x ° b => x - x ° b = 0
              if (MAM[1] > 0) // Linke Seite enthält oder ist eine Gesuchte
              {
                DCCA([" - " + KAH[2], "0"], MAC[2], MAD[2], MAC[2] - 3, MAC[2]);
                CAC = "a = b => a - b = 0"; DDCC("a = `b` => `a` - b` = `0");
                return;
              }
            }
          }
          if (MAM[2] > MAM[MAI[2]] + 1) // Nicht nur erster Term der rechten Seite enthält oder ist eine Gesuchte
          {
            // a = b +- c => a -+ c = b
            if (IAB[2] == 4) // Operatorengruppe der rechten Seite: +-
            {
              ea = 0; CAC = "a = b +- c => a -+ c = b";
              for (int i = MAI[2] + MAH[2] - 1; i > MAI[2]; i -= 1) // rechts von letzten Term bis zweiten Term
              {
                if (MAM[i] > 0) // Gesuchte im Nenner machen sowieso keinen Nenner für ganze linke Seite
                {
                  if (KAI[i] == "+")
                  {
                    DCBB(" - " + KAH[i], MAC[i] + ea - 3, MAD[i] + 3, MAC[2] - 3);
                    DDCB("a = b` + c` => `a` - c` = b"); ea += MAD[i] + 3;
                  }
                  if (KAI[i] == "-")
                  {
                    DCBB(" + " + KAH[i], MAC[i] + ea - 3, MAD[i] + 3, MAC[2] - 3);
                    DDCB("a = b` - c` => `a` + c` = b"); ea += MAD[i] + 3;
                  }
                }
              }
              if (ea > 0) { return; }
            }
            // a = b ·: c => a :· c = b
            if (IAB[2] == 5)
            {
              ea = 0; CAC = "a = b : c => a · c = b";
              // a ± b = c ·: d => (a ± b) :· d = c
              if (IAB[1] == 4)
              { // a ± b = c ·: d ·: d => (a ± b) :· d :· d = c
                for (int i = MAI[2] + MAH[2] - 1; i > MAI[2]; i -= 1) // rechts von letzten Term bis zweiten Term
                {
                  if (LAA[i] == false & KAI[i] == ":") // Gesuchte-Nenner machen keinen Nenner für ganze linke Seite
                  {
                    if (ea > 0)
                    {
                      DCBB(" · " + KAH[i], MAC[i] + ea - 1, MAD[i] + 3, MAC[2] - 1);
                      DDCB("a = b` : c` => `a` · c` = b");
                    }
                    else
                    {
                      DCCA(["(", ") · " + KAH[i]], MAC[i] - 3, MAD[i] + 3, MAC[1], MAC[2] - 3);
                      DDCD("a ± b = c` : d` => `(`a ± b`) · d` = c");
                    }
                    ea += MAD[i] + 3;
                  }
                }
              }
              // a = b ·: c => a :· c = b
              if (IAB[1] != 4)
              { // a = b ·: c ·: c => a :· c :· c = b
                for (int i = MAI[2] + MAH[2] - 1; i > MAI[2]; i -= 1) // rechts von letzten Term bis zweiten Term
                {
                  if (LAA[i] == false & KAI[i] == ":") // Gesuchte-Nenner machen keinen Nenner für ganze linke Seite
                  {
                    DCBB(" · " + KAH[i], MAC[i] + ea - 3, MAD[i] + 3, MAC[2] - 3);
                    DDCB("a = b` : c` => `a` · c` = b"); ea += MAD[i] + 3;
                  }
                }
              }
              // a => b
              if (ea > 0) { return; }
            }
            // a = b ° x => b ° x = a
            if (IAB[2] > 4)
            {
              // a = b ° x => b ° x = a
              if (MAM[1] == 0)
              {
                DCBB(KAH[2] + " = ", MAC[2] - 3, MAD[2] + 3, MAC[1]);
                CAC = "a = b => b = a"; DDCA("a` = b` => `b = `a"); return;
              }
              // x = b ° x => x - b ° x = 0
              if (MAM[1] > 0)
              {
                DCCA([" - " + KAH[2]], MAC[2], MAD[2], MAC[2] - 3, MAC[2]);
                CAC = "a = b => a - b = 0"; DDCC("a = `b` => `a` - b` = `0"); 
                return;
              }
            }
          }
        }
        if (MAM[2] == 1) // Rechte Seite ist eine Gesuchte
        {
          // a = b => b = a
          if (MAM[1] == 0)
          {
            DCBB(KAH[2] + " = ", MAC[2] - 3, MAD[2] + 3, MAC[1]);
            CAC = "a = b => b = a"; DDCA("a` = b` => `b = `a"); return;
          }
          // a = b => a - b = 0
          if (MAM[1] > 0)
          {
            if (MAJ[2] == 0) // ← Gesuchte ist keine Zahl, wenn rechte Seite auch eine enthält
            {
              DCCA([" - " + KAH[2], "0"], MAC[2], MAD[2], MAC[2] - 3, MAC[2]);
              CAC = "a = b => a - b = 0"; DDCC("a = `b` => `a` - b` = `0"); return;
            }
          }
        }
        if (MAM[2] == 0) // Rechte Seite enthält keine Gesuchte
        {
          bool au, ua; au = false; ua = false;
          if (MAM[MAI[1]] == 0) { au = true; }
          if (MAH[1] > 1) // bei mehr als einen Term in rechter Seite
          {
            for (int i = MAI[1] + 1; i < MAI[1] + MAH[1]; i++)
            {
              if (MAM[i] == 0) { ua = true; break; } // Nicht-Gesuchte
            }
          }
          if (ua == true)
          {
            // a +- b = c => a = c -+ b
            if (IAB[1] == 4)
            {
              bool ab = false; CAC = "a +- b = c => a = c -+ b";
              for (int i = MAI[1] + MAH[1] - 1; i > MAI[1]; i -= 1) // links von letzten Term bis zweiten Term
              {
                if (MAM[i] == 0)
                {
                  if (KAI[i] == "+")
                  {
                    DCBB(" - " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                    DDEB("a` + b` = c` => `a = c` - b"); ab = true;
                  }
                  if (KAI[i] == "-")
                  {
                    DCBB(" + " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                    DDEB("a` - b` = c` => `a = c` + b"); ab = true;
                  }
                }
              }
              if (ab == true) { return; }
            }
            // a ·: b = c => a = c :· b
            if (IAB[1] == 5)
            {
              bool ab = false; CAC = "a ·: b = c => a = c :· b";
              // a ·: b ·: c = d + e => a = (d ± e) :· b :· c
              if (IAB[2] == 4)
              {
                for (int i = MAI[1] + MAH[1] - 1; i > MAI[1]; i -= 1) // links von letzten Term bis zweiten Term
                {
                  if (MAM[i] == 0 | KAI[i] == ":") // auch Gesuchte mit Operator ":" nach rechts umstellen
                  {
                    if (ab == true) // a ·: c = (d ± e) :· b => a = (d ± e) :· b :· c
                    {
                      if (KAI[i] == "·")
                      {
                        DCBB(" : " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                        DDEB("a` · b` = c` => `a = c` : b");
                      }
                      if (KAI[i] == ":")
                      {
                        DCBB(" · " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                        DDEB("a` : b` = c` => `a = c` · b");
                      }
                    }
                    else
                    {
                      if (KAI[i] == "·")
                      {
                        DCCA(["(", ") : " + KAH[i],], MAC[i] - 3, MAD[i] + 3, 
                            MAC[2] - MAD[i] - 3, CAA.Length - MAD[i] - 3);
                        ab = true; DDEE("a` · b` = c ± d` => `a = `(`c ± d`) : b");
                      }
                      else
                      {
                        DCCA(["(", ") · " + KAH[i],], MAC[i] - 3,
                            MAD[i] + 3, MAC[2] - MAD[i] - 3, CAA.Length - MAD[i] - 3);
                        ab = true; DDEE("a` : b` = c ± d` => `a = `(`c ± d`) · b");
                      }
                    }
                  }
                }
              }
              // a ·: b ·: c = d => a = d :· b :· c
              if (IAB[2] != 4)
              {
                for (int i = MAI[1] + MAH[1] - 1; i > MAI[1]; i -= 1) // links von letzten Term bis zweiten Term
                {
                  if (MAM[i] == 0 | KAI[i] == ":") // auch Gesuchte mit Operator ":" nach rechts umstellen
                  {
                    if (KAI[i] == "·")
                    {
                      DCBB(" : " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                      DDEB("a` · b` = c` => `a = c` : b"); ab = true;
                    }
                    if (KAI[i] == ":")
                    {
                      DCBB(" · " + KAH[i], MAC[i] - 3, MAD[i] + 3, CAA.Length - MAD[i] - 3);
                      DDEB("a` : b` = c` => `a = c` · b"); ab = true;
                    }
                  }
                }
              }
              // a => b
              if (ab == true) { return; }
            }

            //return;

            // a ˄˅ b = c => a = c ˅˄ b
            if (IAB[1] == 6)
            {
              //if (MAM[1] > 0)
              //{
              //    string ab = KAH[1]; CAC = "a ^ b = c => a = √(c ' b)";
              //    for (int i = MAI[1] + MAH[1] - 1; i < MAI[1] + 2; i -= 1)
              //    {
              //        if (MAM[i] == 0) { CAA = CAA.Insert(CAA.Length, " · " + KAH[i]); ab = ab.Remove(MAC[i] - 3, MAD[i] + 3); }
              //    }
              //    if (KAH[0] != CAA)
              //    {
              //        CAA = CAA.Insert(CAA.Length, ")"); CAA = CAA.Remove(KAH[0].Length + 1, 1);
              //        CAA = CAA.Insert(KAH[0].Length + 1, "'"); CAA = CAA.Insert(MAC[2], "√("); CAA = CAA.Remove(MAC[1], MAD[1]);
              //        CAA = CAA.Insert(MAC[1], ab); DAAF();

              //        //if (DAC == true) { DEAA(KAH[0], CAC.Substring(0, 9), CAC.Substring(13, 9)); return; }

              //        //If DAC = True Then
              //        //    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(DAA & vbLf) : DAAK(NBA.GetString("S040"))
              //        //    DAAI("a ^ b = c") : DAAK(" => ") : DAAJ("a = √(c ' b)" & vbLf) : Exit Sub
              //        //End If
              //    }
              //}
            }
            // √(a ' b) = c => a = c ^ b
            if (MAB[1] == 3)
            {
              //        If KAB(1) = 5 Or KAB(1) = 14 Then

              //            If MAM(KAI(1)) > 0 Then: DAC = "√(a ' b) = c => a = c ^ b"

              //                If KAB(1) = 5 Then

              //                    If IAB(2) = 4 Or IAB(2) = 6 Then

              //                        DAA = DAA.Insert(DAA.Length, ")") : DAA = DAA.Insert(KAC(2), "(")
              //                    End If
              //                Else
              //                    If KAB(2) > 0 Or IAB(2) = 0 Or IAB(2) = 5 Then

              //                        DAA = DAA.Insert(KAC(2), "-") : DAA = DAA.Replace("--", "")
              //                    Else
              //                        DAA = DAA.Insert(DAA.Length, ")") : DAA = DAA.Insert(KAC(2), "-(")
              //                    End If
              //                End If
              //                If IAB(1) = 1 Then

              //                    If KAH(KAI(1) + 1) < 2 Then DAA = DAA.Insert(DAA.Length, " ^ " & KAH(KAI(1) + 1))

              //                    If KAH(KAI(1) +1) > 1 Then DAA = DAA.Insert(DAA.Length, " ^ (" & KAH(KAI(1) + 1) & ")")
              //                Else
              //                    DAA = DAA.Insert(DAA.Length, " ^ 2") : DAC = "√(a) = b => a = b ^ 2"
              //                End If
              //                DAA = DAA.Remove(0, KAD(1))

              //                DAA = DAA.Insert(0, KAH(KAI(1)))

              //                DAAF()

              //                'If DAC = True Then

              //                '    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(DAA & vbLf) : DAAK(NBA.GetString("S040"))

              //                '    If IAB(1) <> 1 Then DAAI("√(a) = b") : DAAK(" => ") : DAAJ("a = b ^ 2" & vbLf)

              //                '    If IAB(1) = 1 Then DAAI("√(a ' b) = c") : DAAK(" => ") : DAAJ("a = c ^ b" & vbLf)

              //                '    Exit Sub
              //                'End If
              //            End If
              //        End If

            }
          }
          if (au == true)
          {
            if (IAB[1] == 4 | IAB[1] == 5)
            {
              // a +· b = c => b = c -: a
              if (KAI[MAI[1] + 1] == "+" | KAI[MAI[1] + 1] == "·")
              {
                if (IAB[1] == 5 & IAB[2] == 4) { CAA = KAH[0]!.Insert(MAC[2], "("); CAA += ")"; }
                CAA = CAA.Remove(MAC[MAI[1]], MAD[MAI[1]] + 3);
                if (IAB[1] == 4) { CAA += " - " + KAH[MAI[1]]; CAC = "a + b = c => b = c - a"; }
                if (IAB[1] == 5) { CAA += " : " + KAH[MAI[1]]; CAC = "a · b = c => b = c : a"; }
                ; DAAF();
                if (DAC == true) { return; }
              }
              // a -: b = c => b = a -: c
              if (KAI[MAI[1] + 1] == "-" | KAI[MAI[1] + 1] == ":")
              {
                //string ab, ac; ab = "";
                //if (IAB[1] >= IAB[2] & IAB[2] > 0) { CAA = KAH[0].Insert(MAC[2], "("); CAA += ")"; }
                //CAA = CAA.Insert(MAC[2], KAH[MAI[1]] + " " + KAI[MAI[1] + 1] + " ");
                //CAA = CAA.Remove(MAC[1], MAD[1]); ac = ab + KAH[MAI[1] + 1];
                //if (IAB[1] == 4) { CAC = "a - b = c => b = a - c"; } else { CAC = "a : b = c => b = a : c"; }
                //if (MAH[1] > 2)
                //{
                //    for (int i = MAI[1] + 2; i < MAI[1] + MAH[1]; i++)
                //    {
                //        // a - b +- q = c => b -+ q = a - c
                //        if (KAI[i] == "+") { ab = " - "; } else { if (KAI[i] == "-") { ab = " + "; } }
                //        // a : b ·: q = c => b :· q = a : c
                //        if (KAI[i] == "·") { ab = " : "; } else { if (KAI[i] == ":") { ab = " · "; } }
                //        ac += ab + KAH[i];
                //    }
                //}
                //CAA = ac + CAA; DAAF();
                //if (DAC == true) { DEAA(aa, CAC.Substring(0, 9), CAC.Substring(13, 9)); return; }
              }
            }
            if (IAB[1] == 6 & MAM[1] > 0)
            {
              if (MAH[1] == 2 & MAM[MAI[1] + 1] > 0)
              {
                CAC = "a ^ b = c => b = ln(c) : ln(a)"; CAA = CAA.Insert(MAC[2], "ln(");
                CAA = CAA.Insert(CAA.Length, ") : ln(" + KAH[MAI[1]] + ")");
                CAA = CAA.Remove(MAC[MAI[1]], MAD[MAI[1]] + 3); DAAF();
                //if (DAC == true) { DEAA(KAH[0], CAC.Substring(0, 9), CAC.Substring(13, 9)); return; }

                //                    'If DAC = True Then
                //                    '    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(DAA & vbLf) : DAAK(NBA.GetString("S040"))
                //                    '    DAAI("a ^ b = c") : DAAK(" => ") : DAAJ("b = ln(c) : ln(a)" & vbLf) : Exit Sub
                //                    'End If
              }
            }
          }

          //        If MAM(1) = 1 And LAA(1) = 1 Then

          //            DAC = "-a = b => a = -b" ' ! -a < b => a > -b !

          //            If KAI(2) = "<" Then DAA = DAA.Remove(KAC(2) - 2, 1) : DAA = DAA.Insert(KAC(2) - 2, ">") : DAC = "-a < b => a > -b"

          //            If KAI(2) = ">" Then DAA = DAA.Remove(KAC(2) - 2, 1) : DAA = DAA.Insert(KAC(2) - 2, "<") : DAC = "-a > b => a < -b"

          //            If IAB(2) = 4 Or IAB(2) = 6 Then: DAA = DAA.Insert(KAC(2), "(") : DAA &= ")" : End If : If IAB(2) = 5 Then

          //               If IAB(KAI(2)) = 6 Then DAA = DAA.Insert(KAC(2), "(") : DAA = DAA.Insert(KAC(KAI(2) + 1) - 2, ")")
          //            End If
          //            DAA = DAA.Insert(KAC(2), "-") : DAA = DAA.Replace("--", "") : DAA = DAA.TrimStart("-") : DAAF()

          //            'If DAC = True Then

          //            '    DAAI(vbLf & KAH(0) & vbLf) : DAAJ(DAA & vbLf) : DAAK(NBA.GetString("S040"))

          //            '    DAAI(DAC.Substring(0, 6)) : DAAK(" => ") : DAAJ(DAC.Substring(10, 6) & vbLf) : Exit Sub
          //            'End If
          //        End If


          //        If IAB(1) = 4 And KAH(1) = 2 And MAM(1) > 4 Then
          //            'a b ^ 2 + c b + d = 0
          //            Dim ae, af, ag, ah, ai, aj, ak, al As String : Dim am, an As Integer

          //            ae = "" : af = "" : ag = "" : ah = "" : ai = "" : aj = "" : ak = "" : al = "" : am = 1 : an = -1

          //            For i = 0 To 1 Step 1

          //                If IAB(KAI(1) +i) = 5 Then

          //                   For j = KAI(KAI(1) + i) To KAI(KAI(1) +i) +KAH(KAI(1) + i) - 1 Step 1

          //                        If KAI(j) <> ":" Then

          //                            If MAM(KAI(1) + i) = 2 Then If KAH(j) = CAB Or KAH(j) = "-" & CAB Then ae &= "1"

          //                            If MAM(KAI(1) +i) = 3 Then

          //                               If KAH(j) = CAB & " ^ 2" Or KAH(j) = "-" & CAB & " ^ 2" Or KAH(j) = "-(" & CAB & " ^ 2)" Then

          //                                   ae &= "2" : End If
          //                            End If
          //                            If ae.Length = 1 + i Then

          //                                If j = KAI(KAI(1) + i) Then

          //                                    aj = KAH(KAI(1) + i).Remove(KAC(j) - KAC(KAI(1) + i), KAD(j) + 3)

          //                                    ak = KAH(2) : If LAA(2) = 1 Then ak = ak.TrimStart("-")

          //                                    If IAB(2) = 4 Then ak = " · (" & ak & ")" Else ak = " · " & ak

          //                                    If KAI(j +i) = ":" Then aj = aj.Insert(KAC(j) - KAC(KAI(1) + i), "1 : ")
          //                                End If
          //                                If j > KAI(KAI(1) + i) Then

          //                                    aj = KAH(KAI(1) + i).Remove(KAC(j) - KAC(KAI(1) + i) - 3, KAD(j) + 3)

          //                                    ak = KAH(2) : If LAA(2) = 1 Then ak = ak.TrimStart("-")

          //                                    If IAB(2) = 4 Then ak = " · (" & ak & ")" Else ak = " · " & ak

          //                                    If LAA(KAI(1) +i) = 1 Then aj = aj.TrimStart("-")
          //                                End If
          //                                If ae = "1" Or ae = "21" Then ag = aj : af = ag & " ^ 2"

          //                                If ae = "2" Or ae = "12" Then ah = "4 · " & aj & ak : ai = "2 : (" & aj & ")" : al = aj
          //                                Exit For
          //                            End If
          //                        End If
          //                    Next
          //                Else
          //                    'a ^ 2 · b + a · c = d
          //                    ak = KAH(2) : If LAA(2) = 1 Then ak = ak.TrimStart("-")

          //                    If IAB(2) = 4 Then ak = "4 · (" & ak & ")" Else ak = "4 · " & ak

          //                    If KAH(KAI(1) +i) = CAB Then ae &= "1" : af = "1" : ag = "1"

          //                    If KAH(KAI(1) +i) = "-" & CAB Then ae &= "1" : af = "1" : ag = "1"

          //                    If KAH(KAI(1) +i) = CAB & " ^ 2" Then ae &= "2" : ah = ak : ai = "2"

          //                    If KAH(KAI(1) +i) = "-" & CAB & " ^ 2" Then ae &= "2" : ah = ak : ai = "2"

          //                    If KAH(KAI(1) +i) = "-(" & CAB & " ^ 2)" Then ae &= "2" : ah = ak : ai = "2"
          //                End If
          //            Next
          //            If ae = "12" Or ae = "21" Then
          //                'a + a ^ 2 = d
          //                If ae = "12" Then

          //                    If LAA(2) = 1 Then am *= -1

          //                    If LAA(KAI(1)) = 1 Then an *= -1

          //                    If LAA(KAI(1) +1) = 1 Then am *= -1 : an *= -1

          //                    If KAI(KAI(1) +1) = "-" Then am *= -1 : an *= -1
          //                End If
          //                'a ^ 2 + a = d
          //                If ae = "21" Then

          //                    If LAA(2) = 1 Then am *= -1

          //                    If LAA(KAI(1) +1) = 1 Then an *= -1

          //                    If KAI(KAI(1) +1) = "-" Then an *= -1

          //                    If LAA(KAI(1)) = 1 Then am *= -1 : an *= -1
          //                End If
          //                If am = 1 Then aj = " + " Else aj = " - "

          //                If an = 1 Then ak = " + " Else ak = " - "
          //                'a ^ 2 + a = d
          //                If KAH(2) <> "0" Then

          //                    Dim ao As String: ao = CAB & "1 = (√(" & af & aj & ah & ")" & ak & ag & ") : " & ai : KAC.Add(ao)

          //                    KAD.Add("a ^ 2 b + a c + d = 0 => a1 = (-c + √(c ^ 2 - 4 b d)) : 2 : b")


          //                    'DAAI(vbLf & DAA & vbLf)

          //                    'DAAJ(ao & vbLf) : DAAK(NBA.GetString("S040")) : DAAI("a ^ 2 b + a c + d = 0") : DAAK(" => ")

          //                    'DAAJ("a1 = (-c + √(c ^ 2 - 4 b d)) : 2 : b" & vbLf)



          //                    'ZBZ.Document.Selection.StartPosition = 0

          //                    'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

          //                    'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

          //                    'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

          //                    ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

          //                    'ZBZ.Document.SetText(TextSetOptions.FormatRtf, "")



          //                    ao = CAB & "2 = (-√(" & af & aj & ah & ")" & ak & ag & ") : " & ai : KAC.Add(ao)

          //                    KAD.Add("a ^ 2 b + a c + d = 0 => a2 = (-c - √(c ^ 2 - 4 b d)) : 2 : b")

          //                    KAG.Add("a ^ 2 b + a c + d = 0 => a = (-c ± √(c ^ 2 - 4 b d)) : 2 : b")


          //                    'DAAI(vbLf & DAA & vbLf) : DAAJ(ao & vbLf) : DAAK(NBA.GetString("S040"))

          //                    'DAAI("a ^ 2 b + a c + d = 0") : DAAK(" => ") : DAAJ("a2 = (-c - √(c ^ 2 - 4 b d)) : 2 : b" & vbLf)



          //                    'ZBZ.Document.Selection.StartPosition = 0

          //                    'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

          //                    'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

          //                    'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

          //                    ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)


          //                    DAAE() : CAA += 1 : Exit Sub
          //                End If
          //                'a ^ 2 + a = 0
          //                If KAH(2) = "0" Then

          //                    If an = -1 Then ak = "-" : ag = "(" & ag & ")" Else ak = ""

          //                    If af = "1" And ai = "2" Then ae = ak & "1"

          //                    If af<> "1" And ai = "2" Then ae = ak & ag

          //                    If af = "1" And ai<> "2" Then ae = ak & "1 : (" & al & ")"

          //                    If af<> "1" And ai<> "2" Then ae = ak & ag & " : (" & al & ")"

          //                    Dim ao As String : ao = CAB & "1 = 0" : KAC.Add(ao)

          //                    KAD.Add("a ^ 2 b + a c = 0 => a1 = 0")


          //                    'DAAI(vbLf & DAA & vbLf) : DAAJ(ao & vbLf)

          //                    'DAAK(NBA.GetString("S040")) : DAAI("a ^ 2 b + a c = 0") : DAAK(" => ")

          //                    'DAAJ("a1 = 0" & vbLf)



          //                    'ZBZ.Document.Selection.StartPosition = 0

          //                    'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

          //                    'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

          //                    'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

          //                    ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

          //                    'ZBZ.Document.SetText(TextSetOptions.FormatRtf, "")



          //                    ao = CAB & "2 = " & ae : KAC.Add(ao) : KAD.Add("a ^ 2 b + a c = 0 => a2 = -c / b")

          //                    KAG.Add("a ^ 2 b + a c = 0 => a1 = 0, a2 = -c / b") '
          //                    '
          //                    'DAAI(vbLf & DAA & vbLf)

          //                    'DAAJ(ao & vbLf) : DAAK(NBA.GetString("S040")) : DAAI("a ^ 2 b + a c = 0")

          //                    'DAAK(" => ") : DAAJ("a2 = -c / b" & vbLf)
          //                    '


          //                    'ZBZ.Document.Selection.StartPosition = 0

          //                    'ZBZ.Document.Selection.EndPosition = ZBZ.Document.Selection.StoryLength - 1

          //                    'MAR.Add(ZBZ.Document.Selection.StoryLength - 1)

          //                    'ZBY.Document.Selection.FormattedText = ZBZ.Document.Selection.FormattedText

          //                    ''ZBZ.Document.Selection.Cut() : ZBY.Document.Selection.Paste(0)

          //                    DAAE() : CAA += 1 : Exit Sub
          //                End If
          //            End If
          //        End If
          //    End If
          //End If

        }
      }
    }
    private void DBCA()
    {
      // a = b
      bool ac; string ab, ag;
      double ad; ab = ""; ag = ""; CAC = "a = b";
      // Vorzeichen - extrahierte Reihenfolge !
      for (int i = 0; i < KAH.Count; i++)
      {
        if (IAA[i] > 1)
        {
          // a + -b = a - b
          if (KAI[i] == "+")
          {
            switch (DFAA(i))
            {
              case 2: // a + -b = a - b
                DCBA(" - ", MAC[i] - 3, 4);
                DDED("a` + -`b` = `a` - `b");
                return;
              case 7: // a + -b ^ c = a - b ^ c
                DCBA(" - ", MAC[i] - 3, 4);
                DDED("a` + -`b ^ c` = `a` - `b ^ c");
                DEBF("c"); return;
            }
          }
          // a - -b = a + b
          if (KAI[i] == "-")
          {
            switch (DFAA(i))
            {
              case 2: // a - -b = a + b
                DCBA(" + ", MAC[i] - 3, 4);
                DDED("a` - -`b` = `a` + `b"); return;
              case 7: // a - -b ^ c = a + b ^ c
                DCBA(" + ", MAC[i] - 3, 4);
                DDED("a` - -`b ^ c` = `a` + `b ^ c");
                DEBF("c"); return;
            }
          }
          // a ·: -b = -a ·: b
          if (KAI[i] == "·" | KAI[i] == ":")
          {
            // i > MAI[MAE[i]]) wegen DFAA(MAI[MAE[i]]) !
            // die andere Bedingung IAB[MAE[i]] == 5
            // statt (KAI[i] == "·" | KAI[i] == ":")
            // alleine geht nicht wegen DFAA(MAI[MAE[i]])
            switch (DFAA(i))
            {
              case 2: // a ·: -b = -a ·: b
                switch (DFAA(MAI[MAE[i]]))
                {
                  case 0: // a ·: -b = -a ·: b
                    DCBB("-", [MAC[i], 1, MAC[MAE[i]]]);
                    DDEH("a ·: `-`b` = `-`a ·: b"); return;
                  case 2: // -a ·: -b = a ·: b
                    DCAB([MAC[MAE[i]], 1, MAC[i], 1]);
                    DDHA("-`a ·: `-`b` = `a ·: b"); return;
                  case 5: // a ^ b ·: -c = -a ^ b ·: c
                    DCBB("-", MAC[i], 1, MAC[MAE[i]]);
                    DDEH("a ^ b ·: `-`c` = `-`a ^ b ·: c");
                    DEBF("b"); return;
                  case 7: // -a ^ b ·: -c = a ^ b ·: c
                    DCAB([MAC[MAE[i]], 1, MAC[i], 1]);
                    DDHA("-`a ^ b ·: `-`c` = `a ^ b ·: c");
                    DEBF("b"); return;
                }
                break;
              case 7: // a ·: -b ^ c = -a ·: b ^ c
                switch (DFAA(MAI[MAE[i]]))
                {
                  case 0: // a ·: -b ^ c = -a ·: b ^ c
                    DCBB("-", MAC[i], 1, MAC[MAE[i]]);
                    DDEH("a ·: `-`b ^ c` = `-`a ·: b ^ c");
                    DEBF("c"); return;
                  case 2: // -a ·: -b ^ c = a ·: b ^ c
                    DCAB([MAC[MAE[i]], 1, MAC[i], 1]);
                    DDHA("-`a ·: `-`b ^ c` = `a ·: b ^ c");
                    DEBF("c"); return;
                  case 5: // a ^ b ·: -c ^ d = -a ^ b ·: c ^ d
                    DCBB("-", MAC[i], 1, MAC[MAE[i]]);
                    DDEH("a ^ b ·: `-`c ^ d` = `-`a ^ b ·: c ^ d");
                    DEBF("b, d"); return;
                  case 7: // -a ^ b ·: -c ^ d = a ^ b ·: c ^ d
                    DCAB([MAC[MAE[i]], 1, MAC[i], 1]);
                    DDHA("-`a ^ b ·: `-`c ^ d` = `a ^ b ·: c ^ d");
                    DEBF("b, d"); return;
                }
                break;
            }
          }
        }
      }
      // Einziger Term - extrahierte Reihenfolge
      for (int i = 0; i < KAH.Count; i++)
      {
        switch (KAH[i])
        {
          case "e": // e = 2,71828
            DCBA(Java.Lang.Math.E.ToString(), MAC[i], 1);
            DDAA("e` = `2,72"); return;
          case "π": // π = 3,14159
            DCBA(Java.Lang.Math.Pi.ToString(), MAC[i], 1);
            DDAA("π` = `3,14"); return;
          case "-e": // -e = -2,71828
            DCBA("-" + Java.Lang.Math.E.ToString(), MAC[i], 2);
            DDAA("-e` = `-2,72"); return;
          case "-π": // -π = -3,14159
            DCBA("-" + Java.Lang.Math.Pi.ToString(), MAC[i], 2);
            DDAA("-π` = `-3,14"); return;
          case "-0": // -0 = 0
            DCBA("0", MAC[i], 2); DDAA("-0` = `0"); return;
          case "+∞": // +∞ = ∞
            DCBA("∞", MAC[i], 2); DDAA("+∞` = `∞"); return;
          case "-₪": // -₪ = ₪
            DCBA("₪", MAC[i], 2); DDAA("-₪` = `₪"); return;
        }
      }
      // Unbestimmte - extrahierte Reihenfolge !
      for (int i = 0; i < KAH.Count; i++)
      {
        if (KAH[i] == "0")
        {
          // : 0 · 0 = ₪
          if (KAI[i] == ":")
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAH[j] == "0" & KAI[j] != ":")
              {
                DCBC("· ₪", [MAC[i] - 2, 3, MAC[j] - 3, 4]);
                DDAA("0 : 0` = `₪"); return;
              }
            }
          }
          // · 0 : 0 = ₪, 0 · ∞ = ₪
          else if (IAB[MAE[i]] == 5)
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAH[j] == "0" & KAI[j] == ":")
              {
                DCBC("₪", [MAC[i], 1, MAC[j] - 3, 4]);
                DDAA("0 : 0` = `₪"); return; // · 0 : 0 = ₪
              }
              if ((KAH[j] == "∞" | KAH[j] == "-∞") == true & KAI[j] == "·")
              {
                DCBC("₪", [MAC[i], 1, MAC[j] - 3, MAD[j] + 3]);
                DDAA("0 · ∞` = `₪"); return; // 0 · ∞ = ₪  or  0 · -∞ = ₪
              }
            }
          }
          // a ^ 0 = ₪
          if (KAI[i] == "˄")
          {
            // 0 ^ 0 = ₪, ∞ ^ 0 = ₪
            if (KAH[MAI[MAE[i]]] == "0" | KAH[MAI[MAE[i]]] == "∞" | KAH[MAI[MAE[i]]] == "-∞")
            {
              DCBC("₪", [MAC[MAE[i]], MAD[MAI[MAE[i]]], MAC[i] - 3, 4]);
              DDAA(KAH[MAI[MAE[i]]] + " ˄ 0` = `₪"); return;
            }
          }
        }
        if (KAH[i] == "∞" | KAH[i] == "-∞")
        {
          // - ∞ + ∞ = ₪
          if (KAI[i] == "-")
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAH[j] == KAH[i] & KAI[j] != "-")
              {
                DCBC("+ ₪", [MAC[i] - 2, 3, MAC[j] - 3, 4]);
                DDAA("∞ - ∞` = `₪"); return;
              }
            }
          }
          // + ∞ - ∞ = ₪
          else if (IAB[MAE[i]] == 4)
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAH[j] == KAH[i] & KAI[j] == "-")
              {
                DCBC("₪", [MAC[i], MAD[i], MAC[j] - 3, 4]);
                DDAA("∞ - ∞` = `₪"); return;
              }
              if (KAH[i] == "-∞" & KAH[j] == "∞" & KAI[j] == "+")
              {
                DCBC("₪", [MAC[i], MAD[i], MAC[j] - 3, 4]);
                DDAA("-∞ + ∞` = `₪"); return; // -∞ + ∞ = ₪
              }
            }
          }
          // ∞ · 0 = ₪
          if (KAI[i] != ":" & IAB[MAE[i]] == 5)
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAH[j] == "0" & KAI[j] == "·") // ∞ · 0 = ₪
              {
                DCBC("₪", [MAC[i], MAD[i], MAC[j] - 3, 4]);
                DDAA("∞ · 0` = `₪"); return;
              }
            }
          }
          // : ∞ · ∞ = ₪
          if (KAI[i] == ":")
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAI[j] == "·" & (KAH[j] == "∞" | KAH[j] == "-∞") == true)
              {
                DCBC("· ₪", [MAC[i] - 2, MAD[i] + 2, MAC[j] - 3, MAD[j] + 3]);
                DDAA("∞ : ∞` = `₪"); return;
              }
            }
          }
          // · ∞ : ∞ = ₪
          else if (IAB[MAE[i]] == 5)
          {
            for (int j = i + 1; j == MAI[MAE[i]] + MAH[MAE[i]] - 1; j++)
            {
              if (KAI[j] == ":" & (KAH[j] == "∞" | KAH[j] == "-∞") == true)
              {
                DCBC("₪", [MAC[i], MAD[i], MAC[j] - 3, MAD[j] + 3]);
                DDAA("∞ : ∞` = `₪"); return;
              }
            }
          }
          // 1 ^ ∞ = ₪
          if (KAI[i] == "˄")
          {
            if (KAH[MAI[MAE[i]]] == "1")
            {
              DCBC("₪", [MAC[MAE[i]], 1, MAC[i] - 3, MAD[i] + 3]);
              DDAA("1 ˄ " + KAH[i] + "` = `₪"); return;
            }
          }
        }
      }
      // Vereinfachung - extrahierte Reihenfolge
      for (int i = 0; i < KAH.Count; i++)
      {
        // a = b
        if (MAH[i] == 0) // Der Term ist keine Funktion
        {
          switch (KAH[i])
          {
            case "0": // a o 0 = b
              switch (KAI[i])
              {
                case "+": // a + 0 = a
                  DCAA(MAC[i] - 3, 4); DDCX("a` + 0` = `a"); return;
                case "-": // a - 0 = a
                  DCAA(MAC[i] - 3, 4); DDCX("a` - 0` = `a"); return;
                case "±": // a ± 0 = a
                  DCAA(MAC[i] - 3, 4); DDCX("a` ± 0` = `a"); return;
                case "∓": // a ∓ 0 = a
                  DCAA(MAC[i] - 3, 4); DDCX("a` ∓ 0` = `a"); return;
                case "·": // a · 0 = 0
                  if (KAH[i - 1] != "₪")
                  {
                    DCAA(MAC[i - 1], 3 + MAD[i - 1]); DDCE("a · `0` = `0"); return;
                  }
                  break;
                case ":": // a : 0 = ∞
                  if (KAH[i - 1] != "₪")
                  {
                    DCBA("∞", MAC[i - 1], 4 + MAD[i - 1]); DDAA("a : 0` = `∞"); return;
                  }
                  break;
                case "˄": // a ^ 0 = 1
                  if (KAH[MAI[MAE[i]]] != "₪")
                  {
                    DCBC("1", [MAC[MAE[i]], MAD[MAI[MAE[i]]], MAC[i] - 3, 4]);
                    DDAA("a ^ 0` = `1"); return;
                  }
                  break;
                case "": // 0 o a = b
                  if (MAH[MAE[i]] > 1)
                  {
                    // 0 + a = a
                    if (KAI[i + 1] == "+")
                    {
                      DCAA(MAC[i], 4); DDCE("0 + `a` = `a"); return;
                    }
                    // 0 · a = 0
                    if (KAI[i + 1] == "·")
                    {
                      if (KAH[i + 1] != "₪")
                      {
                        DCAA(MAC[i] + 1, MAD[i + 1] + 3); DDCX("0 · `a` = `0"); return;
                      }
                    }
                    // 0 : a = 0
                    if (KAI[i + 1] == ":")
                    {
                      if (KAH[i + 1] != "₪")
                      {
                        DCAA(MAC[i] + 1, MAD[i + 1] + 3);
                        DDCX("0` : a` = `0"); DEBD("   a ≠ 0"); return;
                      }
                    }
                    // 0 - a = -a
                    if (KAI[i + 1] == "-")
                    {
                      switch (DFAA(i + 1))
                      {
                        case 0: // 0 - a = -a
                          DCBB("-", MAC[i], 4, MAC[i]);
                          DDCF("0 - `a` = `-`a"); return;
                        case 1: // 0 - a = -(a')
                          DCCA(["-(", ")"], MAC[i], 4, MAC[i], MAC[i] + MAD[i + 1]);
                          DDCG("0 - `a ˄˅ b` = `-(`a ˄˅ b`)"); return;
                        case 3: // 0 - -a = -(-a')
                          DCCA(["-(", ")"], MAC[i], 4, MAC[i], MAC[i] + MAD[i + 1]);
                          DDCG("0 - `-a ˄˅ b` = `-(`-a ˄˅ b`)"); return;
                        case 4: // 0 - a'. = -(a').
                          DCCA(["-(", ")"], MAC[i], 4, MAC[i], MAC[i] + MAD[MAI[i + 1]]);
                          DDCG("0 - `a ˄˅ b` = `-(`a ˄˅ b`)"); return;
                        case 5: // 0 - a' = -a'
                          DCBB("-", MAC[i], 4, MAC[i]);
                          DDCF("0 - `a ^ b` = `-`a ^ b");
                          DEBD("   b = 2 k + 1"); return;
                        case 6: // 0 - -a'. = -(-a').
                          DCCA(["-(", ")"], MAC[i], 4,
                            MAC[i], MAC[i] + MAD[MAI[i + 1]]);
                          DDCG("0 - `-a ˄˅ b` = `-(`-a ˄˅ b`)"); return;
                      }
                    }
                  }
                  break;
              }
              break;
            case "1": // a o 1 = a
              switch (KAI[i])
              {
                case "·": DCAA(MAC[i] - 3, 4); DDCX("a` · 1` = `a"); return;
                case ":": DCAA(MAC[i] - 3, 4); DDCX("a` : 1` = `a"); return;
                case "˄": DCAA(MAC[i] - 3, 4); DDCX("a` ^ 1` = `a"); return;
                case "":
                  if (MAH[MAE[i]] > 1 && KAI[i + 1] == "·")
                  { DCAA(MAC[i], 4); DDCE("1 · `a` = `a"); return; }
                  break;
              }
              break;
            case "-1": // a o -1 = b
              // -1 · a = -a
              if (KAI[i] == "")
              {
                if (MAH[MAE[i]] > 1 && KAI[i + 1] == "·")
                {
                  switch (DFAA(i + 1))
                  {
                    case 0: // -1 · a = -a
                      DCAA(MAC[i] + 1, 4); DDEA("-`1 · `a` = `-a"); return;
                    case 1:
                      DCCA(["(", ")"], MAC[i] + 1, 4, MAC[i] + 1, MAC[i] + MAD[i + 1] + 1);
                      DDEE("-`1 · `a ˄˅ b` = `-`(`a ˄˅ b`)"); return;
                    case 2:
                      DCAA(MAC[i], 6); DDCE("-1 · -`a` = `a"); return;
                    case 3:
                      DCCA(["(", ")"], MAC[i] + 1, 4, MAC[i] + 1, MAC[i] + MAD[i + 1] + 1);
                      DDEE("-`1 · `-a ˄˅ b` = `-`(`-a ˄˅ b`)"); return;
                    case 4:
                      DCCA(["(", ")"], MAC[i] + 1, 4, MAC[i] + 1, MAC[i] + MAD[i + 1] + 1);
                      DDEE("-`1 · `a ˄˅ b` = `-`(`a ˄˅ b`)"); return;
                    case 5:
                      DCAA(MAC[i] + 1, 4); DDEA("-`1 · `a ^ b` = `-a ^ b");
                      DEBF("b"); return;
                    case 6:
                      DCCA(["(", ")"], MAC[i] + 1, 4, MAC[i] + 1, MAC[i] + MAD[i + 1] + 1);
                      DDEE("-`1 · `-a ˄˅ b` = `-`(`-a ˄˅ b`)"); return;
                    case 7:
                      DCAA(MAC[i], 6); DDCE("-1 · -`a ^ b` = `a ^ b");
                      DEBF("b"); return;
                  }
                }
              }
              // a ·: -1 = -a
              if (KAI[i] != "")
              {
                if (IAB[MAE[i]] == 5)
                {
                  switch (DFAA(i - 1))
                  {
                    case 0:
                      DCBB("-", MAC[i] - 3, 5, MAC[i - 1]);
                      DDCA("a` ·: -1` = `-`a"); return;
                    case 1:
                      DCCA(["-(", ")"], MAC[i] - 3, 5, MAC[i - 1], MAC[i] - 3);
                      DDCA("a ˄˅ b` ·: -1` = `-(`a ˄˅ b"); DEBB(")"); return;
                    case 2:
                      DCBB("-", MAC[i] - 3, 5, MAC[i - 1]);
                      DDFA("-`a` ·: -1` = `a"); return;
                    case 3:
                      DCCA(["-(", ")"], MAC[i] - 3, 5, MAC[i - 1], MAC[i] - 3);
                      DDCA("-a ˄˅ b` ·: -1` = `-(`-a ˄˅ b"); DEBB(")"); return;
                    case 5:
                      DCBB("-", MAC[i] - 3, 5, MAC[i - 1]);
                      DDCA("a ^ b` ·: -1` = `-`a ^ b"); DEBF("b"); return;
                    case 7:
                      DCBB("-", MAC[i] - 3, 5, MAC[i - 1]);
                      DDFA("-`a ^ b` ·: -1` = `a ^ b"); DEBF("b"); return;
                  }
                }
              }
              break;
          }
          switch (KAH[i]!.Substring(MAD[i] - 1, 1))
          {
            case "!":
              if (int.TryParse(KAH[i]![..(MAD[i] - 1)], out _) == true)
              {
                int ai = Convert.ToInt32(KAH[i]![..(MAD[i] - 1)]);
                if (ai < 170 & ai > -170)
                {
                  double aj = Convert.ToDouble(ai); string av = "";
                  if (aj == 0) { av = "1"; }
                  ; if (aj < 0) { av = "-"; aj *= -1; }
                  for (int j = ai - 1; j > 0; j -= 1) { aj *= j; }
                  ; if (av != "1") { av += DFAB(aj); }
                  DCBA(av, MAC[i], MAD[i]); DDAA("a!` = `b"); DEBD("   a < 170"); return;
                }
              }
              break;
              //case "´": break;
          }
        }
        // f(a) = b
        if (MAH[i] == 1) // Der Term ist eine Funktion
        {
          if (IAB[MAI[i]] == 0) // Die Funktion enthält nur einen Term
          {
            // (a) = a
            if (MAB[i] == 1)
            {
              // (a) = a
              if (IAA[i] < 2)
              {
                //A102.Text += CAA + " _ " + KAH[i] + IAB[MAI[i]].ToString();
                DCAB([MAC[i], 1, MAC[i] + MAD[i] - 1, 1]);
                DDFA("(`a`)` = `a"); return;
              }
              // -(a) = -a
              if (IAA[i] > 1)
              {
                // -(a) = -a
                if (IAA[MAI[i]] == 0)
                {
                  DCAB(MAC[i] + 1, 1, MAC[i] + MAD[i] - 1, 1);
                  DDGA("-`(`a`)` = `-a"); return;
                }
                // -(-a) = a
                if (IAA[MAI[i]] == 2)
                {
                  DCAB(MAC[i], 3, MAC[i] + MAD[i] - 1, 1);
                  DDFA("-(-`a`)` = `a"); return;
                }
              }
            }
            // |a| = b
            if (MAB[i] == 2)
            {
              // |-a| = |a|
              if (MAJ[MAI[i]] == 0) // Inhalt des Funktions ist keine Zahl
              {
                if (IAA[MAI[i]] > 1) // die innere Variable hat Minus-Vorzeichen
                {
                  DCAA(MAC[MAI[i]], 1); DDEA("|`-`a|` = `|a|");
                  DEBD("   a ≥ 0"); return;
                }
              }
              // |a| = a
              if (MAJ[MAI[i]] == 1) // Inhalt des Funktions ist eine Zahl
              {
                // |a| = a    a ≥ 0
                if (IAA[MAI[i]] == 0) // die innere Zahl ist positiv
                {
                  // |a| = a    a ≥ 0
                  if (IAA[i] < 2) // vor Betrag gibt es kein Minus-Vorzeichen
                  {
                    DCAB(MAC[i], 1, MAC[i] + MAD[i] - 1, 1);
                    DDFA("|`a`|` = `a"); DEBD("   a ≥ 0"); return;
                  }
                  // -|a| = -a    a ≥ 0
                  if (IAA[i] > 1) // vor Betrag gibt es ein Minus-Vorzeichen
                  {
                    DCAB(MAC[i] + 1, 1, MAC[i] + MAD[i] - 1, 1);
                    DDGA("-`|`a`|` = `-a"); DEBD("   a ≥ 0"); return;
                  }
                }
                // |a| = -a   a < 0
                if (IAA[MAI[i]] == 2) //  die innere Zahl ist negativ
                {
                  // |a| = -a    a < 0
                  if (IAA[i] < 2) // vor Betrag gibt es kein Minus-Vorzeichen
                  {
                    DCAB(MAC[i], 2, MAC[i] + MAD[i] - 1, 1);
                    DDFB("|`a`|` = `-`a"); DEBD("   a < 0"); return;
                  }
                  // -|a| = -a    a < 0
                  if (IAA[i] > 1) // vor Betrag gibt es ein Minus-Vorzeichen
                  {
                    DCAB(MAC[i], 2, MAC[i] + MAD[i] - 1, 1);
                    DDFA("-|`a`|` = `a"); DEBD("   a < 0"); return;
                  }
                }
              }
            }
            // log(v) = b
            switch (KAH[i])
            {
              case "ln(0)": DCBA("-∞", MAC[i], 5); DDAA("ln(0)` = `-∞"); return;
              case "-ln(0)": DCBA("∞", MAC[i], 6); DDAA("-ln(0)` = `∞"); return;
              case "log(0)": DCBA("-∞", MAC[i], 6); DDAA("log(0)` = `-∞"); return;
              case "-log(0)": DCBA("∞", MAC[i], 7); DDAA("-log(0)` = `∞"); return;
              case "ln(e)": DCBA("1", MAC[i], 5); DDAA("ln(e)` = `1"); return;
              case "-ln(e)": DCBA("-1", MAC[i], 6); DDAA("-ln(e)` = `-1"); return;
            }
            // f(a) = b
            if (MAJ[MAI[i]] == 1) // die Innere des Funktions ist eine Zahl
            {
              // √(a) = b
              if (MAB[i] == 3)
              {
                // √(a)
                if (MAJ[MAI[i]] == 1)
                {
                  ad = Java.Lang.Math.Sqrt(double.Parse(KAH[MAI[i]]!));
                  if (ad >= 0 & !double.IsNaN(ad))
                  {
                    ab = DFAB(ad); if (IAA[i] > 1) { ab = "-" + ab; if (ab == "-0") { ab = "0"; } }
                    DCBA(ab, MAC[i], MAD[i]); DDAA("√(a)` = `b"); return;
                  }
                }
              }
              // ln(a) = b
              if (MAB[i] == 8)
              {
                ad = Java.Lang.Math.Log(Convert.ToDouble(KAH[MAI[i]])); if (IAA[i] > 1) { ad *= -1; }
                DCBA(DFAB(ad), MAC[i], MAD[i]); DDAA("ln(a)` = `b"); return;
              }
              // log(a) = b
              if (MAB[i] == 9)
              {
                ad = Java.Lang.Math.Log10(Convert.ToDouble(KAH[MAI[i]])); if (IAA[i] > 1) { ad *= -1; }
                DCBA(DFAB(ad), MAC[i], MAD[i]); DDAA("log(a)` = `b"); return;
              }
              // tan*(a) = b
              if (MAB[i] > 10)
              {
                ab = ""; ad = Convert.ToDouble(KAH[MAI[i]]);
                switch (MAB[i])
                {
                  case 11: ad = Java.Lang.Math.Cos(ad / 180 * Java.Lang.Math.Pi); ab = "cos"; break;
                  case 12: ad = Java.Lang.Math.Sin(ad / 180 * Java.Lang.Math.Pi); ab = "sin"; break;
                  case 13: ad = Java.Lang.Math.Tan(ad / 180 * Java.Lang.Math.Pi); ab = "tan"; break;
                  case 14: ad = 1 / Java.Lang.Math.Tan(ad / 180 * Java.Lang.Math.Pi); ab = "cot"; break;
                  case 15: ad = Java.Lang.Math.Acos(ad) * 180 / Java.Lang.Math.Pi; ab = "acos"; break;
                  case 16: ad = Java.Lang.Math.Asin(ad) * 180 / Java.Lang.Math.Pi; ab = "asin"; break;
                  case 17: ad = Java.Lang.Math.Atan(ad) * 180 / Java.Lang.Math.Pi; ab = "atan"; break;
                  case 18: ad = Java.Lang.Math.Acos(1 / ad) * 180 / Java.Lang.Math.Pi; ab = "acot"; break;
                }
                if (ab != "")
                {
                  if (IAA[i] > 1)
                  { ad *= -1; }
                  ; DCBA(DFAB(ad), MAC[i], MAD[i]); DDAA(ab + "(a)` = `b"); return;
                }
              }
            }
          }
          if (IAB[MAI[i]] == 1) // Die Funktion enthält mehrere Terme
          {
            // √(a ' b)
            if (MAB[i] == 3)
            {
              // √(a ' b)
              if (IAB[MAI[i]] == 1)
              {
                // √(a ' 2) = √(a)
                if (KAH[MAI[MAI[i]] + 1] == "2")
                {
                  // √(a ' 2) = √(a)
                  if (MAJ[MAI[MAI[i]]] == 0)
                  {
                    DCAA(MAC[MAI[MAI[i]] + 1] - 3, 4); DDEA("√(a` ' 2`)` = `√(a)"); return;
                  }
                }
                // √(a ' b) = c
                if (MAJ[MAI[MAI[i]]] == 1 & MAJ[MAI[MAI[i]] + 1] == 1)
                {
                  ad = Java.Lang.Math.Pow(double.Parse(KAH[MAI[MAI[i]]]!), 1 / double.Parse(KAH[MAI[MAI[i]] + 1]!));
                  if (ad >= 0 & !double.IsNaN(ad))
                  {
                    ab = DFAB(ad); if (IAA[i] > 1) { ab = "-" + ab; if (ab == "-0") { ab = "0"; } }
                    DCBA(ab, MAC[i], MAD[i]); DDAA("√(a ' b)` = `c"); return;
                  }
                }
              }
            }
            // log(a ' b) = с
            if (MAB[i] == 9) // Die Funktion ist ein Logarithmus
            {
              if (MAJ[MAI[MAI[i]]] == 1 & MAJ[MAI[MAI[i]] + 1] == 1) // beide sind Zahlen
              {
                ad = Java.Lang.Math.Log(Convert.ToDouble(KAH[MAI[MAI[i]] + 1])) /
                    Java.Lang.Math.Log(Convert.ToDouble(KAH[MAI[MAI[i]]]));
                if (ad >= 0 & ad.ToString() != "NaN")
                {
                  ab = DFAB(ad); if (IAA[i] > 1) { ab = "-" + ab; }
                  if (ab == "-0") { ab = "0"; }
                  ; DCBA(ab, MAC[i], MAD[i]);
                  DDAA("log(a ' b)` = `c"); return;
                }
              }
            }
          }
          if (IAB[MAI[i]] > 3) // Die Funktion enthält mehrere Terme
          {
            // (a o b) = a o b
            if (MAB[i] == 1) // Die Funktion ist runde Klammer
            {
              int ii = MAI[i]; ac = false;
              if (IAB[MAE[i]] <= IAB[ii]) // Bedingung für Operatorengruppen
              {
                // Bedingung für Umkehren oder nicht Umkehren innerer Operatoren
                if (KAI[i] == "-" | KAI[i] == ":" | KAI[i] == "˅")
                { if (IAB[ii] < 6 & IAB[MAE[i]] == IAB[ii]) { ac = true; } }
                else { if (IAB[ii] == 4 & IAA[i] > 1) { ac = true; } }
                int ij, oi, oj; oi = MAC[ii] + MAD[MAI[ii]];
                if (IAB[ii] == 4) { ij = MAI[ii]; } else { ij = ii; }
                // Nicht Umkehren oder Umkehren bei Ausklammern
                if (ac == false) // nicht umkehren   IAB(ii) = 4, 5 oder 6
                {
                  oj = MAC[i] + MAD[i] - 1;
                  // (a o b) = a o b
                  if (IAA[i] < 2) // Plusvorzeichen der Funktion
                  {
                    DCAB(MAC[i], 1, oj, 1);
                    DDFA("(`a`)` = `a"); return;
                  }
                  // -(a o b) = -a o b
                  if (IAA[i] > 1) // Minusvorzeichen der Funktion
                  {
                    switch (DFAA(ii))
                    {
                      case 0: // -(a ·: b) = -a ·: b
                        DCAB(MAC[i] + 1, 1, oj, 1); // BRBR-G
                        DDGA("-`(`a ·: b`)` = `-a ·: b"); return;
                      case 2: // -(-a ·: b) = a ·: b
                        DCAB(MAC[i], 3, oj, 1); // RBR-G
                        DDFA("-(-`a ·: b`)` = `a ·: b"); return;
                      case 4: // -(a ^ b ·: c) = -(a ^ b) ·: c
                        DCBB(")", oj, 1, oi); // BR-GRG
                        DDCB("-(a ^ b ·: c`)` = `-(a ^ b`)` ·: c"); return;
                      case 5: // -(a ^ b ·: c) = -(a ^ b) ·: c
                        DCAB(MAC[i] + 1, 1, oj, 1); // BRBR-G
                        DDGA("-`(`a ^ b`)` = `-a ^ b"); DEBF("b"); return;
                      case 6: // -(-a ^ b ·: c) = -(-a ^ b) ·: c
                        DCBB(")", oj, 1, oi); // BR-GRG
                        DDCB("-(-a ^ b ·: c`)` = `-(-a ^ b`)` ·: c"); return;
                      case 7: // -(-a ^ b ·: c) = -(-a ^ b) ·: c
                        DCAB(MAC[i], 3, oj, 1); // RBR-G
                        DDFA("-(-`a ^ b`)` = `a ^ b"); DEBF("b"); return;
                    }
                  }
                } // false - nicht Umkehren
                else // umkehren   IAB(ii) = nur 4 oder 5
                {
                  oj = MAC[ii] + MAD[MAI[ij]]; // KAC(ii) = KAC(KAI(ii)) !
                  // 1.1: erste Eingabeausdrucksteile von ...(a  ...o b...  )...

                  if (IAA[i] < 2) // Plusvorzeichen der Funktion
                  {
                    DEBA("\n\n" + CAA[..MAC[i]]);
                    DEBB(CAA.Substring(MAC[i], 1));
                    DEBA(CAA.Substring(MAC[ii], MAD[MAI[ii]]));
                  } //  (a o b) = a o b                  
                  if (IAA[i] > 1) // Minusvorzeichen der Funktion
                  {
                    switch (DFAA(ij))
                    {
                      case 0:
                        DEBA("\n\n" + CAA[..(MAC[i] + 1)]);
                        DEBB(CAA.Substring(MAC[i] + 1, 1));
                        DEBA(CAA.Substring(MAC[ii], MAD[MAI[ii]])); break;
                      case 1:
                        DEBA("\n\n" + CAA[..oi]); break;
                      case 2:
                        DEBA("\n\n" + CAA[..MAC[i]]);
                        DEBB(CAA.Substring(MAC[i], 3));
                        DEBA(CAA.Substring(MAC[ii] + 1, MAD[MAI[ii]] - 1)); break;
                      case 3:
                        DEBA("\n" + "\n" + CAA[..oi]); break;
                      case 5:
                        DEBA("\n" + "\n" + CAA[..(MAC[i] + 1)]);
                        DEBB(CAA.Substring(MAC[i] + 1, 1));
                        DEBA(CAA.Substring(MAC[ii], MAD[MAC[ii]])); break;
                      case 7:
                        DEBA("\n" + "\n" + CAA[..MAC[i]]); DEBB(CAA.Substring(MAC[i], 3));
                        DEBA(CAA.Substring(MAC[ii] + 1, MAD[MAC[ii]] - 1)); break;
                    }
                  } // -(a o b) = -a o b
                    // 1.2: zweite Eingabeausdrucksteile von ...(a  ...o b...  )...

                  for (int j = MAI[ii] + 1; j == MAI[ii] + MAH[ii] - 1; j++)
                  {
                    DEBB(CAA.Substring(MAC[j] - 3, 3)); CAA = CAA.Remove(MAC[j] - 2, 1);
                    if (IAB[ii] == 4) { if (KAI[j] == "+") { ab = "-"; } else { ab = "+"; } }
                    if (IAB[ii] == 5) { if (KAI[j] == "·") { ab = ":"; } else { ab = "·"; } }
                    CAA = CAA.Insert(MAC[j] - 2, ab); DEBA(CAA.Substring(MAC[j], MAD[j]));
                  }
                  // 1.3: dritte Eingabeausdrucksteile von ...(a  ...o b...  )...

                  DEBB(CAA.Substring(MAC[i] + MAD[i] - 1, 1));
                  DEBA(CAA.Substring(MAC[i] + MAD[i], MAD[0] - MAC[i] - MAD[i]));
                  // 2.1: erste Ausgabeausdrucksteile von ...(a  ...o b...  )...

                  if (IAA[i] < 2) // Plusvorzeichen der Funktion
                  {
                    DEBC('\n' + CAA[..MAC[i]]);
                    DEBC(CAA.Substring(MAC[ii], MAD[MAI[ii]]));
                  } // (a o b) = a o b
                  if (IAA[i] > 1) // Minusvorzeichen der Funktion
                  {
                    switch (DFAA(ij))
                    {
                      case 0: // -(a o b) = -a o b
                        DEBC('\n' + CAA[..(MAC[i] + 1)]);
                        DEBC(CAA.Substring(MAC[ii], MAD[MAI[ii]])); break;
                      case 1: // -(a ^ b ·: c)
                        DEBC('\n' + CAA[..oi]); DEBB(")"); break;
                      case 2: // -(-a o b) = a o b
                        DEBC('\n' + CAA[..MAC[i]]);
                        DEBC(CAA.Substring(MAC[ii] + 1, MAD[MAI[ii]] - 1)); break;
                      case 3: // -(-a ^ b ·: c)
                        DEBC('\n' + CAA[..oi]); DEBB(")"); break;
                      case 4: // -(a ^ b ·: c +- d)
                        DEBC('\n' + CAA[..oj]); DEBB(")");
                        DEBC(CAA.Substring(oj + 1, MAD[MAI[ii]] - MAD[MAI[ij]])); break;
                      case 5: // -(a ^ b o c) = -(a ^ b) o c
                        DEBC('\n' + CAA[..(MAC[i] + 1)]);
                        DEBC(CAA.Substring(MAC[ii], MAD[MAI[ii]])); break;
                      case 6: // -(-a ^ b ·: c +- d)
                        DEBC('\n' + CAA[..oj]); DEBB(")");
                        DEBC(CAA.Substring(oj + 1, MAD[MAI[ii]] - MAD[MAI[ij]])); break;
                      case 7: // -(-a ^ b o c) = -(-a ^ b) o c
                        DEBC('\n' + CAA[..(MAC[i])]);
                        DEBC(CAA.Substring(MAC[ii] + 1, MAD[MAI[ii]] - 1)); break;
                    }
                  } // -(a o b) = -a o b
                    // 2.2: zweite Ausgabeausdrucksteile von ...(a  ...o b...  )...

                  for (int j = MAI[ii] + 1; j == MAI[ii] + MAH[ii] - 1; j++)
                  {
                    DEBB(CAA.Substring(MAC[j] - 3, 3));
                    DEBC(CAA.Substring(MAC[j], MAD[j]));
                  }
                  // 2.3: dritte Ausgabeausdrucksteile von...(a...o b...  )...

                  DEBC(CAA.Substring(MAC[i] + MAD[i], MAD[0] - MAC[i] - MAD[i]));
                  CAA = CAA.Remove(MAC[i] + MAD[i] - 1, 1);
                  // 3.1: ganze Kommentare für (a o b) = a o b

                  if (IAA[i] < 2) // Vorzeichen der Funktion ist plus
                  {
                    CAA = CAA.Remove(MAC[i], 1);
                    if (IAB[ii] == 4) { DDJA("a - `(`b` +- `c`)` = `a - b` -+ `c"); return; }
                    if (IAB[ii] == 5) { DDJA("a : `(`b` ·: `c`)` = `a : b` :· `c"); return; }
                  } // (a o b) = a o b
                  if (IAA[i] > 1) // Vorzeichen der Funktion ist minus
                  {
                    switch (DFAA(ij))
                    {
                      case 0:
                        CAA = CAA.Remove(MAC[i] + 1, 1);
                        if (IAB[ii] == 4) { DDJA("-`(`a` +- `b`)` = `-a` -+ `b"); return; }
                        if (IAB[ii] == 5) { DDJA("a : -`(`b` ·: `c`)` = `a : -b` :· `c"); return; }
                        break;
                      case 1:
                        CAA = CAA.Insert(oi, ")");
                        if (IAB[ii] == 4) { DDGB("-(a ^ b` +- `c`)` = `-(a ^ b`) -+ `c"); return; }
                        if (IAB[ii] == 5) { DDGB("a : -(b ^ c` ·: `d`)` = `a : -(b ^ c`) :· `d"); return; }
                        break;
                      case 2:
                        CAA = CAA.Remove(MAC[i], 3);
                        if (IAB[ii] == 4) { DDIA("-(-`a` +- `b`)` = `a` -+ `b"); return; }
                        if (IAB[ii] == 5) { DDJA("a : `-(-`b` ·: `c`)` = `a : b` :· `c"); return; }
                        break;
                      case 3:
                        CAA = CAA.Insert(oi, ")");
                        if (IAB[ii] == 4) { DDGB("-(-a ^ b` +- `c`)` = `-(-a ^ b`) -+ `c"); return; }
                        if (IAB[ii] == 5) { DDGB("a : -(-b ^ c` ·: `d`)` = `a : -(-b ^ c`) :· `d"); return; }
                        break;
                      case 4:
                        DDGB("-(a ^ b ·: c` +- `d`)` = `-(a ^ b`)` ·: c");
                        CAA = CAA.Insert(oj, ")"); DEBB(" -+ "); DEBC("d"); return;
                      case 5:
                        CAA = CAA.Remove(MAC[i] + 1, 1);
                        if (IAB[ii] == 4)
                        { DDJA("-`(`a ^ b` +- `c`)` = `-a ^ b` -+ `c"); DEBF("b"); return; }
                        if (IAB[ii] == 5)
                        { DDJA("a : -`(`b ^ c` ·: `d`)` = `a : -b ^ c` :· `d"); DEBF("c"); return; }
                        break;
                      case 6:
                        DDGB("-(-a ^ b ·: c` +- `d`)` = `-(-a ^ b`)` ·: c");
                        CAA = CAA.Insert(oj, ")"); DEBB(" -+ "); DEBC("d"); return;
                      case 7:
                        CAA = CAA.Remove(MAC[i], 3);
                        if (IAB[ii] == 4)
                        {
                          DDIA("-(-`a ^ b` +- `c`)` = `a ^ b` -+ `c");
                          DEBD("   b = 2 k + 1"); return;
                        }
                        if (IAB[ii] == 5)
                        {
                          DDJA("a : `-(-`b ^ c` ·: `d`)` = `a : b ^ c` :· `d");
                          DEBD("   c = 2 k + 1"); return;
                        }
                        break;
                    }
                  } // -(a o b) = -a o b
                } // true - Umkehren
              }
            }


          }
        }
        // a o b = c
        if (MAH[i] > 1)
        {
          // a +- b = c
          if (IAB[i] == 4) // Operatorengruppe des Ausdrucks ist +-
          {
            for (int j = MAI[i]; j < MAI[i] + MAH[i] - 1; j++)
            {
              if (KAH[j] != "∞" & KAH[j] != "-∞")
              {
                for (int k = j + 1; k < MAI[i] + MAH[i]; j++)
                {
                  // a - a = 0
                  if (KAH[j] == KAH[k])
                  {
                    // a - a = 0
                    if (KAI[j] != "-" & KAI[k] == "-")
                    {
                      DCBC("0", MAC[j], MAD[j], MAC[k] - 3, MAD[k] + 3);
                      DDAA("a - a` = `0"); return;
                    }
                    // - a + a = 0
                    if (KAI[j] == "-" & KAI[k] != "-")
                    {
                      DCAB(MAC[j] - 3, MAD[j] + 3, MAC[k] - 3, MAD[k] + 3);
                      DDCX("a` - b + b` = `a"); return;
                    }
                  }
                  // -a + a = 0
                  if (KAH[j] == "-" + KAH[k])
                  {
                    if (KAI[k] == "+")
                    {
                      if (IAA[j] == 2 | DFAA(j) == 3)
                      {
                        DCBC("0", MAC[j], MAD[j], MAC[k] - 3, MAD[k] + 3);
                        if (IAA[j] == 2) { DDAA("-a + a` = `0"); }
                        else { DDAA("-a ^ b + a ^ b` = `0"); DEBD("   b = 2 k + 1"); }
                        ;
                        return; // -a ^ b + a ^ b = 0
                      } // Range: (A And B) Or C
                    }
                  }
                  // b r e a k   C#
                  if (j == MAI[i] + MAH[i] - 1) { break; }
                }
              }
              if (j == MAI[i] + MAH[i] - 2) { break; }
            }
          }
          // a ·: b = c
          if (IAB[i] == 5) // Operatorengruppe des Ausdrucks ist ·:
          {
            for (int j = MAI[i]; j < MAI[i] + MAH[i] - 1; j++)
            {
              if (KAH[j] != "∞" & KAH[j] != "-∞" & KAH[j] != "0")
              {
                for (int k = j + 1; k < MAI[i] + MAH[i]; j++)
                {
                  // a : a = 1
                  if (KAH[j] == KAH[k])
                  {
                    // a : a = 1
                    if (KAI[j] != ":" & KAI[k] == ":")
                    {
                      DCBC("1", MAC[j], MAD[j], MAC[k] - 3, MAD[k] + 3);
                      DDAA("a : a` = `1"); return;
                    }
                    // : a · a = 1
                    if (KAI[j] == ":" & KAI[k] != ":")
                    {
                      DCAB(MAC[j] - 3, MAD[j] + 3, MAC[k] - 3, MAD[k] + 3);
                      DDCX("a` : b · b` = `a"); return;
                    }
                  }
                  // -a : a = -1
                  if (KAH[j] == "-" + KAH[k] | KAH[k] == "-" + KAH[j])
                  {
                    // -a : a = -1
                    if (KAI[j] != ":" & KAI[k] == ":")
                    {
                      DCBC("-1", MAC[j], MAD[j], MAC[k] - 3, MAD[k] + 3);
                      if (IAA[j] == 2) { DDAA("-a : a` = `-1"); return; }
                      if (IAA[k] == 2) { DDAA("a : -a` = `-1"); return; }
                      if (DFAA(j) == 3) { DDAA("-a ^ b : a ^ b` = `-1"); DEBD("   b = 2 k + 1"); return; }
                      if (DFAA(k) == 3) { DDAA("a ^ b : -a ^ b` = `-1"); DEBD("   b = 2 k + 1"); return; }
                    }
                    // : -a · a = -1
                    if (KAI[j] == ":" & KAI[k] != ":")
                    {
                      DCBC(" · -1", MAC[j], MAD[j], MAC[k] - 3, MAD[k] + 3);
                      if (IAA[j] == 2) { DDCY("a` : -b · b` = `a` · -1"); return; }
                      if (IAA[k] == 2) { DDCY("a` : b · -b` = `a` · -1"); return; }
                      if (DFAA(j) == 3) // wegen falls a < 0 ist mit " · -1"
                      { DDCY("a` : -b ^ c · b ^ c` = `a` · -1"); DEBD("   c = 2 k + 1"); return; }
                      if (DFAA(k) == 3) // wegen falls a < 0 ist mit " · -1"
                      { DDCY("a` : b ^ c · -b ^ c` = `a` · -1"); DEBD("   c = 2 k + 1"); return; }
                      ;
                    }
                  }
                  // b r e a k
                  if (j == MAI[i] + MAH[i] - 1) { break; } // c# eigene Bedingung
                }
              }
              if (j == MAI[i] + MAH[i] - 2) { break; } // c# eigene Bedingung
            }
          }
          // a ˄˅ b = c
          if (IAB[i] == 6) // Operatorengruppe des Ausdrucks ist ˄˅
          {
            // -a ^ 2 = a ^ 2
            if (IAA[i] == 3) // Erster Term des Ausdrucks ist negativ 3
            {
              if (MAJ[MAI[i] + 1] == 1 & IAA[MAI[i] + 1] < 2)
              {
                if (int.TryParse(KAH[MAI[i] + 1], out _) == true)
                {
                  string yy = KAH[MAI[i] + 1]!.Substring(MAD[MAI[i] + 1] - 1, 1);
                  if (yy == "0" | yy == "2" | yy == "4" | yy == "6" | yy == "8")
                  {
                    DCAA(MAC[i], 1); DDCE("-`a ^ b` = `a ^ b");
                    DEBD("   b = 2 k"); return; // RB-G
                  }
                }
              }
            }
          }
        }
      }
      // Zahlenrechnung - extrahierte Reihenfolge
      for (int i = 0; i < KAH.Count; i++)
      {
        // a o b = c
        if (MAJ[i] == 1)
        {
          if (IAB[MAE[i]] > 3 & i < MAI[MAE[i]] + MAH[MAE[i]] - 1)
          {
            string ah = ""; int ai, aj, ak;
            if (KAI[i] == "") { ak = 0; } else { ak = 3; }
            ai = MAD[i] + ak; ad = Convert.ToDouble(KAH[i]);
            if (KAI[i] == "-") { ad = 0 - ad; }
            if (KAI[i] == ":") { ad = 1 / ad; }
            // a o b = c
            switch (IAB[MAE[i]])
            {
              case 4: // a +- b = c
                for (int j = i + 1; j < MAI[MAE[i]] + MAH[MAE[i]]; j++)
                {
                  if (MAJ[j] == 1)
                  {
                    aj = CAA.Length - MAD[0] + MAC[j] - 3;
                    if (KAI[j] == "+") { ad += Convert.ToDouble(KAH[j]); }
                    if (KAI[j] == "-") { ad -= Convert.ToDouble(KAH[j]); }
                    if (ad < 0) { ah = " - " + DFAB(0 - ad); }
                    else { ah = " + " + DFAB(ad); }
                    if (KAI[i] == "") { ah = DFAB(ad); }
                    DCBC(ah, MAC[i] - ak, ai, aj, MAD[j] + 3);
                    DDAA("a ± b` = `c"); ai = ah.Length;
                  }
                  if (j == MAI[MAE[i]] + MAH[MAE[i]] - 1) { break; }
                }
                break;
              case 5: // a ·: b = c
                for (int j = i + 1; j < MAI[MAE[i]] + MAH[MAE[i]]; j++)
                {
                  if (MAJ[j] == 1)
                  {
                    aj = CAA.Length - MAD[0] + MAC[j] - 3;
                    if (KAI[j] == "·") { ad *= Convert.ToDouble(KAH[j]); }
                    if (KAI[j] == ":") { ad /= Convert.ToDouble(KAH[j]); }
                    if (KAI[i] == "") { ah = DFAB(ad); } else { ah = " · " + DFAB(ad); }
                    DCBC(ah, MAC[i] - ak, ai, aj, MAD[j] + 3);
                    DDAA("a ·: b` = `c"); ai = ah.Length;
                  }
                  if (j == MAI[MAE[i]] + MAH[MAE[i]] - 1) { break; }
                }
                break;
              case 6: // a ˄˅ b = c
                if (i == MAI[MAE[i]]) // nur erster Term darf man potenziert werden
                {
                  for (int j = i + 1; j < MAI[MAE[i]] + MAH[MAE[i]]; j++)
                  {
                    if (MAJ[j] == 1)
                    {
                      aj = CAA.Length - MAD[0] + MAC[j] - 3;
                      if (KAI[j] == "˄")
                      { ad = Java.Lang.Math.Pow(ad, Convert.ToDouble(KAH[j])); ah = DFAB(ad); }
                      if (KAI[j] == "˅")
                      { ad = Java.Lang.Math.Pow(ad, 1 / Convert.ToDouble(KAH[j])); ah = DFAB(ad); }
                      DCBC(ah, MAC[i], ai, aj, MAD[j] + 3); DDAA("a ˄˅ b` = `c"); ai = ah.Length;
                    }
                    if (j == MAI[MAE[i]] + MAH[MAE[i]] - 1) { break; }
                  }
                }
                break;
            }
            // a = b
            if (ah != "") { return; }
          }
        }
      }
      // Reihenfolge - extrahierte Reihenfolge !
      for (int i = 0; i < KAH.Count; i++)
      {
        ab = "";
        // 1. Operatorengruppen: Verallgemeinerung und Trennung
        switch (IAB[i]) //  Vorrang ab bezüglich ag
        {
          case 4:
            A_ = 0; KAI[MAI[i]] = "+"; ab = "+"; ag = "-"; break;
          case 5:
            A_ = 0; KAI[MAI[i]] = "·"; ab = "·"; ag = ":"; break;
          case 6:
            A_ = 1; if (MAH[i] > 2) { ab = "˄"; ag = "˅"; }
            ; break;
        }
        // 2. Operatorengruppe ist größer drei
        if (ab != "")
        {
          JavaList<string> av = []; MAO.Clear();
          // 2.1. Minus: Vorzeichen => Operator
          if (ab == "+")
          {
            B2 = DFAA(MAI[i]);
            if (B2 == 2 | B2 == 7)
            {
              KAI[MAI[i]] = "-";
              KAH[MAI[i]] = KAH[MAI[i]]!.TrimStart('-');
              if (B2 == 2) { IAA[MAI[i]] = 0; }
              if (B2 == 7) { IAA[MAI[i]] = 1; }
            }
          }
          MAO.Add(MAI[i] + A_);
          av.Add(KAI[MAI[i] + A_]!); av.Add(KAH[MAI[i] + A_]!);
          // 2.2. Variablen- und Operatorenvergleich
          for (int j = MAI[i] + A_ + 1; j < MAI[i] + MAH[i]; j++)
          {
            for (int k = 0; k < av.Count - 1; k += 2)
            {
              if (av[k + 1]!.CompareTo(KAH[j]) == 1
                & (av[k] == ab & KAI[j] == ag) == false)
              {
                // b.CompareTo(a) = 1   ! b.CompareTo(a) = 0 !
                av.Insert(k, KAH[j]!); av.Insert(k, KAI[j]!);
                MAO.Insert(k / 2, j); break;
              }
              if (k == av.Count - 2) // wenn kein ↑ break
              {
                MAO.Add(j); av.Add(KAI[j]!); av.Add(KAH[j]!);
                break;
              }
            }
          }
          // 2.3. Minus: Operator => Vorzeichen
          if (av[0] == "-")
          {
            switch (DFAA(MAO[0]))
            {
              case 0:
                IAA[MAO[0]] = 2; av[1] = "-" + av[1];
                KAH[MAI[i]] = "-" + KAH[MAI[i]]; break;
              case 5:
                IAA[MAO[0]] = 3; av[1] = "-" + av[1];
                KAH[MAI[i]] = "-" + KAH[MAI[i]]; break;
              case 1: av[1] = "-(" + av[1] + ")"; break;
              case 3: av[1] = "-(" + av[1] + ")"; break;
              case 4: av[1] = "-(" + av[1] + ")"; break;
              case 6: av[1] = "-(" + av[1] + ")"; break;
              case 8: av[1] = "-(" + av[1] + ")"; break;
              case 10: av[1] = "-(" + av[1] + ")"; break;
            }
          }
          ab = av[1]!; KAI[MAI[i]] = "";
          // 2.4. Variablen- und Operatorensammlung
          for (int j = 2; j < av.Count; j++) { ab += " " + av[j]; }
          // 2.5. Erste Extravariable der Operatorengruppe sechs
          if (A_ == 1) { ab = KAH[MAI[i]] + " " + av[0] + " " + ab; }
          // 2.6. Übersprung beim gleichen Ergebnis
          if (KAH[i] == ab) { continue; }
          // 2.7. Neuer Ausdruck - Ergebnis
          DCBA(ab, [MAC[i + A_], MAD[i]]);
          DDED("b` o `a` = `a` o `b"); return;
        }
      }

      // LAA()   IAA[]   Vorzeichen
      // IAB()   IAB[]   Operatorengruppe
      // HAA()   KAH[]   Term
      // HAA()   KAI[]   Operator
      // JAA()   LAA[]   Gesuchte im Nenner
      // KAA()   MAA[]   Teilungsanfang
      // KAB()   MAB[]   Funktion
      // KAC()   MAC[]   Eingangsanfang
      // KAD()   MAD[]   Eingangslänge
      // KAE()   MAE[]   Quellenteilindex
      // KAF()   MAF[]   Ausgangsanfang
      // MAG()   MAG[]   Ausgangslänge
      // KAH()   MAH[]   Ausgangsteilenanzahl
      // KAI()   MAI[]   Ausgangsteilenanfangsindex
      // KAJ()   MAJ[]   Eingangsteil-Zahl
      // KAK()   HAK[]   Innere-Zahl
      // MAM()   MAM[]   Gesuchte Variable
      // IAA()   JAA[]   Colors
      //bool zz = MAB[i] == 1 & MAH[i] == 1;
    }
    private void DBXA()
    {
      // Operatoren ±
      A_ = 0; B4 = 0; for (int i = 0; i < KAI.Count; i++) { if (KAI[i] == "±") { A_ += 1; B4 = i; } }
      if (A_ == 1) // wird nur für erstes Ergebnis von allen Ergebnisse angewendet
      {
        CAA = KAH[0]!; DCBA("+", MAC[B4] - 2, 1); DDED("a` ± `b` = `a` + `b");
        for (int j = 0; j < KAJ.Count; j++) { KAK.Add(KAJ[j]!); JAB.Add(JAA[j]); }
        ; MAR.Add(KAJ.Count);
        KAJ.Clear(); JAA.Clear(); KAC.Add(CAA); KAD.Add("a ± b = a + b");
        CAA = KAH[0]!; DCBA("-", MAC[B4] - 2, 1); DDED("a` ± `b` = `a` - `b");
        for (int j = 0; j < KAJ.Count; j++) { KAK.Add(KAJ[j]!); JAB.Add(JAA[j]); }
        ; MAR.Add(KAJ.Count);
        KAJ.Clear(); JAA.Clear(); KAC.Add(CAA); KAD.Add("a ± b = a - b"); DAAE(); EAA += 1; return;
      }
    }
    #endregion
    #region D-AC
    private void DCAA(int a, int b)
    {
      // R: 1 Stelle vor und keine nach: nur Remove ohne Insert
      DEBA("\n" + "\n" + CAA[..a]); DEBB(CAA.Substring(a, b));
      DEBA(CAA[(a + b)..]); //, CAA.Length - a - b
      CAA = CAA.Remove(a, b); DEBC('\n' + CAA);
    }
    private void DCAB(params int[] a)
    {
      // RR: 2 Stelle vor und keine nach: nur Remove ohne Insert
      DEBA("\n" + "\n" + CAA[..a[0]]); DEBB(CAA.Substring(a[0], a[1]));
      DEBA(CAA.Substring(a[0] + a[1], a[2] - a[0] - a[1])); DEBB(CAA.Substring(a[2], a[3]));
      DEBA(CAA.Substring(a[2] + a[3], CAA.Length - a[2] - a[3])); CAA = CAA.Remove(a[2], a[3]);
      CAA = CAA.Remove(a[0], a[1]); DEBC('\n' + CAA);
    }
    private void DCBA(string a, params int[] b)
    {
      // RI: 1 Stelle vor und 1 dieselbe nach: Remove und Insert
      DEBA("\n" + "\n" + CAA[..b[0]]); DEBB(CAA.Substring(b[0], b[1]));
      DEBA(CAA.Substring(b[0] + b[1], CAA.Length - b[0] - b[1]));
      CAA = CAA.Remove(b[0], b[1]); CAA = CAA.Insert(b[0], a); DEBC('\n' + CAA[..b[0]]);
      DEBB(a); DEBC(CAA.Substring(b[0] + a.Length, CAA.Length - b[0] - a.Length));
    }
    private void DCBB(string a, params int[] b)
    {
      // RI: 1 Stelle vor und 1 allgemeine nach: Insert in dieselbe oder andere Stelle
      DEBA("\n" + "\n" + CAA[..b[0]]); DEBB(CAA.Substring(b[0], b[1]));
      DEBA(CAA.Substring(b[0] + b[1], CAA.Length - b[0] - b[1])); CAA = CAA.Remove(b[0], b[1]);
      CAA = CAA.Insert(b[2], a); DEBC(string.Concat("\n", CAA.AsSpan(0, b[2]))); DEBB(a);
      DEBC(CAA.Substring(b[2] + a.Length, CAA.Length - b[2] - a.Length));
    }
    private void DCBC(string a, params int[] b)
    {
      // RRI: 2 Stelle vor und 1-te nach
      DEBA(string.Concat("\n", "\n", CAA.AsSpan(0, b[0]))); DEBB(CAA.Substring(b[0], b[1]));
      DEBA(CAA.Substring(b[0] + b[1], b[2] - b[0] - b[1])); DEBB(CAA.Substring(b[2], b[3]));
      DEBA(CAA.Substring(b[2] + b[3], CAA.Length - b[2] - b[3])); CAA = CAA.Remove(b[2], b[3]);
      CAA = CAA.Remove(b[0], b[1]); CAA = CAA.Insert(b[0], a);
      DEBC(string.Concat("\n", CAA[..b[0]])); // 
      DEBB(a); DEBC(CAA.Substring(b[0] + a.Length, CAA.Length - b[0] - a.Length));
    }
    private void DCCA(string[] a, params int[] b)
    {
      // RII: 1 Stelle vor und 2 andere nach
      int aa; aa = b[3] + a[0].Length + a[1].Length;
      DEBA(string.Concat("\n", "\n", CAA.AsSpan(0, b[0]))); DEBB(CAA.Substring(b[0], b[1]));
      DEBA(CAA.Substring(b[0] + b[1], CAA.Length - b[0] - b[1]));
      CAA = CAA.Remove(b[0], b[1]); CAA = CAA.Insert(b[3], a[1]);
      CAA = CAA.Insert(b[2], a[0]); DEBC(string.Concat("\n", CAA.AsSpan(0, b[2])));
      DEBB(a[0]); DEBC(CAA.Substring(b[2] + a[0].Length, b[3] - b[2]));
      DEBB(a[1]); DEBC(CAA[aa..]); // , CAA.Length - aa
    }
    #endregion
    #region D-AD
    private void DXAA()
    {
      // Kommentar-Formel-Farbe: R-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " "); DEBB(B1[0]); DEBD(B1[1]);
    }
    private void DXAB()
    {
      // Kommentar-Formel-Farbe: BR-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBA(B1[0]); DEBB(B1[1]); DEBD(B1[2]);
    }
    private void DXAC()
    {
      // Kommentar-Formel-Farbe: RB-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBB(B1[0]); DEBA(B1[1]); DEBD(B1[2]);
    }
    private void DXAD()
    {
      // Kommentar-Formel-Farbe: BRB-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBA(B1[0]); DEBB(B1[1]); DEBA(B1[2]); DEBD(B1[3]);
    }
    private void DXAE()
    {
      // Kommentar-Formel-Farbe: RBR-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBB(B1[0]); DEBA(B1[1]); DEBB(B1[2]); DEBD(B1[3]);
    }
    private void DXAF()
    {
      // Kommentar-Formel-Farbe: BRBR-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBA(B1[0]); DEBB(B1[1]); DEBA(B1[2]); DEBB(B1[3]); DEBD(B1[4]);
    }
    private void DXAG()
    {
      // Kommentar-Formel-Farbe: RBRB-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBB(B1[0]); DEBA(B1[1]); DEBB(B1[2]); DEBA(B1[3]); DEBD(B1[4]);
    }
    private void DXAH()
    {
      // Kommentar-Formel-Farbe: RBRBR-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " "); DEBB(B1[0]);
      DEBA(B1[1]); DEBB(B1[2]); DEBA(B1[3]); DEBB(B1[4]); DEBD(B1[5]);
    }
    private void DXAI()
    {
      // Kommentar-Formel-Farbe: BRBRBR-X
      DEBD('\n' + Resources!.GetString(Resource.String.A036) + " ");
      DEBA(B1[0]); DEBB(B1[1]); DEBA(B1[2]); DEBB(B1[3]);
      DEBA(B1[4]); DEBB(B1[5]); DEBD(B1[6]);
    }

    private void DDAA(string a)
    {
      // Kommentar-Formel-Farbe: R-R
      DEBE(a); DXAA(); DEBB(B1[2]);
    }
    private void DDCX(string a)
    {
      // Kommentar-Formel-Farbe: BR-G
      DEBE(a); DXAB(); DEBC(B1[3]);
    }
    private void DDCY(string a)
    {
      // Kommentar-Formel-Farbe: BR-GR
      DEBE(a); DXAB(); DEBC(B1[3]); DEBB(B1[4]);
    }
    private void DDCA(string a)
    {
      // Kommentar-Formel-Farbe: BR-RG
      DEBE(a); DXAB(); DEBB(B1[3]); DEBC(B1[4]);
    }
    private void DDCB(string a)
    {
      // Kommentar-Formel-Farbe: BR-GRG
      DEBE(a); DXAB(); DEBC(B1[3]); DEBB(B1[4]); DEBC(B1[5]);
    }
    private void DDCC(string a)
    {
      // Kommentar-Formel-Farbe: BR-GRGR
      DEBE(a); DXAB(); DEBC(B1[3]); DEBB(B1[4]); DEBC(B1[5]); DEBB(B1[6]);
    }
    private void DDCD(string a)
    {
      // Kommentar-Formel-Farbe: BR-RGRG
      DEBE(a); DXAB(); DEBB(B1[3]); DEBC(B1[4]); DEBB(B1[5]); DEBC(B1[6]);
    }
    private void DDCE(string a)
    {
      // Kommentar-Formel-Farbe: RB-G
      DEBE(a); DXAC(); DEBC(B1[3]);
    }
    private void DDCF(string a)
    {
      // Kommentar-Formel-Farbe: RB-RG
      DEBE(a); DXAC(); DEBB(B1[3]); DEBC(B1[4]);
    }
    private void DDCG(string a)
    {
      // Kommentar-Formel-Farbe: RB-RGR
      DEBE(a); DXAC(); DEBB(B1[3]); DEBC(B1[4]); DEBB(B1[5]);
    }
    private void DDEA(string a)
    {
      // Kommentar-Formel-Farbe: BRB-G
      DEBE(a); DXAD(); DEBC(B1[4]);
    }
    private void DDEB(string a)
    {
      // Kommentar-Formel-Farbe: BRB-GR
      DEBE(a); DXAD(); DEBC(B1[4]); DEBB(B1[5]);
    }
    private void DDED(string a)
    {
      // Kommentar-Formel-Farbe: BRB-GRG
      DEBE(a); DXAD(); DEBC(B1[4]); DEBB(B1[5]); DEBC(B1[6]);
    }
    private void DDEE(string a)
    {
      // Kommentar-Formel-Farbe: BRB-GRGR
      DEBE(a); DXAD(); DEBC(B1[4]); DEBB(B1[5]); DEBC(B1[6]); DEBB(B1[7]);
    }
    private void DDEF(string a)
    {
      // Kommentar-Formel-Farbe: BRB-GRGRG
      DEBE(a); DXAD(); DEBC(B1[4]); DEBB(B1[5]); DEBC(B1[6]); DEBB(B1[7]); DEBC(B1[8]);
    }
    private void DDEH(string a)
    {
      // Kommentar-Formel-Farbe: BRB-RG
      DEBE(a); DXAD(); DEBB(B1[4]); DEBC(B1[5]);
    }
    private void DDFA(string a)
    {
      // Kommentar-Formel-Farbe: RBR-G
      DEBE(a); DXAE(); DEBC(B1[4]);
    }
    private void DDFB(string a)
    {
      // Kommentar-Formel-Farbe: RBR-RG
      DEBE(a); DXAE(); DEBB(B1[4]); DEBC(B1[5]);
    }
    private void DDGA(string a)
    {
      // Kommentar-Formel-Farbe: BRBR-G
      DEBE(a); DXAF(); DEBC(B1[5]);
    }
    private void DDGB(string a)
    {
      // Kommentar-Formel-Farbe: BRBR-GRG
      DEBE(a); DXAF(); DEBC(B1[5]); DEBB(B1[6]); DEBC(B1[7]);
    }
    private void DDHA(string a)
    {
      // Kommentar-Formel-Farbe: RBRB-G
      DEBE(a); DXAG(); DEBC(B1[5]);
    }
    private void DDIA(string a)
    {
      // Kommentar-Formel-Farbe: RBRBR-GRG
      DEBE(a); DXAH(); DEBC(B1[6]); DEBB(B1[7]); DEBC(B1[8]);
    }
    private void DDJA(string a)
    {
      // Kommentar-Formel-Farbe: BRBRBR-GRG
      DEBE(a); DXAI(); DEBC(B1[7]); DEBB(B1[8]); DEBC(B1[9]);
    }
    #endregion
    #region D-AE
    private void DEBA(string a)
    {
      KAJ.Add(a); JAA.Add(Color.Blue);
    }
    private void DEBB(string a)
    {
      KAJ.Add(a); JAA.Add(Color.Magenta);
    }
    private void DEBC(string a)
    {
      KAJ.Add(a); JAA.Add(Color.LimeGreen);
    }
    private void DEBD(string a)
    {
      KAJ.Add(a); JAA.Add(Color.DeepSkyBlue);
    }
    private void DEBE(string a)
    {
      B1 = a.Split("`");
    }
    private void DEBF(string a)
    {
      DEBD("   " + a + " = 2 k + 1, k є N"); // ∈ ℕ
    }
    #endregion
    #region D-AF
    private byte DFAA(int a)
    {
      byte b = IAA[a];
      if (b == 1 | b == 3) // 0 2 / 1 : 3 - 4 5 : 6 7 / 8 10
      {
        int aa, ab; aa = a;
        if (IAB[a] == 5) { aa = MAI[a]; b += 3; }
        ab = MAI[aa] + 1;
        if (MAH[a] == 2 & KAI[ab] == "˄" &
          uint.TryParse(KAH[ab], out _) == true)
        {
          switch (KAH[ab]!.Substring(MAD[ab] - 1, 1))
          {
            case "0": b = (byte)(IAA[a] + 7); break;
            case "1": b = (byte)(IAA[a] + 4); break;
            case "2": b = (byte)(IAA[a] + 7); break;
            case "3": b = (byte)(IAA[a] + 4); break;
            case "4": b = (byte)(IAA[a] + 7); break;
            case "5": b = (byte)(IAA[a] + 4); break;
            case "6": b = (byte)(IAA[a] + 7); break;
            case "7": b = (byte)(IAA[a] + 4); break;
            case "8": b = (byte)(IAA[a] + 7); break;
            case "9": b = (byte)(IAA[a] + 4); break;
          }
        }
      }
      return b;
    }
    private string DFAB(double a)
    {
      return a.ToString().Replace("E+", " · 10 ^ ").Replace("E-0", " · 10 ^ -").Replace("E-", " · 10 ^ -");
    }
    #endregion
    #endregion
    // * EEEE * EEEE * EEEE * EEEE *
    #region EEEE
    #region E-AA
    private void EAAA()
    {
      string[] AA; CAF = ""; AA = A101.Text!.Split(' ');
      // 1     Dimensionen in A103
      for (int f = 0; f < FAA.Length; f++)
      {
        AA[f] = FAA[f] + "     "; AA[f] = AA[f][..5];
        if (f == 0) { AA[f] += "= ?"; } else { AA[f] += "= "; }
        if (f < FAA.Length - 1) { AA[f] += "\n"; }
        for (int i = 0; i < FAB.Length - 2; i += 3)
        {
          if (FAA[f] == FAB[i])
          {
            CAF += FAA[f] + " = " + FAB[i + 1] + "\n";
            A103.Text += AA[f]; MAP.Add(i);
            MAO.Add(Convert.ToInt32(FAB[i + 2])); break;
          }
        }
      }
    }
    private void EAAB()
    {
      // 1     Formelsuchen 1
      CAD = A101.Text!; EAAC();
      // 2     Kode bearbeiten und Formel suchen
      // ...
    }
    private void EAAC()
    {
      // 1     Laden von Formeln, wenn sie nicht schon einmal geladen worden sind
      string[] AA = CAD.Split(" ");
      if (CAI != AA[0])
      {
        if (AA[0] == FAB[0])
        {
          FAC = ["a ax", "a = ax", "", "0", "4",
         "a ay", "a = ay", "", "0", "",
         "a az", "a = az", "", "0", "",
         "a ax θ", "a = ax : cos(θ)", "", "0", "",
         "a ay θ", "a = ay : sin(θ)", "", "0", "",
         "a az θ", "a = az : cos(θ)", "", "0", "",
         "a ax θ ϕ", "a = ax : cos(θ) : sin(ϕ)", "", "0", "",
         "a az θ ϕ", "a = az : cos(θ) : cos(ϕ)", "", "0", "",
         "a ax ay", "a = √(ax ^ 2 + ay ^ 2)", "", "0", "",
         "a ax az", "a = √(ax ^ 2 + az ^ 2)", "", "0", "",
         "a ay az", "a = √(ay ^ 2 + az ^ 2)", "", "0", "",
         "a ax ay az", "a = √(ax ^ 2 + ay ^ 2 + az ^ 2)", "", "0", "",
         "a F k P v1", "a = -2 k P (P : F - v1) : F ^ 2", "a F k v1 {v}", "62", "",
         "a F k P v2", "a = -2 k P (v2 - P : F) : F ^ 2", "a F k v1 {v}", "62", "",
         "a F k P Δv", "a = -k P Δv : F ^ 2", "a F k Δv {v}", "62", "",
         "a F k Δt v1", "a = -2 (F : k : Δt + v1) : Δt", "a Δs Δt v1", "59", "",
         "a F k Δt v2", "a = 2 (v2 + F : k : Δt) : Δt", "a Δs Δt v2", "59", "",
         "a F k v1 v2", "a = -k (v2 ^ 2 - v1 ^ 2) : F : 2", "a F k Δv {v}", "19", "",
         "a F k v1 Δv", "a = -k Δv (v1 + Δv : 2) : F", "a F k Δv {v}", "18", "",
         "a F k v1 {v}", "a = -2 k {v} ({v} - v1) : F", "a F k Δv {v}", "16", "",
         "a F k v2 Δv", "a = -k Δv (v2 - Δv : 2) : F", "a F k Δv {v}", "15", "",
         "a F k v2 {v}", "a = -2 k {v} (v2 - {v}) : F", "a F k Δv {v}", "13", "",
         "a F k Δv {v}", "a = -k Δv {v} : F", "a k m Δv {v}", "28", "",
         "a F m", "a = F : m", "", "27", "",
         "a F P Δs v1", "a = 2 (P ^ 2 : F - v1 P) : F : Δs", "a F P v1 W", "29", "",
         "a F P Δs v2", "a = 2 (P v2 - P ^ 2 : F) : F : Δs", "a F P v2 W", "29", "",
         "a F P Δs Δv", "a = P Δv : F : Δs", "a P Δv W", "29", "",
         "a F P Δt v1", "a = 2 (P : F - v1) : Δt", "a F Δt v1 W", "62", "",
         "a F P Δt v2", "a = 2 (v2 - P : F) : Δt", "a F Δt v2 W", "62", "",
         "a F P v1 W", "a = 2 P (P : F - v1) : W", "a F P Δt v1", "43", "",
         "a F P v2 W", "a = 2 P (v2 - P : F) : W", "a F P Δt v2", "43", "",
         "a F Δt v1 W", "a = 2 (W : F : Δt - v1) : Δt", "a Δs Δt v1", "31", "",
         "a F Δt v2 W", "a = 2 (v2 - W : F : Δt) : Δt", "a Δs Δt v2", "31", "",
         "a F v1 v2 W", "a = F (v2 ^ 2 - v1 ^ 2) : W : 2", "a F Δv {v} W", "19", "",
         "a F v1 Δv W", "a = F Δv (v1 + Δv : 2) : W", "a F Δv {v} W", "18", "",
         "a F v1 {v} W", "a = 2 F {v} ({v} - v1) : W", "a F Δv {v} W", "16", "",
         "a F v2 Δv W", "a = F Δv (v2 - Δv : 2) : W", "a F Δv {v} W", "15", "",
         "a F v2 {v} W", "a = 2 F {v} (v2 - {v}) : W", "a F Δv {v} W", "13", "",
         "a F Δv {v} W", "a = F Δv {v} : W", "a Δs Δv {v}", "31", "",
         "a |Fn| m μg", "a = |Fn| μg : m", "a F m", "85", "",
         "a |Fn| m μh", "a = |Fn| μh : m", "a F m", "88", "",
         "a |Fn| m μr", "a = |Fn| μr : m", "a F m", "91", "",
         "a |Fn| μg P Δs v1", "a = 2 P (P : |Fn| : μg - v1) : |Fn| : μg : Δs", "a F P Δs v1", "85", "",
         "a |Fn| μg P Δs v2", "a = 2 P (v2 - P : |Fn| : μg) : |Fn| : μg : Δs", "a F P Δs v2", "85", "",
         "a |Fn| μg P Δs Δv", "a = P Δv : |Fn| : μg : Δs", "a F P Δs Δv", "85", "",
         "a |Fn| μg P Δt v1", "a = 2 (P : |Fn| : μg - v1) : Δt", "a F P Δt v1", "85", "",
         "a |Fn| μg P Δt v2", "a = 2 (v2 - P : |Fn| : μg) : Δt", "a F P Δt v2", "85", "",
         "a |Fn| μg P v1 W", "a = 2 P (P : |Fn| : μg - v1) : W", "a F P v1 W", "85", "",
         "a |Fn| μg P v2 W", "a = 2 P (v2 - P : |Fn| : μg) : W", "a F P v2 W", "85", "",
         "a |Fn| μg Δt v1 W", "a = 2 (W : |Fn| : μg : Δt - v1) : Δt", "a F Δt v1 W", "85", "",
         "a |Fn| μg Δt v2 W", "a = 2 (v2 - W : |Fn| : μg : Δt) : Δt", "a F Δt v2 W", "85", "",
         "a |Fn| μg v1 v2 W", "a = |Fn| μg (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "85", "",
         "a |Fn| μg v1 Δv W", "a = |Fn| μg Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "85", "",
         "a |Fn| μg v1 {v} W", "a = 2 |Fn| μg {v} ({v} - v1) : W", "a F v1 {v} W", "85", "",
         "a |Fn| μg v2 Δv W", "a = |Fn| μg (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "85", "",
         "a |Fn| μg v2 {v} W", "a = 2 |Fn| μg {v} (v2 - {v}) : W", "a F v2 {v} W", "85", "",
         "a |Fn| μg Δv {v} W", "a = |Fn| μg Δv {v} : W", "a F Δv {v} W", "85", "",
         "a |Fn| μh P Δs v1", "a = 2 P (P : |Fn| : μh - v1) : |Fn| : μh : Δs", "a F P Δs v1", "88", "",
         "a |Fn| μh P Δs v2", "a = 2 P (v2 - P : |Fn| : μh) : |Fn| : μh : Δs", "a F P Δs v2", "88", "",
         "a |Fn| μh P Δs Δv", "a = P Δv : |Fn| : μh : Δs", "a F P Δs Δv", "88", "",
         "a |Fn| μh P Δt v1", "a = 2 (P : |Fn| : μh - v1) : Δt", "a F P Δt v1", "88", "",
         "a |Fn| μh P Δt v2", "a = 2 (v2 - P : |Fn| : μh) : Δt", "a F P Δt v2", "88", "",
         "a |Fn| μh P v1 W", "a = 2 P (P : |Fn| : μh - v1) : W", "a F P v1 W", "88", "",
         "a |Fn| μh P v2 W", "a = 2 P (v2 - P : |Fn| : μh) : W", "a F P v2 W", "88", "",
         "a |Fn| μh Δt v1 W", "a = 2 (W : |Fn| : μh : Δt - v1) : Δt", "a F Δt v1 W", "88", "",
         "a |Fn| μh Δt v2 W", "a = 2 (v2 - W : |Fn| : μh : Δt) : Δt", "a F Δt v2 W", "88", "",
         "a |Fn| μh v1 v2 W", "a = |Fn| μh (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "88", "",
         "a |Fn| μh v1 Δv W", "a = |Fn| μh Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "88", "",
         "a |Fn| μh v1 {v} W", "a = 2 |Fn| μh {v} ({v} - v1) : W", "a F v1 {v} W", "88", "",
         "a |Fn| μh v2 Δv W", "a = |Fn| μh (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "88", "",
         "a |Fn| μh v2 {v} W", "a = 2 |Fn| μh {v} (v2 - {v}) : W", "a F v2 {v} W", "88", "",
         "a |Fn| μh Δv {v} W", "a = |Fn| μh Δv {v} : W", "a F Δv {v} W", "88", "",
         "a |Fn| μr P Δs v1", "a = 2 P (P : |Fn| : μr - v1) : |Fn| : μr : Δs", "a F P Δs v1", "91", "",
         "a |Fn| μr P Δs v2", "a = 2 P (v2 - P : |Fn| : μr) : |Fn| : μr : Δs", "a F P Δs v2", "91", "",
         "a |Fn| μr P Δs Δv", "a = P Δv : |Fn| : μr : Δs", "a F P Δs Δv", "91", "",
         "a |Fn| μr P Δt v1", "a = 2 (P : |Fn| : μr - v1) : Δt", "a F P Δt v1", "91", "",
         "a |Fn| μr P Δt v2", "a = 2 (v2 - P : |Fn| : μr) : Δt", "a F P Δt v2", "91", "",
         "a |Fn| μr P v1 W", "a = 2 P (P : |Fn| : μr - v1) : W", "a F P v1 W", "91", "",
         "a |Fn| μr P v2 W", "a = 2 P (v2 - P : |Fn| : μr) : W", "a F P v2 W", "91", "",
         "a |Fn| μr Δt v1 W", "a = 2 (W : |Fn| : μr : Δt - v1) : Δt", "a F Δt v1 W", "91", "",
         "a |Fn| μr Δt v2 W", "a = 2 (v2 - W : |Fn| : μr : Δt) : Δt", "a F Δt v2 W", "91", "",
         "a |Fn| μr v1 v2 W", "a = |Fn| μr (v2 ^ 2 - v1 ^ 2) : 2 : W", "a F v1 v2 W", "91", "",
         "a |Fn| μr v1 Δv W", "a = |Fn| μr Δv (v1 + Δv : 2) : W", "a F v1 Δv W", "91", "",
         "a |Fn| μr v1 {v} W", "a = 2 |Fn| μr {v} ({v} - v1) : W", "a F v1 {v} W", "91", "",
         "a |Fn| μr v2 Δv W", "a = |Fn| μr (v2 - Δv : 2) Δv : W", "a F v2 Δv W", "91", "",
         "a |Fn| μr v2 {v} W", "a = 2 |Fn| μr {v} (v2 - {v}) : W", "a F v2 {v} W", "91", "",
         "a |Fn| μr Δv {v} W", "a = |Fn| μr Δv {v} : W", "a F Δv {v} W", "91", "",
         "a k m P Δt", "a = √(-k P Δt) : m", "a k m W", "44", "",
         "a k m P Δv", "a = √(-k P Δv : m ^ 2 ' 3)", "a k m P Δt", "25", "",
         "a k m Δs", "a = -k Δs : m", "a F m", "57", "",
         "a k m Δt v1", "a = -v1 : (Δt : 2 + m : k : Δt)", "a F k Δt v1", "26", "",
         "a k m Δt v2", "a = v2 : (Δt : 2 - m : k : Δt)", "a F k Δt v2", "26", "",
         "a k m Δt {v}", "a = -k Δt {v} : m", "a k m Δs", "21", "",
         "a k m v1 v2", "a = √(-k (v2 ^ 2 - v1 ^ 2) : m : 2)", "a k m Δv {v}", "19", "",
         "a k m v1 Δv", "a = √(-k Δv (v1 + Δv : 2) : m)", "a k m Δv {v}", "18", "",
         "a k m v1 {v}", "a = √(-2 k {v} ({v} - v1) : m)", "a k m Δv {v}", "16", "",
         "a k m v2 Δv", "a = √(-k Δv (v2 - Δv : 2) : m)", "a k m Δv {v}", "15", "",
         "a k m v2 {v}", "a = √(-2 k {v} (v2 - {v}) : m)", "a k m Δv {v}", "13", "",
         "a k m Δv {v}", "a = √(-k Δv {v} : m)", "a k m Δt {v}", "25", "",
         "a k m W", "a = √(-k W) : m", "a k m Δv {v}", "75", "",
         "a k P Δs v1", "a = 2 P (P : k : Δs + v1) : k : Δs ^ 2", "a F P Δs v1", "57", "",
         "a k P Δs v2", "a = -2 P (v2 + P : k : Δs) : k : Δs ^ 2", "a F P Δs v2", "57", "",
         "a k P Δs Δv", "a = -P Δv : k : Δs ^ 2", "a F k P Δv", "57", "",
         "a k P Δt v1", "a = 2 (√(-P : k : Δt) - v1) : Δt", "a k Δt v1 W", "44", "",
         "a k P Δt v2", "a = 2 (v2 - √(-P : k : Δt)) : Δt", "a k Δt v2 W", "44", "",
         "a k P v1 v2", "a = -k (v2 - v1) (v1 + v2) ^ 2 : P : 4", "a k P Δv {v}", "19", "",
         "a k P v1 Δv", "a = -k Δv (v1 + Δv : 2) ^ 2 : P", "a k P Δv {v}", "18", "",
         "a k P v1 {v}", "a = -2 k ({v} - v1) {v} ^ 2 : P", "a k P Δv {v}", "16", "",
         "a k P v1 W", "a = 2 P (√(-(P ^ 2) : k : W) - v1) : W", "a k Δt v1 W", "43", "",
         "a k P v2 Δv", "a = -k Δv (v2 - Δv : 2) ^ 2 : P", "a k P Δv {v}", "15", "",
         "a k P v2 {v}", "a = -2 k (v2 - {v}) {v} ^ 2 : P", "a k P Δv {v}", "13", "",
         "a k P v2 W", "a = 2 P (v2 - √(-(P ^ 2) : k : W)) : W", "a k Δt v2 W", "43", "",
         "a k P Δv {v}", "a = -k Δv {v} ^ 2 : P", "a F k Δv {v}", "61", "",
         "a k Δt v1 W", "a = 2 (√(-W : k) : Δt - v1) : Δt", "a k v1 Δv W", "24", "",
         "a k Δt v2 W", "a = 2 (v2 - √(-W : k) : Δt) : Δt", "a k v2 Δv W", "24", "",
         "a k v1 v2 W", "a = √(-k : W) (v2 ^ 2 - v1 ^ 2) : 2", "a k Δv {v} W", "19", "",
         "a k v1 Δv W", "a = √(-k : W) Δv (v1 + Δv : 2)", "a k Δv {v} W", "18", "",
         "a k v1 {v} W", "a = 2 √(-k : W) {v} ({v} - v1)", "a k Δv {v} W", "16", "",
         "a k v2 Δv W", "a = √(-k : W) Δv (v2 - Δv : 2)", "a k Δv {v} W", "15", "",
         "a k v2 {v} W", "a = 2 √(-k : W) {v} (v2 - {v})", "a k Δv {v} W", "13", "",
         "a k Δv {v} W", "a = √(-k : W) Δv {v}", "a k m Δv {v}", "78", "",
         "a m P Δs Δt", "a = P Δt : m : Δs", "a m Δs W", "44", "",
         "a m P Δs Δv", "a = √(P Δv : m : Δs)", "a F P Δs Δv", "26", "",
         "a m P Δt v1", "a = (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : Δt", "a m Δt v1 W", "44", "",
         "a m P Δt v2", "a = (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : Δt", "a m Δt v2 W", "44", "",
         "a m P v1 v2", "a = 2 P : m : (v1 + v2)", "a m P {v}", "10", "",
         "a m P v1 Δv", "a = P : m : (v1 + Δv : 2)", "a m P {v}", "18", "",
         "a m P v1 W", "a = 2 P : m : (v1 ± √(v1 ^ 2 + 2 W : m))", "a m Δt v1 W", "43", "",
         "a m P v2 Δv", "a = P : m : (v2 - Δv : 2)", "a m P {v}", "15", "",
         "a m P v2 W", "a = 2 P : m : (v2 ± √(v2 ^ 2 - 2 W : m))", "a m Δt v2 W", "43", "",
         "a m P {v}", "a = P : m : {v}", "a m Δt {v} W", "61", "",
         "a m Δs W", "a = W : m : Δs", "a F m", "30", "",
         "a m Δt v1 W", "a = (-v1 ± √(v1 ^ 2 + 2 W : m)) : Δt", "a F Δt v1 W", "26", "",
         "a m Δt v2 W", "a = (v2 ± √(v2 ^ 2 - 2 W : m)) : Δt", "a F Δt v2 W", "26", "",
         "a m Δt {v} W", "a = W : m : Δt : {v}", "a m Δs W", "21", "",
         "a P Δs v1 W", "a = 2 P (P Δs : W - v1) : W", "a F P v1 W", "30", "",
         "a P Δs v2 W", "a = 2 P (v2 - P Δs : W) : W", "a F P v2 W", "30", "",
         "a P v1 {v} W", "a = 2 P ({v} - v1) : W", "a Δt v1 {v}", "43", "",
         "a P v2 {v} W", "a = 2 P (v2 - {v}) : W", "a Δt v2 {v}", "43", "",
         "a P Δv W", "a = P Δv : W", "a Δt Δv", "43", "",
         "a Δs Δt v1", "a = 2 (Δs : Δt - v1) : Δt", "a Δt v1 {v}", "20", "",
         "a Δs Δt v2", "a = 2 (v2 - Δs : Δt) : Δt", "a Δt v2 {v}", "20", "",
         "a Δs v1 v2", "a = (v2 ^ 2 - v1 ^ 2) : Δs : 2", "a Δs Δv {v}", "19", "",
         "a Δs v1 Δv", "a = (v1 + Δv : 2) Δv : Δs", "a Δs Δv {v}", "18", "",
         "a Δs v1 {v}", "a = 2 {v} ({v} - v1) : Δs", "a Δs Δv {v}", "16", "",
         "a Δs v2 Δv", "a = Δv (v2 - Δv : 2) : Δs", "a Δs Δv {v}", "15", "",
         "a Δs v2 {v}", "a = 2 {v} (v2 - {v}) : Δs", "a Δs Δv {v}", "13", "",
         "a Δs Δv {v}", "a = Δv {v} : Δs", "a Δt Δv", "22", "", "",
         "a Δt v1 {v}", "a = 2 ({v} - v1) : Δt", "a Δt Δv", "16", "",
         "a Δt v2 {v}", "a = 2 (v2 - {v}) : Δt", "a Δt Δv", "13", "",
         "a Δt Δv", "a = Δv : Δt", "", "23", ""];
          CAI = AA[0];
        } // a
        if (AA[0] == FAB[3])
        {
          FAC = [
            "ax a", "ax = a", "", "0", "",
            "ax a θ", "ax = a cos(θ)", "", "0", "",
            "ax ay θ", "ax = ay : tan(θ)", "", "0", "",
            "ax az ϕ", "ax = az tan(ϕ)", "", "0", "",
            "ax a ay", "ax = √(a ^ 2 - ay ^ 2)", "", "0", "",
            "ax a az", "ax = √(a ^ 2 - az ^ 2)", "", "0", "",
            "ax a θ ϕ", "ax = a cos(θ) sin(ϕ)", "", "0", "",
            "ax ay θ ϕ", "ax = ay sin(ϕ) : tan(θ)", "", "0", "",
            "ax a ay az", "ax = √(a ^ 2 - ay ^ 2 - az ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // ax
        if (AA[0] == FAB[6])
        {
          FAC = [
         "ay a", "ay = a", "", "0", "",
         "ay a θ", "ay = a sin(θ)", "", "0", "",
         "ay ax θ", "ay = ax tan(θ)", "", "0", "",
         "ay az θ", "ay = az tan(θ)", "", "0", "",
         "ay a ax", "ay = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "ay a az", "ay = √(a ^ 2 - az ^ 2)", "", "0", "",
         "ay ax θ ϕ", "ay = ax tan(θ) : sin(ϕ)", "", "0", "",
         "ay az θ ϕ", "ay = az tan(θ) : cos(ϕ)", "", "0", "",
         "ay a ax az", "ay = √(a ^ 2 - ax ^ 2 - az ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // ay
        if (AA[0] == FAB[9])
        {
          FAC = [
         "az a", "az = a", "", "0", "",
         "az a θ", "az = a cos(θ)", "", "0", "",
         "az ax ϕ", "az = ax : tan(ϕ)", "", "0", "",
         "az ay θ", "az = ay : tan(θ)", "", "0", "",
         "az a ax", "az = √(a ^ 2 - ax ^ 2)", "", "0", "",
         "az a ay", "az = √(a ^ 2 - ay ^ 2)", "", "0", "",
         "az ay θ ϕ", "az = ay cos(ϕ) : tan(θ)", "", "0", "",
         "az a θ ϕ", "az = a cos(θ) cos(ϕ)", "", "0", "",
         "az a ax ay", "az = √(a ^ 2 - ax ^ 2 - ay ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // az
        if (AA[0] == FAB[12])
        {
          FAC = [
         "c M m V", "c = m : M : V", "c n V", "50", "",
         "c n V", "c = n : V", "", "45", ""];
          CAI = AA[0];
        } // c
        if (AA[0] == FAB[15])
        {
          FAC = [
         "Ek1 Ek2 ΔEk", "Ek1 = Ek2 - ΔEk", "", "37", "",
         "Ek1 Ek2 Ep1 Ep2", "Ek1 = Ek2 + Ep2 - Ep1", "Ek1 Ek2 ΔEp", "39", "",
         "Ek1 Ek2 ΔEp", "Ek1 = Ek2 + ΔEp", "Ek1 Ek2 W", "34", "",
         "Ek1 Ek2 W", "Ek1 = Ek2 - W", "Ek1 Ek2 ΔEk", "33", ""];
          CAI = AA[0];
        } // Ek1
        if (AA[0] == FAB[18])
        {
          FAC = [
         "Ek2 Ek1 ΔEk", "Ek2 = Ek1 + ΔEk", "", "38", "",
         "Ek2 Ek1 Ep1 Ep2", "Ek2 = Ek1 + Ep1 - Ep2", "Ek2 Ek1 ΔEp", "39", "",
         "Ek2 Ek1 ΔEp", "Ek2 = Ek1 - ΔEp", "Ek2 Ek1 W", "34", "",
         "Ek2 Ek1 W", "Ek2 = Ek1 + W", "Ek2 Ek1 ΔEk", "33", ""];
          CAI = AA[0];
        } // Ek2
        if (AA[0] == FAB[21])
        {
          FAC = [
         "ΔEk Ek1 Ek2", "ΔEk = Ek2 - Ek1", "", "36", "",
         "ΔEk Ep1 Ep2", "ΔEk = Ep1 - Ep2", "ΔEk ΔEp", "39", "",
         "ΔEk ΔEp", "ΔEk = -ΔEp", "ΔEk W", "34", "",
         "ΔEk W", "ΔEk = W", "", "33", ""];
          CAI = AA[0];
        } // ΔEk
        if (AA[0] == FAB[24])
        {
          FAC = [
         "Ep1 Ep2 Ek1 Ek2", "Ep1 = Ep2 + Ek2 - Ek1", "Ep1 ΔEk Ep2", "36", "",
         "Ep1 ΔEk Ep2", "Ep1 = Ep2 + ΔEk", "Ep1 Ep2 W", "32", "",
         "Ep1 Ep2 ΔEp", "Ep1 = Ep2 - ΔEp", "", "40", "",
         "Ep1 Ep2 W", "Ep1 = Ep2 + W", "Ep1 Ep2 ΔEp", "35", ""];
          CAI = AA[0];
        } // Ep1
        if (AA[0] == FAB[27])
        {
          FAC = [
         "Ep2 Ek1 Ek2 Ep2", "Ep2 = Ep1 + Ek1 - Ek2", "Ep2 ΔEk Ep1", "36", "",
         "Ep2 ΔEk Ep1", "Ep2 = Ep1 - ΔEk", "Ep2 Ep1 W", "32", "",
         "Ep2 Ep1 ΔEp", "Ep2 = Ep1 + ΔEp", "", "41", "",
         "Ep2 Ep1 W", "Ep2 = Ep1 - W", "Ep2 Ep1 ΔEp", "35", ""];
          CAI = AA[0];
        } // Ep2
        if (AA[0] == FAB[30])
        {
          FAC = [
         "ΔEp Ek1 Ek2", "ΔEp = Ek1 - Ek2", "ΔEp ΔEk", "36", "",
         "ΔEp ΔEk", "ΔEp = -ΔEk", "ΔEp W", "32", "",
         "ΔEp Ep1 Ep2", "ΔEp = Ep2 - Ep1", "", "39", "",
         "ΔEp W", "ΔEp = -W", "", "35", ""];
          CAI = AA[0];
        } // ΔEp
        if (AA[0] == FAB[33])
        {
          FAC = [
         "F a k P Δv", "F = √(-k P Δv : a)", "F k P Δt", "25", "",
         "F a k Δt v1", "F = -k Δt (v1 + a Δt : 2)", "F k Δt v1 Δv", "24", "",
         "F a k Δt v2", "F = -k Δt (v2 - a Δt : 2)", "F k Δt v2 Δv", "24", "",
         "F a k v1 v2", "F = -k (v2 ^ 2 - v1 ^ 2) : a : 2", "F a k Δv {v}", "19", "",
         "F a k v1 Δv", "F = -k Δv (v1 + Δv : 2) : a", "F a k Δv {v}", "18", "",
         "F a k v1 {v}", "F = -2 k {v} ({v} - v1) : a", "F a k Δv {v}", "16", "",
         "F a k v2 Δv", "F = -k Δv (v2 - Δv : 2) : a", "F a k Δv {v}", "15", "",
         "F a k v2 {v}", "F = -2 k {v} (v2 - {v}) : a", "F a k Δv {v}", "13", "",
         "F a k Δv {v}", "F = -k Δv {v} : a", "F k Δt {v}", "25", "",
         "F a m", "F = a m", "", "26", "",
         "F a P Δs v1", "F = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : Δs", "F a P v1 W", "29", "",
         "F a P Δs v2", "F = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : Δs", "F a P v2 W", "29", "",
         "F a P Δs Δv", "F = P Δv : a : Δs", "F P Δs Δt", "25", "",
         "F a P Δt v1", "F = P : (v1 + a Δt : 2)", "F P v1 Δv", "24", "",
         "F a P Δt v2", "F = P : (v2 - a Δt : 2)", "F P v2 Δv", "24", "",
         "F a P v1 W", "F = 2 a W : ((a W : P) ^ 2 + 2 a v1 W : P)", "F a P Δt v1", "43", "",
         "F a P v2 W", "F = 2 a W : (2 a v2 W : P - (a W : P) ^ 2)", "F a P Δt v2", "43", "",
         "F a Δt v1 W", "F = W : Δt : (v1 + a Δt : 2)", "F Δt v1 Δv W", "24", "",
         "F a Δt v2 W", "F = W : Δt : (v2 - a Δt : 2)", "F Δt v2 Δv W", "24", "",
         "F a v1 v2 W", "F = 2 a W : (v2 ^ 2 - v1 ^ 2)", "F a Δv {v} W", "19", "",
         "F a v1 Δv W", "F = a W : Δv : (v1 + Δv : 2)", "F a Δv {v} W", "18", "",
         "F a v1 {v} W", "F = a W : {v} : ({v} - v1) : 2", "F a Δv {v} W", "16", "",
         "F a v2 Δv W", "F = a W : Δv : (v2 - Δv : 2)", "F a Δv {v} W", "15", "",
         "F a v2 {v} W", "F = a W : {v} : (v2 - {v}) : 2", "F a Δv {v} W", "13", "",
         "F a Δv {v} W", "F = a W : Δv : {v}", "F Δt {v} W", "25", "",
         "F Ff", "F = Ff", "", "0", "",
         "F Ff Frg", "F = Ff + Frg", "", "0", "",
         "F Ff Frg Ft", "F = Ft + Ff + Frg", "", "0", "",
         "F Ff Frh", "F = Ff + Frh", "", "0", "",
         "F Ff Frh Ft", "F = Ft + Ff + Frh", "", "0", "",
         "F Ff Frr", "F = Ff + Frr", "", "0", "",
         "F Ff Frr Ft", "F = Ft + Ff + Frr", "", "0", "",
         "F Ff |Fn| μg", "F = Ff + μg |Fn|", "", "0", "",
         "F Ff |Fn| μh", "F = Ff + μh |Fn|", "", "0", "",
         "F Ff |Fn| μr", "F = Ff + μr |Fn|", "", "0", "",
         "F Ff |Fn| Ft μg", "F = Ft + Ff + μg |Fn|", "", "0", "",
         "F Ff |Fn| Ft μh", "F = Ft + Ff + μh |Fn|", "", "0", "",
         "F Ff |Fn| Ft μr", "F = Ft + Ff + μr |Fn|", "", "0", "",
         "F Ff Ft", "F = Ft + Ff", "", "0", "",
         "F |Fn| Ft k μg Δs", "F = Ft + μg |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft k μh Δs", "F = Ft + μh |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft k μr Δs", "F = Ft + μr |Fn| - k Δs", "", "0", "",
         "F |Fn| Ft μg", "F = Ft + μg |Fn|", "", "0", "",
         "F |Fn| Ft μh", "F = Ft + μh |Fn|", "", "0", "",
         "F |Fn| Ft μr", "F = Ft + μr |Fn|", "", "0", "",
         "F |Fn| k μg Δs", "F = μg |Fn| - k Δs", "", "0", "",
         "F |Fn| k μh Δs", "F = μh |Fn| - k Δs", "", "0", "",
         "F |Fn| k μr Δs", "F = μr |Fn| - k Δs", "", "0", "",
         "F |Fn| μg", "F = μg |Fn|", "", "0", "",
         "F |Fn| μh", "F = μh |Fn|", "", "0", "",
         "F |Fn| μr", "F = μr |Fn|", "", "0", "",
         "F Frg", "F = Frg", "", "0", "",
         "F Frg Ft", "F = Ft + Frg", "", "0", "",
         "F Frg Ft k Δs", "F = Ft + Frg - k Δs", "", "0", "",
         "F Frg k Δs", "F = Frg - k Δs", "", "0", "",
         "F Frh", "F = Frh", "", "0", "",
         "F Frh Ft", "F = Ft + Frh", "", "0", "",
         "F Frh Ft k Δs", "F = Ft + Frh - k Δs", "", "0", "",
         "F Frh k Δs", "F = Frh - k Δs", "", "0", "",
         "F Frr", "F = Frr", "", "0", "",
         "F Frr Ft", "F = Ft + Frr", "", "0", "",
         "F Frr Ft k Δs", "F = Ft + Frr - k Δs", "", "0", "",
         "F Frr k Δs", "F = Frr - k Δs", "", "0", "",
         "F Ft k Δs", "F = Ft - k Δs", "", "0", "",
         "F Fx", "F = Fx", "", "0", "",
         "F Fy", "F = Fy", "", "0", "",
         "F Fz", "F = Fz", "", "0", "",
         "F Fx θ", "F = Fx : cos(θ)", "", "0", "",
         "F Fy θ", "F = Fy : sin(θ)", "", "0", "",
         "F Fz θ", "F = Fz : cos(θ)", "", "0", "",
         "F Fx θ ϕ", "F = Fx : cos(θ) : sin(ϕ)", "", "0", "",
         "F Fz θ ϕ", "F = Fz : cos(θ) : cos(ϕ)", "", "0", "",
         "F Fx Fy", "F = √(Fx ^ 2 + Fy ^ 2)", "", "0", "",
         "F Fx Fz", "F = √(Fx ^ 2 + Fz ^ 2)", "", "0", "",
         "F Fy Fz", "F = √(Fy ^ 2 + Fz ^ 2)", "", "0", "",
         "F Fx Fy Fz", "F = √(Fx ^ 2 + Fy ^ 2 + Fz ^ 2)", "", "0", "",
         "F k m P Δv", "F = √(-k m P Δv ' 3)", "F a k P Δv", "27", "",
         "F k m Δt v1", "F = -v1 : (1 : k : Δt + Δt : m : 2)", "F a k Δt v1", "27", "",
         "F k m Δt v2", "F = v2 : (Δt : m : 2 - 1 : k : Δt)", "F a k Δt v2", "27", "",
         "F k m v1 v2", "F = √(-k m (v2 ^ 2 - v1 ^ 2) : 2)", "F k m Δv {v}", "19", "",
         "F k m v1 Δv", "F = √(-k m Δv (v1 + Δv : 2))", "F k m Δv {v}", "18", "",
         "F k m v1 {v}", "F = √(-2 k m {v} ({v} - v1))", "F k m Δv {v}", "16", "",
         "F k m v2 Δv", "F = √(-k m Δv (v2 - Δv : 2))", "F k m Δv {v}", "15", "",
         "F k m v2 {v}", "F = √(-2 k m {v} (v2 - {v}))", "F k m Δv {v}", "13", "",
         "F k m Δv {v}", "F = √(-k m Δv {v})", "F a k Δv {v}", "27", "",
         "F k P Δt", "F = √(-k P Δt)", "F k W", "44", "",
         "F k Δs", "F = -k Δs", "", "57", "",
         "F k Δt v1 v2", "F = -k Δt (v1 + v2) : 2", "F k Δt {v}", "10", "",
         "F k Δt v1 Δv", "F = -k Δt (v1 + Δv : 2)", "F k Δt {v}", "18", "",
         "F k Δt v2 Δv", "F = -k Δt (v2 - Δv : 2)", "F k Δt {v}", "15", "",
         "F k Δt {v}", "F = -k Δt {v}", "F k Δs", "21", "",
         "F k W", "F = √(-k W)", "F k Δs", "31", "",
         "F m P Δs Δv", "F = √(P m Δv : Δs)", "F a P Δs Δv", "29", "",
         "F m P Δt v1", "F = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : Δt", "F m Δt v1 W", "44", "",
         "F m P Δt v2", "F = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : Δt", "F m Δt v2 W", "44", "",
         "F m P v1 W", "F = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : W", "F m Δt v1 W", "43", "",
         "F m P v2 W", "F = m P (v2 ± √(v2 ^ 2 - 2 W : m)) : W", "F m Δt v2 W", "43", "",
         "F m P Δv W", "F = m P Δv : W", "F m Δt Δv", "43", "",
         "F m Δs Δt v1", "F = 2 m (Δs : Δt - v1) : Δt", "F m Δt v1 {v}", "20", "",
         "F m Δs Δt v2", "F = 2 m (v2 - Δs : Δt) : Δt", "F m Δt v2 {v}", "20", "",
         "F m Δs v1 v2", "F = m (v2 ^ 2 - v1 ^ 2) : Δs : 2", "F m Δs Δv {v}", "19", "",
         "F m Δs v1 Δv", "F = m Δv (v1 + Δv : 2) : Δs", "F m Δs Δv {v}", "18", "",
         "F m Δs v1 {v}", "F = 2 m {v} ({v} - v1) : Δs", "F m Δs Δv {v}", "16", "",
         "F m Δs v2 Δv", "F = m Δv (v2 - Δv : 2) : Δs", "F m Δs Δv {v}", "15", "",
         "F m Δs v2 {v}", "F = 2 m {v} (v2 - {v}) : Δs", "F m Δs Δv {v}", "13", "",
         "F m Δs Δv {v}", "F = m Δv {v} : Δs", "F m Δt Δv", "22", "",
         "F m Δt v1 {v}", "F = 2 m ({v} - v1) : Δt", "F m Δt Δv", "16", "",
         "F m Δt v1 W", "F = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : Δt", "F m Δt Δv", "70", "",
         "F m Δt v2 {v}", "F = 2 m (v2 - {v}) : Δt", "F m Δt Δv", "13", "",
         "F m Δt v2 W", "F = m (v2 ± √(v2 ^ 2 - 2 W : m)) : Δt", "F m Δt Δv", "74", "",
         "F m Δt Δv", "F = m Δv : Δt", "F a m", "23", "",
         "F P Δs Δt", "F = P Δt : Δs", "F Δs W", "44", "",
         "F P v1 v2", "F = 2 P : (v1 + v2)", "F P {v}", "10", "",
         "F P v1 Δv", "F = P : (v1 + Δv : 2)", "F P {v}", "18", "",
         "F P v2 Δv", "F = P : (v2 - Δv : 2)", "F P {v}", "15", "",
         "F P {v}", "F = P : {v}", "F P Δs Δt", "21", "",
         "F Δs W", "F = W : Δs", "", "30", "",
         "F Δt v1 v2 W", "F = 2 W : Δt : (v1 + v2)", "F Δt {v} W", "10", "",
         "F Δt v1 Δv W", "F = W : Δt : (v1 + Δv : 2)", "F Δt {v} W", "18", "",
         "F Δt v2 Δv W", "F = W : Δt : (v2 - Δv : 2)", "F Δt {v} W", "15", "",
         "F Δt {v} W", "F = W : Δt : {v}", "F Δs W", "21", ""];
          CAI = AA[0];
        } // F
        if (AA[0] == FAB[36])
        {
          FAC = [
         "Fx F", "Fx = F", "", "0", "",
         "Fx F θ", "Fx = F cos(θ)", "", "0", "",
         "Fx Fy θ", "Fx = Fy : tan(θ)", "", "0", "",
         "Fx Fz ϕ", "Fx = Fz tan(ϕ)", "", "0", "",
         "Fx F Fy", "Fx = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fx F Fz", "Fx = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fx F θ ϕ", "Fx = F cos(θ) sin(ϕ)", "", "0", "",
         "Fx Fy θ ϕ", "Fx = Fy sin(ϕ) : tan(θ)", "", "0", "",
         "Fx F Fy Fz", "Fx = √(F ^ 2 - Fy ^ 2 - Fz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Fx
        if (AA[0] == FAB[39])
        {
          FAC = [
         "Fy F", "Fy = F", "", "0", "",
         "Fy F θ", "Fy = F sin(θ)", "", "0", "",
         "Fy Fx θ", "Fy = Fx tan(θ)", "", "0", "",
         "Fy Fz θ", "Fy = Fz tan(θ)", "", "0", "",
         "Fy F Fx", "Fy = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fy F Fz", "Fy = √(F ^ 2 - Fz ^ 2)", "", "0", "",
         "Fy Fx θ ϕ", "Fy = Fx tan(θ) : sin(ϕ)", "", "0", "",
         "Fy Fz θ ϕ", "Fy = Fz tan(θ) : cos(ϕ)", "", "0", "",
         "Fy F Fx Fz", "Fy = √(F ^ 2 - Fx ^ 2 - Fz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Fy
        if (AA[0] == FAB[42])
        {
          FAC = [
         "Fz F", "Fz = F", "", "0", "",
         "Fz F θ", "Fz = F cos(θ)", "", "0", "",
         "Fz Fx ϕ", "Fz = Fx : tan(ϕ)", "", "0", "",
         "Fz Fy θ", "Fz = Fy : tan(θ)", "", "0", "",
         "Fz F Fx", "Fz = √(F ^ 2 - Fx ^ 2)", "", "0", "",
         "Fz F Fy", "Fz = √(F ^ 2 - Fy ^ 2)", "", "0", "",
         "Fz Fy θ ϕ", "Fz = Fy cos(ϕ) : tan(θ)", "", "0", "",
         "Fz F θ ϕ", "Fz = F cos(θ) cos(ϕ)", "", "0", "",
         "Fz F Fx Fy", "Fz = √(F ^ 2 - Fx ^ 2 - Fy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Fz
        if (AA[0] == FAB[45])
        {
          FAC = [
         "Ff F", "Ff = F", "", "0", "",
         "Ff F |Fn| Ft μg", "Ff = F - Ft - μg |Fn|", "", "0", "",
         "Ff F |Fn| Ft μh", "Ff = F - Ft - μh |Fn|", "", "0", "",
         "Ff F |Fn| Ft μr", "Ff = F - Ft - μr |Fn|", "", "0", "",
         "Ff F |Fn| μg", "Ff = F - μg |Fn|", "", "0", "",
         "Ff F |Fn| μh", "Ff = F - μh |Fn|", "", "0", "",
         "Ff F |Fn| μr", "Ff = F - μr |Fn|", "", "0", "",
         "Ff F Frg", "Ff = F - Frg", "", "0", "",
         "Ff F Frg Ft", "Ff = F - Ft - Frg", "", "0", "",
         "Ff F Frh", "Ff = F - Frh", "", "0", "",
         "Ff F Frh Ft", "Ff = F - Ft - Frh", "", "0", "",
         "Ff F Frr", "Ff = F - Frr", "", "0", "",
         "Ff F Frr Ft", "Ff = F - Ft - Frr", "", "0", "",
         "Ff F Ft", "Ff = F - Ft", "", "0", "",
         "Ff k Δs", "Ff = -k Δs", "", "0", ""];
          CAI = AA[0];
        } // Ff
        if (AA[0] == FAB[48])
        {
          FAC = [
         "Ffx Ff", "Ffx = Ff", "", "0", "",
         "Ffx Ff θ", "Ffx = Ff cos(θ)", "", "0", "",
         "Ffx Ffy θ", "Ffx = Ffy : tan(θ)", "", "0", "",
         "Ffx Ffz ϕ", "Ffx = Ffz tan(ϕ)", "", "0", "",
         "Ffx Ff Ffy", "Ffx = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffx Ff Ffz", "Ffx = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffx Ff θ ϕ", "Ffx = Ff cos(θ) sin(ϕ)", "", "0", "",
         "Ffx Ffy θ ϕ", "Ffx = Ffy sin(ϕ) : tan(θ)", "", "0", "",
         "Ffx Ff Ffy Ffz", "Ffx = √(Ff ^ 2 - Ffy ^ 2 - Ffz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Ffx
        if (AA[0] == FAB[51])
        {
          FAC = [
         "Ffy Ff", "Ffy = Ff", "", "0", "",
         "Ffy Ff θ", "Ffy = Ff sin(θ)", "", "0", "",
         "Ffy Ffx θ", "Ffy = Ffx tan(θ)", "", "0", "",
         "Ffy Ffz θ", "Ffy = Ffz tan(θ)", "", "0", "",
         "Ffy Ff Ffx", "Ffy = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffy Ff Ffz", "Ffy = √(Ff ^ 2 - Ffz ^ 2)", "", "0", "",
         "Ffy Ffx θ ϕ", "Ffy = Ffx tan(θ) : sin(ϕ)", "", "0", "",
         "Ffy Ffz θ ϕ", "Ffy = Ffz tan(θ) : cos(ϕ)", "", "0", "",
         "Ffy Ff Ffx Ffz", "Ffy = √(Ff ^ 2 - Ffx ^ 2 - Ffz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Ffy
        if (AA[0] == FAB[54])
        {
          FAC = [
         "Ffz Ff", "Ffz = Ff", "", "0", "",
         "Ffz Ff θ", "Ffz = Ff cos(θ)", "", "0", "",
         "Ffz Ffx ϕ", "Ffz = Ffx : tan(ϕ)", "", "0", "",
         "Ffz Ffy θ", "Ffz = Ffy : tan(θ)", "", "0", "",
         "Ffz Ff Ffx", "Ffz = √(Ff ^ 2 - Ffx ^ 2)", "", "0", "",
         "Ffz Ff Ffy", "Ffz = √(Ff ^ 2 - Ffy ^ 2)", "", "0", "",
         "Ffz Ffy θ ϕ", "Ffz = Ffy cos(ϕ) : tan(θ)", "", "0", "",
         "Ffz Ff θ ϕ", "Ffz = Ff cos(θ) cos(ϕ)", "", "0", "",
         "Ffz Ff Ffx Ffy", "Ffz = √(Ff ^ 2 - Ffx ^ 2 - Ffy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Ffz
        if (AA[0] == FAB[57])
        {
          FAC = [
         "|Fn| F Ff Ft μg", "|Fn| = (F - Ft - Ff) : μg", "", "0", "",
         "|Fn| F Ff Ft μh", "|Fn| = (F - Ft - Ff) : μh", "", "0", "",
         "|Fn| F Ff Ft μr", "|Fn| = (F - Ft - Ff) : μr", "", "0", "",
         "|Fn| F Ff μg", "|Fn| = (F - Ff) : μg", "", "0", "",
         "|Fn| F Ff μh", "|Fn| = (F - Ff) : μh", "", "0", "",
         "|Fn| F Ff μr", "|Fn| = (F - Ff) : μr", "", "0", "",
         "|Fn| F Ft k μg Δs", "|Fn| = (F + k Δs - Ft) : μg", "", "0", "",
         "|Fn| F Ft k μh Δs", "|Fn| = (F + k Δs - Ft) : μh", "", "0", "",
         "|Fn| F Ft k μr Δs", "|Fn| = (F + k Δs - Ft) : μr", "", "0", "",
         "|Fn| F Ft μg", "|Fn| = (F - Ft) : μg", "", "0", "",
         "|Fn| F Ft μh", "|Fn| = (F - Ft) : μh", "", "0", "",
         "|Fn| F Ft μr", "|Fn| = (F - Ft) : μr", "", "0", "",
         "|Fn| F k μg Δs", "|Fn| = (F + k Δs) : μg", "", "0", "",
         "|Fn| F k μh Δs", "|Fn| = (F + k Δs) : μh", "", "0", "",
         "|Fn| F k μr Δs", "|Fn| = (F + k Δs) : μr", "", "0", "",
         "|Fn| F μg", "|Fn| = F : μg", "", "0", "",
         "|Fn| F μh", "|Fn| = F : μh", "", "0", "",
         "|Fn| F μr", "|Fn| = F : μr", "", "0", "",
         "|Fn| Frg μg", "|Fn| = Frg : μg", "", "0", "",
         "|Fn| Frh μh", "|Fn| = Frh : μh", "", "0", "",
         "|Fn| Frr μr", "|Fn| = Frr : μr", "", "0", ""];
          CAI = AA[0];
        } // |Fn|
        if (AA[0] == FAB[60])
        {
          FAC = [
         "Frg F", "Frg = F", "", "0", "",
         "Frg F Ff", "Frg = F - Ff", "", "0", "",
         "Frg F Ff Ft", "Frg = F - Ft - Ff", "", "0", "",
         "Frg F Ft", "Frg = F - Ft", "", "0", "",
         "Frg F Ft k Δs", "Frg = F + k Δs - Ft", "", "0", "",
         "Frg F k Δs", "Frg = F + k Δs", "", "0", "",
         "Frg |Fn| μg", "Frg = μg |Fn|", "", "0", ""];
          CAI = AA[0];
        } // Frg
        if (AA[0] == FAB[63])
        {
          FAC = [
         "Frgx Frg", "Frgx = Frg", "", "0", "",
         "Frgx Frg θ", "Frgx = Frg cos(θ)", "", "0", "",
         "Frgx Frgy θ", "Frgx = Frgy : tan(θ)", "", "0", "",
         "Frgx Frgz ϕ", "Frgx = Frgz tan(ϕ)", "", "0", "",
         "Frgx Frg Frgy", "Frgx = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgx Frg Frgz", "Frgx = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgx Frg θ ϕ", "Frgx = Frg cos(θ) sin(ϕ)", "", "0", "",
         "Frgx Frgy θ ϕ", "Frgx = Frgy sin(ϕ) : tan(θ)", "", "0", "",
         "Frgx Frg Frgy Frgz", "Frgx = √(Frg ^ 2 - Frgy ^ 2 - Frgz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frgx
        if (AA[0] == FAB[66])
        {
          FAC = [
         "Frgy Frg", "Frgy = Frg", "", "0", "",
         "Frgy Frg θ", "Frgy = Frg sin(θ)", "", "0", "",
         "Frgy Frgx θ", "Frgy = Frgx tan(θ)", "", "0", "",
         "Frgy Frgz θ", "Frgy = Frgz tan(θ)", "", "0", "",
         "Frgy Frg Frgx", "Frgy = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgy Frg Frgz", "Frgy = √(Frg ^ 2 - Frgz ^ 2)", "", "0", "",
         "Frgy Frgx θ ϕ", "Frgy = Frgx tan(θ) : sin(ϕ)", "", "0", "",
         "Frgy Frgz θ ϕ", "Frgy = Frgz tan(θ) : cos(ϕ)", "", "0", "",
         "Frgy Frg Frgx Frgz", "Frgy = √(Frg ^ 2 - Frgx ^ 2 - Frgz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frgy
        if (AA[0] == FAB[69])
        {
          FAC = [
         "Frgz Frg", "Frgz = Frg", "", "0", "",
         "Frgz Frg θ", "Frgz = Frg cos(θ)", "", "0", "",
         "Frgz Frgx ϕ", "Frgz = Frgx : tan(ϕ)", "", "0", "",
         "Frgz Frgy θ", "Frgz = Frgy : tan(θ)", "", "0", "",
         "Frgz Frg Frgx", "Frgz = √(Frg ^ 2 - Frgx ^ 2)", "", "0", "",
         "Frgz Frg Frgy", "Frgz = √(Frg ^ 2 - Frgy ^ 2)", "", "0", "",
         "Frgz Frgy θ ϕ", "Frgz = Frgy cos(ϕ) : tan(θ)", "", "0", "",
         "Frgz Frg θ ϕ", "Frgz = Frg cos(θ) cos(ϕ)", "", "0", "",
         "Frgz Frg Frgx Frgy", "Frgz = √(Frg ^ 2 - Frgx ^ 2 - Frgy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frgz
        if (AA[0] == FAB[72])
        {
          FAC = [
         "Frh F", "Frh = F", "", "0", "",
         "Frh F Ff", "Frh = F - Ff", "", "0", "",
         "Frh F Ff Ft", "Frh = F - Ft - Ff", "", "0", "",
         "Frh F Ft", "Frh = F - Ft", "", "0", "",
         "Frh F Ft k Δs", "Frh = F + k Δs - Ft", "", "0", "",
         "Frh F k Δs", "Frh = F + k Δs", "", "0", "",
         "Frh |Fn| μh", "Frh = μh |Fn|", "", "0", ""];
          CAI = AA[0];
        } // Frh
        if (AA[0] == FAB[75])
        {
          FAC = [
         "Frhx Frh", "Frhx = Frh", "", "0", "",
         "Frhx Frh θ", "Frhx = Frh cos(θ)", "", "0", "",
         "Frhx Frhy θ", "Frhx = Frhy : tan(θ)", "", "0", "",
         "Frhx Frhz ϕ", "Frhx = Frhz tan(ϕ)", "", "0", "",
         "Frhx Frh Frhy", "Frhx = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhx Frh Frhz", "Frhx = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhx Frh θ ϕ", "Frhx = Frh cos(θ) sin(ϕ)", "", "0", "",
         "Frhx Frhy θ ϕ", "Frhx = Frhy sin(ϕ) : tan(θ)", "", "0", "",
         "Frhx Frh Frhy Frhz", "Frhx = √(Frh ^ 2 - Frhy ^ 2 - Frhz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frhx
        if (AA[0] == FAB[78])
        {
          FAC = [
         "Frhy Frh", "Frhy = Frh", "", "0", "",
         "Frhy Frh θ", "Frhy = Frh sin(θ)", "", "0", "",
         "Frhy Frhx θ", "Frhy = Frhx tan(θ)", "", "0", "",
         "Frhy Frhz θ", "Frhy = Frhz tan(θ)", "", "0", "",
         "Frhy Frh Frhx", "Frhy = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhy Frh Frhz", "Frhy = √(Frh ^ 2 - Frhz ^ 2)", "", "0", "",
         "Frhy Frhx θ ϕ", "Frhy = Frhx tan(θ) : sin(ϕ)", "", "0", "",
         "Frhy Frhz θ ϕ", "Frhy = Frhz tan(θ) : cos(ϕ)", "", "0", "",
         "Frhy Frh Frhx Frhz", "Frhy = √(Frh ^ 2 - Frhx ^ 2 - Frhz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frhy
        if (AA[0] == FAB[81])
        {
          FAC = [
         "Frhz Frh", "Frhz = Frh", "", "0", "",
         "Frhz Frh θ", "Frhz = Frh cos(θ)", "", "0", "",
         "Frhz Frhx ϕ", "Frhz = Frhx : tan(ϕ)", "", "0", "",
         "Frhz Frhy θ", "Frhz = Frhy : tan(θ)", "", "0", "",
         "Frhz Frh Frhx", "Frhz = √(Frh ^ 2 - Frhx ^ 2)", "", "0", "",
         "Frhz Frh Frhy", "Frhz = √(Frh ^ 2 - Frhy ^ 2)", "", "0", "",
         "Frhz Frhy θ ϕ", "Frhz = Frhy cos(ϕ) : tan(θ)", "", "0", "",
         "Frhz Frh θ ϕ", "Frhz = Frh cos(θ) cos(ϕ)", "", "0", "",
         "Frhz Frh Frhx Frhy", "Frhz = √(Frh ^ 2 - Frhx ^ 2 - Frhy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frhz
        if (AA[0] == FAB[84])
        {
          FAC = [
         "Frr F", "Frr = F", "", "0", "",
         "Frr F Ff", "Frr = F - Ff", "", "0", "",
         "Frr F Ff Ft", "Frr = F - Ft - Ff", "", "0", "",
         "Frr F Ft", "Frr = F - Ft", "", "0", "",
         "Frr F Ft k Δs", "Frr = F + k Δs - Ft", "", "0", "",
         "Frr F k Δs", "Frr = F + k Δs", "", "0", "",
         "Frr |Fn| μr", "Frr = μr |Fn|", "", "0", ""];
          CAI = AA[0];
        } // Frr
        if (AA[0] == FAB[87])
        {
          FAC = [
         "Frrx Frr", "Frrx = Frr", "", "0", "",
         "Frrx Frr θ", "Frrx = Frr cos(θ)", "", "0", "",
         "Frrx Frry θ", "Frrx = Frry : tan(θ)", "", "0", "",
         "Frrx Frrz ϕ", "Frrx = Frrz tan(ϕ)", "", "0", "",
         "Frrx Frr Frry", "Frrx = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrx Frr Frrz", "Frrx = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frrx Frr θ ϕ", "Frrx = Frr cos(θ) sin(ϕ)", "", "0", "",
         "Frrx Frry θ ϕ", "Frrx = Frry sin(ϕ) : tan(θ)", "", "0", "",
         "Frrx Frr Frry Frrz", "Frrx = √(Frr ^ 2 - Frry ^ 2 - Frrz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frrx
        if (AA[0] == FAB[90])
        {
          FAC = [
         "Frry Frr", "Frry = Frr", "", "0", "",
         "Frry Frr θ", "Frry = Frr sin(θ)", "", "0", "",
         "Frry Frrx θ", "Frry = Frrx tan(θ)", "", "0", "",
         "Frry Frrz θ", "Frry = Frrz tan(θ)", "", "0", "",
         "Frry Frr Frrx", "Frry = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frry Frr Frrz", "Frry = √(Frr ^ 2 - Frrz ^ 2)", "", "0", "",
         "Frry Frrx θ ϕ", "Frry = Frrx tan(θ) : sin(ϕ)", "", "0", "",
         "Frry Frrz θ ϕ", "Frry = Frrz tan(θ) : cos(ϕ)", "", "0", "",
         "Frry Frr Frrx Frrz", "Frry = √(Frr ^ 2 - Frrx ^ 2 - Frrz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frry
        if (AA[0] == FAB[93])
        {
          FAC = [
         "Frrz Frr", "Frrz = Frr", "", "0", "",
         "Frrz Frr θ", "Frrz = Frr cos(θ)", "", "0", "",
         "Frrz Frrx ϕ", "Frrz = Frrx : tan(ϕ)", "", "0", "",
         "Frrz Frry θ", "Frrz = Frry : tan(θ)", "", "0", "",
         "Frrz Frr Frrx", "Frrz = √(Frr ^ 2 - Frrx ^ 2)", "", "0", "",
         "Frrz Frr Frry", "Frrz = √(Frr ^ 2 - Frry ^ 2)", "", "0", "",
         "Frrz Frry θ ϕ", "Frrz = Frry cos(ϕ) : tan(θ)", "", "0", "",
         "Frrz Frr θ ϕ", "Frrz = Frr cos(θ) cos(ϕ)", "", "0", "",
         "Frrz Frr Frrx Frry", "Frrz = √(Frr ^ 2 - Frrx ^ 2 - Frry ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Frrz
        if (AA[0] == FAB[96])
        {
          FAC = [
         "Ft F Ff", "Ft = F - Ff", "", "0", "",
         "Ft F Ff |Fn| μg", "Ft = F - Ff - μg |Fn|", "", "0", "",
         "Ft F Ff |Fn| μh", "Ft = F - Ff - μh |Fn|", "", "0", "",
         "Ft F Ff |Fn| μr", "Ft = F - Ff - μr |Fn|", "", "0", "",
         "Ft F Ff Frg", "Ft = F - Ff - Frg", "", "0", "",
         "Ft F Ff Frh", "Ft = F - Ff - Frh", "", "0", "",
         "Ft F Ff Frr", "Ft = F - Ff - Frr", "", "0", "",
         "Ft F |Fn| k μg Δs", "Ft = F + k Δs - μg |Fn|", "", "0", "",
         "Ft F |Fn| k μh Δs", "Ft = F + k Δs - μh |Fn|", "", "0", "",
         "Ft F |Fn| k μr Δs", "Ft = F + k Δs - μr |Fn|", "", "0", "",
         "Ft F |Fn| μg", "Ft = F - μg |Fn|", "", "0", "",
         "Ft F |Fn| μh", "Ft = F - μh |Fn|", "", "0", "",
         "Ft F |Fn| μr", "Ft = F - μr |Fn|", "", "0", "",
         "Ft F Frg", "Ft = F - Frg", "", "0", "",
         "Ft F Frg k Δs", "Ft = F + k Δs - Frg", "", "0", "",
         "Ft F Frh", "Ft = F - Frh", "", "0", "",
         "Ft F Frh k Δs", "Ft = F + k Δs - Frh", "", "0", "",
         "Ft F Frr", "Ft = F - Frr", "", "0", "",
         "Ft F Frr k Δs", "Ft = F + k Δs - Frr", "", "0", "",
         "Ft F k Δs", "Ft = F + k Δs", "", "0", ""];
          CAI = AA[0];
        } // Ft
        if (AA[0] == FAB[99])
        {
          FAC = [
         "Ftx Ft", "Ftx = Ft", "", "0", "",
         "Ftx Ft θ", "Ftx = Ft cos(θ)", "", "0", "",
         "Ftx Fty θ", "Ftx = Fty : tan(θ)", "", "0", "",
         "Ftx Ftz ϕ", "Ftx = Ftz tan(ϕ)", "", "0", "",
         "Ftx Ft Fty", "Ftx = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftx Ft Ftz", "Ftx = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Ftx Ft θ ϕ", "Ftx = Ft cos(θ) sin(ϕ)", "", "0", "",
         "Ftx Fty θ ϕ", "Ftx = Fty sin(ϕ) : tan(θ)", "", "0", "",
         "Ftx Ft Fty Ftz", "Ftx = √(Ft ^ 2 - Fty ^ 2 - Ftz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Ftx
        if (AA[0] == FAB[102])
        {
          FAC = [
         "Fty Ft", "Fty = Ft", "", "0", "",
         "Fty Ft θ", "Fty = Ft sin(θ)", "", "0", "",
         "Fty Ftx θ", "Fty = Ftx tan(θ)", "", "0", "",
         "Fty Ftz θ", "Fty = Ftz tan(θ)", "", "0", "",
         "Fty Ft Ftx", "Fty = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Fty Ft Ftz", "Fty = √(Ft ^ 2 - Ftz ^ 2)", "", "0", "",
         "Fty Ftx θ ϕ", "Fty = Ftx tan(θ) : sin(ϕ)", "", "0", "",
         "Fty Ftz θ ϕ", "Fty = Ftz tan(θ) : cos(ϕ)", "", "0", "",
         "Fty Ft Ftx Ftz", "Fty = √(Ft ^ 2 - Ftx ^ 2 - Ftz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Fty
        if (AA[0] == FAB[105])
        {
          FAC = [
         "Ftz Ft", "Ftz = Ft", "", "0", "",
         "Ftz Ft θ", "Ftz = Ft cos(θ)", "", "0", "",
         "Ftz Ftx ϕ", "Ftz = Ftx : tan(ϕ)", "", "0", "",
         "Ftz Fty θ", "Ftz = Fty : tan(θ)", "", "0", "",
         "Ftz Ft Ftx", "Ftz = √(Ft ^ 2 - Ftx ^ 2)", "", "0", "",
         "Ftz Ft Fty", "Ftz = √(Ft ^ 2 - Fty ^ 2)", "", "0", "",
         "Ftz Fty θ ϕ", "Ftz = Fty cos(ϕ) : tan(θ)", "", "0", "",
         "Ftz Ft θ ϕ", "Ftz = Ft cos(θ) cos(ϕ)", "", "0", "",
         "Ftz Ft Ftx Fty", "Ftz = √(Ft ^ 2 - Ftx ^ 2 - Fty ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Ftz
        if (AA[0] == FAB[108])
        {
          FAC = [
         "k a F P v1", "k = -a F ^ 2 : P : (P : F - v1) : 2", "k a F v1 {v}", "62", "",
         "k a F P v2", "k = -a F ^ 2 : P : (v2 - P : F) : 2", "k a F v2 {v}", "62", "",
         "k a F P Δv", "k = -a F ^ 2 : P : Δv", "k F P Δt", "25", "",
         "k a F Δt v1", "k = -F : Δt : (v1 + a Δt : 2)", "k F Δt v1 Δv", "24", "",
         "k a F Δt v2", "k = -F : Δt : (v2 - a Δt : 2)", "k F Δt v2 Δv", "24", "",
         "k a F v1 v2", "k = -2 a F : (v2 ^ 2 - v1 ^ 2)", "k a F Δv {v}", "19", "",
         "k a F v1 Δv", "k = -a F : Δv : (v1 + Δv : 2)", "k a F Δv {v}", "18", "",
         "k a F v1 {v}", "k = -a F : {v} : ({v} - v1) : 2", "k a F Δv {v}", "16", "",
         "k a F v2 Δv", "k = -a F : Δv : (v2 - Δv : 2)", "k a F Δv {v}", "15", "",
         "k a F v2 {v}", "k = -a F : {v} : (v2 - {v}) : 2", "k a F v2 {v}", "13", "",
         "k a F Δv {v}", "k = -a F : Δv : {v}", "k F Δt {v}", "25", "",
         "k a m P Δt", "k = -(a m) ^ 2 : P : Δt", "k F P Δt", "26", "",
         "k a m P v1", "k = -a ^ 3 m ^ 2 : P : (P : a : m - v1) : 2", "k a F P v1", "26", "",
         "k a m P v2", "k = -a ^ 3 m ^ 2 : P : (v2 - P : a : m) : 2", "k a F P v2", "26", "",
         "k a m P Δv", "k = -a ^ 3 m ^ 2 : P : Δv", "k a F P Δv", "26", "",
         "k a m Δs", "k = -a m : Δs", "k F Δs", "26", "",
         "k a m Δt v1", "k = -a m : Δt : (v1 + a Δt : 2)", "k a F Δt v1", "26", "",
         "k a m Δt v2", "k = -a m : Δt : (v2 - a Δt : 2)", "k a F Δt v2", "26", "",
         "k a m Δt {v}", "k = -a m : Δt : {v}", "k a m Δs", "21", "",
         "k a m v1 v2", "k = -2 a ^ 2 m : (v2 ^ 2 - v1 ^ 2)", "k a m Δv {v}", "19", "",
         "k a m v1 Δv", "k = -(a ^ 2) m : Δv : (v1 + Δv : 2)", "k a m Δv {v}", "18", "",
         "k a m v1 {v}", "k = -(a ^ 2) m : {v} : ({v} - v1) : 2", "k a m Δv {v}", "16", "",
         "k a m v2 Δv", "k = -(a ^ 2) m : Δv : (v2 - Δv : 2)", "k a m Δv {v}", "15", "",
         "k a m v2 {v}", "k = -(a ^ 2) m : {v} : (v2 - {v}) : 2", "k a m Δv {v}", "13", "",
         "k a m Δv {v}", "k = -(a ^ 2 m) : Δv : {v}", "k a F Δv {v}", "26", "",
         "k a m W", "k = -(a m) ^ 2 : W", "k F W", "26", "",
         "k a P Δs v1", "k = -P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : Δs ^ 2", "k a F P v1", "57", "",
         "k a P Δs v2", "k = -P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : Δs ^ 2", "k a F P v2", "57", "",
         "k a P Δs Δv", "k = -P Δv : a : Δs ^ 2", "k P Δs Δt", "25", "",
         "k a P Δt v1", "k = -P : Δt : (v1 + a Δt : 2) ^ 2", "k P Δt v1 Δv", "24", "",
         "k a P Δt v2", "k = -P : Δt : (v2 - a Δt : 2) ^ 2", "k P Δt v2 Δv", "24", "",
         "k a P v1 v2", "k = -4 a P : (v2 ^ 2 - v1 ^ 2) : (v1 + v2)", "k a P Δv {v}", "19", "",
         "k a P v1 Δv", "k = -a P : Δv : (v1 + Δv : 2) ^ 2", "k a P Δv {v}", "18", "",
         "k a P v1 {v}", "k = -a P : ({v} - v1) : {v} ^ 2 : 2", "k a P Δv {v}", "16", "",
         "k a P v1 W", "k = -(P ^ 2) : W : (v1 + a W : P : 2) ^ 2", "k a P Δt v1", "43", "",
         "k a P v2 Δv", "k = -a P : Δv : (v2 - Δv : 2) ^ 2", "k a P Δv {v}", "15", "",
         "k a P v2 {v}", "k = -a P : (v2 - {v}) : {v} ^ 2 : 2", "k a P Δv {v}", "13", "",
         "k a P v2 W", "k = -(P ^ 2) : W : (v2 - a W : P : 2) ^ 2", "k a P Δt v2", "43", "",
         "k a P Δv {v}", "k = -a P : Δv : {v} ^ 2", "k P Δt {v}", "25", "",
         "k a Δt v1 W", "k = -W : (Δt (v1 + a Δt : 2)) ^ 2", "k Δt v1 Δv W", "24", "",
         "k a Δt v2 W", "k = -W : (Δt (v2 - a Δt : 2)) ^ 2", "k Δt v2 Δv W", "24", "",
         "k a v1 v2 W", "k = -4 a ^ 2 W : (v2 ^ 2 - v1 ^ 2) ^ 2", "k a Δv {v} W", "19", "",
         "k a v1 Δv W", "k = -(a ^ 2) W : ((v1 + Δv : 2) Δv) ^ 2", "k a Δv {v} W", "18", "",
         "k a v1 {v} W", "k = -(a ^ 2) W : (2 ({v} - v1) {v}) ^ 2", "k a Δv {v} W", "16", "",
         "k a v2 Δv W", "k = -(a ^ 2) W : ((v2 - Δv : 2) Δv) ^ 2", "k a Δv {v} W", "15", "",
         "k a v2 {v} W", "k = -(a ^ 2) W : (2 (v2 - {v}) {v}) ^ 2", "k a Δv {v} W", "13", "",
         "k a Δv {v} W", "k = -(a ^ 2) W : (Δv {v}) ^ 2", "k Δt {v} W", "25", "",
         "k F |Fn| Ft μg Δs", "k = (Ft + μg |Fn| - F): Δs", "", "0", "",
         "k F |Fn| Ft μh Δs", "k = (Ft + μh |Fn| - F): Δs", "", "0", "",
         "k F |Fn| Ft μr Δs", "k = (Ft + μr |Fn| - F): Δs", "", "0", "",
         "k F |Fn| μg Δs", "k = (μg |Fn| - F) : Δs", "", "0", "",
         "k F |Fn| μh Δs", "k = (μh |Fn| - F) : Δs", "", "0", "",
         "k F |Fn| μr Δs", "k = (μr |Fn| - F) : Δs", "", "0", "",
         "k F Frg Ft Δs", "k = (Ft + Frg - F) : Δs", "", "0", "",
         "k F Frh Ft Δs", "k = (Ft + Frh - F) : Δs", "", "0", "",
         "k F Frr Ft Δs", "k = (Ft + Frr - F) : Δs", "", "0", "",
         "k F Frg Δs", "k = (Frg - F) : Δs", "", "0", "",
         "k F Frh Δs", "k = (Frh - F) : Δs", "", "0", "",
         "k F Frr Δs", "k = (Frr - F) : Δs", "", "0", "",
         "k F Ft Δs", "k = (Ft - F) : Δs", "", "0", "",
         "k F m P v1", "k = -F ^ 3 : m : P : (P : F - v1) : 2", "k a F P v1", "27", "",
         "k F m P v2", "k = -F ^ 3 : m : P : (v2 - P : F) : 2", "k a F P v2", "27", "",
         "k F m P Δv", "k = -F ^ 3 : P : m : Δv", "k a F P Δv", "27", "",
         "k F m Δt v1", "k = -F : Δt : (v1 + F Δt : m : 2)", "k a F Δt v1", "27", "",
         "k F m Δt v2", "k = -F : Δt : (v2 - F Δt : m : 2)", "k a F Δt v2", "27", "",
         "k F m v1 v2", "k = -2 F ^ 2 : m : (v2 ^ 2 - v1 ^ 2)", "k F m Δv {v}", "19", "",
         "k F m v1 Δv", "k = -(F ^ 2) : m : Δv : (v1 + Δv : 2)", "k F m Δv {v}", "18", "",
         "k F m v1 {v}", "k = -(F ^ 2) : m : {v} : ({v} - v1) : 2", "k F m Δv {v}", "16", "",
         "k F m v2 Δv", "k = -(F ^ 2) : m : Δv : (v2 - Δv : 2)", "k F m Δv {v}", "15", "",
         "k F m v2 {v}", "k = -(F ^ 2) : m : {v} : (v2 - {v}) : 2", "k F m Δv {v}", "13", "",
         "k F m Δv {v}", "k = -(F ^ 2) : m : Δv : {v}", "k a F Δv {v}", "27", "",
         "k F P Δt", "k = -(F ^ 2) : P : Δt", "k F W", "44", "",
         "k F Δs", "k = -F : Δs", "", "58", "",
         "k F Δt v1 v2", "k = -2 F : Δt : (v1 + v2)", "k F Δt {v}", "10", "",
         "k F Δt v1 Δv", "k = -F : Δt : (v1 + Δv : 2)", "k F Δt {v}", "18", "",
         "k F Δt v2 Δv", "k = -F : Δt : (v2 - Δv : 2)", "k F Δt {v}", "15", "",
         "k F Δt {v}", "k = -F : Δt : {v}", "k F Δs", "21", "",
         "k F W", "k = -(F ^ 2) : W", "k F Δs", "59", "",
         "k Ff Δs", "k = -Ff : Δs", "", "0", "",
         "k m P Δs Δv", "k = -√ (P m Δv : Δs ^ 3)", "k F m P Δv", "57", "",
         "k m P Δt v1", "k = -4 P : Δt : (v1 ± √(v1 ^ 2 + 2 P Δt : m)) ^ 2", "k m Δt v1 W", "44", "",
         "k m P Δt v2", "k = -4 P : Δt : (v2 ± √(v2 ^ 2 - 2 P Δt : m)) ^ 2", "k m Δt v2 W", "44", "",
         "k m P Δt Δv", "k = -(m Δv) ^ 2 : P : Δt ^ 3", "k m Δt Δv W", "44", "",
         "k m P v1 v2", "k = -8 P ^ 2 : m : (v2 - v1) : (v1 + v2) ^ 3", "k m P Δv {v}", "19", "",
         "k m P v1 Δv", "k = -(P ^ 2) : m : Δv : (v1 + Δv : 2) ^ 3", "k m P Δv {v}", "18", "",
         "k m P v1 {v}", "k = -(P ^ 2) : m : {v} ^ 3 : ({v} - v1) : 2", "k m P Δv {v}", "16", "",
         "k m P v1 W", "k = -4 P ^ 2 : W : (v1 ± √(v1 ^ 2 + 2 W : m)) ^ 2", "k m P Δt v1", "43", "",
         "k m P v2 Δv", "k = -(P ^ 2) : m : Δv : (v2 - Δv : 2) ^ 3", "k m P Δv {v}", "15", "",
         "k m P v2 {v}", "k = -(P ^ 2) : m : {v} ^ 3 : (v2 - {v}) : 2", "k m P Δv {v}", "13", "",
         "k m P v2 W", "k = -4 P ^ 2 : W : (v2 ± √(v2 ^ 2 - 2 W : m)) ^ 2", "k m P Δt v2", "43", "",
         "k m P Δv {v}", "k = -(P ^ 2) : m : Δv : {v} ^ 3", "k P {v} W", "63", "",
         "k m P Δv W", "k = -(m P Δv) ^ 2 : W ^ 3", "k m Δt Δv W", "43", "",
         "k m Δs Δt v1", "k = -2 m (Δs : Δt - v1) : Δs : Δt", "k m Δs v1 {v}", "20", "",
         "k m Δs Δt v2", "k = -2 m (v2 - Δs : Δt) : Δs : Δt", "k m Δs v2 {v}", "20", "",
         "k m Δs Δt Δv", "k = -m Δv : Δs : Δt", "k a m Δs", "23", "",
         "k m Δs v1 v2", "k = -m (v2 ^ 2 - v1 ^ 2) : Δs ^ 2 : 2", "k m Δs Δv {v}", "19", "",
         "k m Δs v1 Δv", "k = -m Δv (v1 + Δv : 2) : Δs ^ 2", "k m Δs Δv {v}", "18", "",
         "k m Δs v1 {v}", "k = -2 m {v} ({v} - v1) : Δs ^ 2", "k m Δs Δv {v}", "16", "",
         "k m Δs v2 Δv", "k = -m Δv (v2 - Δv : 2) : Δs ^ 2", "k m Δs Δv {v}", "15", "",
         "k m Δs v2 {v}", "k = -2 m {v} (v2 - {v}) : Δs ^ 2", "k m Δs Δv {v}", "13", "",
         "k m Δs Δv {v}", "k = -m Δv {v} : Δs ^ 2", "k m Δs Δt Δv", "22", "",
         "k m Δt v1 v2", "k = -2 m (v2 - v1) : Δt ^ 2 : (v1 + v2)", "k m Δt Δv {v}", "19", "",
         "k m Δt v1 Δv", "k = -m Δv : Δt ^ 2 : (v1 + Δv : 2)", "k m Δt Δv {v}", "18", "",
         "k m Δt v1 {v}", "k = -2 m ({v} - v1) : Δt ^ 2 : {v}", "k m Δt Δv {v}", "16", "",
         "k m Δt v1 W", "k = -4 W : (Δt (v1 ± √(v1 ^ 2 + 2 W : m))) ^ 2", "k Δt v1 Δv W", "70", "",
         "k m Δt v2 Δv", "k = -m Δv : Δt ^ 2 : (v2 - Δv : 2)", "k m Δt Δv {v}", "15", "",
         "k m Δt v2 {v}", "k = -2 m (v2 - {v}) : Δt ^ 2 : {v}", "k m Δt Δv {v}", "13", "",
         "k m Δt v2 W", "k = -4 W : (Δt (v2 ± √(v2 ^ 2 - 2 W : m))) ^ 2", "k Δt v2 Δv W", "74", "",
         "k m Δt Δv {v}", "k = -m Δv : Δt ^ 2 : {v}", "k m Δs Δt Δv", "21", "",
         "k m Δt Δv W", "k = -(m Δv) ^ 2 : Δt ^ 2 : W", "k a m W", "23", "",
         "k P Δs Δt", "k = -P Δt : Δs ^ 2", "k Δs W", "44", "",
         "k P Δs v1 v2", "k = -2 P : Δs : (v1 + v2)", "k P Δs {v}", "10", "",
         "k P Δs v1 Δv", "k = -P : Δs : (v1 + Δv : 2)", "k P Δs {v}", "18", "",
         "k P Δs v2 Δv", "k = -P : Δs : (v2 - Δv : 2)", "k P Δs {v}", "15", "",
         "k P Δs {v}", "k = -P : Δs : {v}", "k P Δs Δt", "61", "",
         "k P Δt v1 v2", "k = -4 P : Δt : (v1 + v2) ^ 2", "k P Δt {v}", "10", "",
         "k P Δt v1 Δv", "k = -P : Δt : (v1 + Δv : 2) ^ 2", "k P Δt {v}", "18", "",
         "k P Δt v2 Δv", "k = -P : Δt : (v2 - Δv : 2) ^ 2", "k P Δt {v}", "15", "",
         "k P Δt {v}", "k = -P : Δt : {v} ^ 2", "k Δt {v} W", "21", "",
         "k P v1 v2 W", "k = -4 P ^ 2 : (v1 + v2) ^ 2 : W", "k P {v} W", "10", "",
         "k P v1 Δv W", "k = -(P ^ 2) : (v1 + Δv : 2) ^ 2 : W", "k P {v} W", "18", "",
         "k P v2 Δv W", "k = -(P ^ 2) : (v2 - Δv : 2) ^ 2 : W", "k P {v} W", "15", "",
         "k P {v} W", "k = -(P ^ 2) : {v} ^ 2 : W", "k Δt {v} W", "61", "",
         "k Δs W", "k = -W : Δs ^ 2", "k F Δs", "30", "",
         "k Δt v1 v2 W", "k = -4 W : (Δt (v1 + v2)) ^ 2", "k Δt {v} W", "10", "",
         "k Δt v1 Δv W", "k = -W : (Δt (v1 + Δv : 2)) ^ 2", "k Δt {v} W", "18", "",
         "k Δt v2 Δv W", "k = -W : (Δt (v2 - Δv : 2)) ^ 2", "k Δt {v} W", "15", "",
         "k Δt {v} W", "k = -W : (Δt {v}) ^ 2", "k Δs W", "21", ""];
          CAI = AA[0];
        } // k
        if (AA[0] == FAB[111])
        {
          FAC = [
         "M c m V", "M = m : c : V", "M m n", "46", "",
         "M m n", "M = m : n", "", "48", ""];
          CAI = AA[0];
        } // M
        if (AA[0] == FAB[114])
        {
          FAC = [
         "m a F", "m = F : a", "", "28", "",
         "m a |Fn| μg", "m = |Fn| μg : a", "m a F", "85", "",
         "m a |Fn| μh", "m = |Fn| μh : a", "m a F", "88", "",
         "m a |Fn| μr", "m = |Fn| μr : a", "m a F", "91", "",
         "m a k P Δt", "m = √(-k P Δt) : a", "m a k W", "44", "",
         "m a k P Δv", "m = √(-k P Δv : a ^ 3)", "m a k P Δt", "25", "",
         "m a k Δs", "m = -k Δs : a", "m a F", "57", "",
         "m a k Δt v1", "m = -k Δt (v1 + a Δt : 2) : a", "m a k v1 Δv", "24", "",
         "m a k Δt v2", "m = -k Δt (v2 - a Δt : 2) : a", "m a k v2 Δv", "24", "",
         "m a k Δt {v}", "m = -k Δt {v} : a", "m a k Δs", "21", "",
         "m a k v1 v2", "m = -k (v2 ^ 2 - v1 ^ 2) : a ^ 2 : 2", "m a k Δv {v}", "19", "",
         "m a k v1 Δv", "m = -k Δv (v1 + Δv : 2) : a ^ 2", "m a k Δv {v}", "18", "",
         "m a k v1 {v}", "m = -2 k {v} ({v} - v1) : a ^ 2", "m a k Δv {v}", "16", "",
         "m a k v2 Δv", "m = -k Δv (v2 - Δv : 2) : a ^ 2", "m a k Δv {v}", "15", "",
         "m a k v2 {v}", "m = -2 k {v} (v2 - {v}) : a ^ 2", "m a k Δv {v}", "13", "",
         "m a k Δv {v}", "m = -k Δv {v} : a ^ 2", "m a k Δt {v}", "25", "",
         "m a k W", "m = √(-k W) : a", "m a F", "75", "",
         "m a P Δs Δt", "m = P Δt : a : Δs", "m a Δs W", "20", "",
         "m a P Δs v1", "m = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a ^ 2 : Δs", "m F P Δs v1", "26", "",
         "m a P Δs v2", "m = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a ^ 2 : Δs", "m F P Δs v2", "26", "",
         "m a P Δs Δv", "m = P Δv : a ^ 2 : Δs", "m a P Δs Δt", "25", "",
         "m a P Δt v1", "m = P : a : (v1 + a Δt : 2)", "m a P v1 Δv", "24", "",
         "m a P Δt v2", "m = P : a : (v2 - a Δt : 2)", "m a P v2 Δv", "24", "",
         "m a P v1 v2", "m = 2 P : a : (v1 + v2)", "m a P {v}", "10", "",
         "m a P v1 Δv", "m = P : a : (v1 + Δv : 2)", "m a P {v}", "18", "",
         "m a P v1 W", "m = 2 P ^ 2 : (a ^ 2 W + 2 a P v1)", "m a P Δt v1", "43", "",
         "m a P v2 Δv", "m = P : a : (v2 - Δv : 2)", "m a P {v}", "15", "",
         "m a P v2 W", "m = 2 P ^ 2 : (2 a P v2 - a ^ 2 W)", "m a P Δt v2", "43", "",
         "m a P {v}", "m = P : a : {v}", "m a Δt {v} W", "61", "",
         "m a Δs W", "m = W : a : Δs", "m a F", "30", "",
         "m a Δt v1 W", "m = W : a : Δt : (v1 + a Δt : 2)", "m v1 Δv W", "24", "",
         "m a Δt v2 W", "m = W : a : Δt : (v2 - a Δt : 2)", "m v2 Δv W", "24", "",
         "m a Δt {v} W", "m = W : a : Δt : {v}", "m a Δs W", "21", "",
         "m c M V", "m = c M V", "m M n", "46", "",
         "m F k P v1", "m = -F ^ 3 : k : P : (P : F - v1) : 2", "m F k v1 {v}", "62", "",
         "m F k P v2", "m = -F ^ 3 : k : P : (v2 - P : F) : 2", "m F k v2 {v}", "62", "",
         "m F k P Δv", "m = -F ^ 3 : k : P : Δv", "m F P Δs Δv", "59", "",
         "m F k Δt v1", "m = -Δt : (2 : k : Δt + 2 v1 : F)", "m k Δs Δt v1", "59", "",
         "m F k Δt v2", "m = Δt : (2 : k : Δt + 2 v2 : F)", "m k Δs Δt v2", "59", "",
         "m F k v1 v2", "m = -2 F ^ 2 : k : (v2 ^ 2 - v1 ^ 2)", "m F k Δv {v}", "19", "",
         "m F k v1 Δv", "m = -(F ^ 2) : k : Δv : (v1 + Δv : 2)", "m F k Δv {v}", "18", "",
         "m F k v1 {v}", "m = -(F ^ 2) : k : {v} : ({v} - v1) : 2", "m F k Δv {v}", "16", "",
         "m F k v2 Δv", "m = -(F ^ 2) : k : Δv : (v2 - Δv : 2)", "m F k Δv {v}", "15", "",
         "m F k v2 {v}", "m = -(F ^ 2) : k : {v} : (v2 - {v}) : 2", "m F k Δv {v}", "13", "",
         "m F k Δv {v}", "m = -(F ^ 2) : k : Δv : {v}", "m k Δs Δv {v}", "59", "",
         "m F P Δs v1", "m = F ^ 3 Δs : (2 P ^ 2 - 2 F P v1)", "m F P v1 W", "29", "",
         "m F P Δs v2", "m = F ^ 3 Δs : (2 F P v2 - 2 P ^ 2)", "m F P v2 W", "29", "",
         "m F P Δs Δv", "m = F ^ 2 Δs : P : Δv", "m P Δs Δv W", "29", "",
         "m F P Δt v1", "m = F Δt : (P : F - v1) : 2", "m F Δt v1 W", "62", "",
         "m F P Δt v2", "m = F Δt : (v2 - P : F) : 2", "m F Δt v2 W", "62", "",
         "m F P v1 W", "m = F W : P : (P : F - v1) : 2", "m F P Δt v1", "43", "",
         "m F P v2 W", "m = F W : P : (v2 - P : F) : 2", "m F P Δt v2", "43", "",
         "m F P Δv W", "m = F W : P : Δv", "m F Δt Δv", "43", "",
         "m F Δs Δt v1", "m = F Δt : (Δs : Δt - v1) : 2", "m F Δt v1 {v}", "20", "",
         "m F Δs Δt v2", "m = F Δt : (v2 - Δs : Δt) : 2", "m F Δt v2 {v}", "20", "",
         "m F Δs v1 v2", "m = 2 F Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs Δv {v}", "19", "",
         "m F Δs v1 Δv", "m = F Δs : Δv : (v1 + Δv : 2)", "m F Δs Δv {v}", "18", "",
         "m F Δs v1 {v}", "m = F Δs : {v} : ({v} - v1) : 2", "m F Δs Δv {v}", "16", "",
         "m F Δs v2 Δv", "m = F Δs : Δv : (v2 - Δv : 2)", "m F Δs Δv {v}", "15", "",
         "m F Δs v2 {v}", "m = F Δs : {v} : (v2 - {v}) : 2", "m F Δs Δv {v}", "13", "",
         "m F Δs Δv {v}", "m = F Δs : Δv : {v}", "m F Δt Δv", "22", "",
         "m F Δt v1 {v}", "m = F Δt : ({v} - v1) : 2", "m F Δt Δv", "16", "",
         "m F Δt v1 W", "m = F Δt : (W : F : Δt - v1) : 2", "m F Δs Δt v1", "31", "",
         "m F Δt v2 {v}", "m = F Δt : (v2 - {v}) : 2", "m F Δt Δv", "13", "",
         "m F Δt v2 W", "m = F Δt : (v2 - W : F : Δt) : 2", "m F Δs Δt v2", "31", "",
         "m F Δt Δv", "m = F Δt : Δv", "m a F", "23", "",
         "m |Fn| μg P Δs v1", "m = (|Fn| μg) ^ 2 Δs : P : (P : |Fn| : μg - v1) : 2", "m F P Δs v1", "85", "",
         "m |Fn| μg P Δs v2", "m = (|Fn| μg) ^ 2 Δs : P : (v2 - P : |Fn| : μg) : 2", "m F P Δs v2", "85", "",
         "m |Fn| μg P Δs Δv", "m = (|Fn| μg) ^ 2 Δs : P : Δv", "m F P Δs Δv", "85", "",
         "m |Fn| μg P Δt v1", "m = |Fn| μg Δt : (P : |Fn| : μg - v1) : 2", "m F P Δt v1", "85", "",
         "m |Fn| μg P Δt v2", "m = |Fn| μg Δt : (v2 - P : |Fn| : μg) : 2", "m F P Δt v2", "85", "",
         "m |Fn| μg P v1 W", "m = |Fn| μg W : P : (P : |Fn| : μg - v1) : 2", "m F P v1 W", "85", "",
         "m |Fn| μg P v2 W", "m = |Fn| μg W : P : (v2 - P : |Fn| : μg) : 2", "m F P v2 W", "85", "",
         "m |Fn| μg P Δv W", "m = |Fn| μg W : P : Δv", "m F P Δv W", "85", "",
         "m |Fn| μg Δs Δt v1", "m = |Fn| μg Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "85", "",
         "m |Fn| μg Δs Δt v2", "m = |Fn| μg Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "85", "",
         "m |Fn| μg Δs v1 v2", "m = 2 |Fn| μg Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "85", "",
         "m |Fn| μg Δs v1 Δv", "m = |Fn| μg Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "85", "",
         "m |Fn| μg Δs v1 {v}", "m = |Fn| μg Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "85", "",
         "m |Fn| μg Δs v2 Δv", "m = |Fn| μg Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "85", "",
         "m |Fn| μg Δs v2 {v}", "m = |Fn| μg Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "85", "",
         "m |Fn| μg Δs Δv {v}", "m = |Fn| μg Δs : Δv : {v}", "m F Δs Δv {v}", "85", "",
         "m |Fn| μg Δt v1 {v}", "m = |Fn| μg Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "85", "",
         "m |Fn| μg Δt v1 W", "m = |Fn| μg Δt : (W : |Fn| : μg : Δt - v1) : 2", "m F Δt v1 W", "85", "",
         "m |Fn| μg Δt v2 {v}", "m = |Fn| μg Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "85", "",
         "m |Fn| μg Δt v2 W", "m = |Fn| μg Δt : (v2 - W : |Fn| : μg : Δt) : 2", "m F Δt v2 W", "85", "",
         "m |Fn| μg Δt Δv", "m = |Fn| μg Δt : Δv", "m F Δt Δv", "85", "",
         "m |Fn| μh P Δs v1", "m = (|Fn| μh) ^ 2 Δs : P : (P : |Fn| : μh - v1) : 2", "m F P Δs v1", "88", "",
         "m |Fn| μh P Δs v2", "m = (|Fn| μh) ^ 2 Δs : P : (v2 - P : |Fn| : μh) : 2", "m F P Δs v2", "88", "",
         "m |Fn| μh P Δs Δv", "m = (|Fn| μh) ^ 2 Δs : P : Δv", "m F P Δs Δv", "88", "",
         "m |Fn| μh P Δt v1", "m = |Fn| μh Δt : (P : |Fn| : μh - v1) : 2", "m F P Δt v1", "88", "",
         "m |Fn| μh P Δt v2", "m = |Fn| μh Δt : (v2 - P : |Fn| : μh) : 2", "m F P Δt v2", "88", "",
         "m |Fn| μh P v1 W", "m = |Fn| μh W : P : (P : |Fn| : μh - v1) : 2", "m F P v1 W", "88", "",
         "m |Fn| μh P v2 W", "m = |Fn| μh W : P : (v2 - P : |Fn| : μh) : 2", "m F P v2 W", "88", "",
         "m |Fn| μh P Δv W", "m = |Fn| μh W : P : Δv", "m F P Δv W", "88", "",
         "m |Fn| μh Δs Δt v1", "m = |Fn| μh Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "88", "",
         "m |Fn| μh Δs Δt v2", "m = |Fn| μh Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "88", "",
         "m |Fn| μh Δs v1 v2", "m = 2 |Fn| μh Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "88", "",
         "m |Fn| μh Δs v1 Δv", "m = |Fn| μh Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "88", "",
         "m |Fn| μh Δs v1 {v}", "m = |Fn| μh Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "88", "",
         "m |Fn| μh Δs v2 Δv", "m = |Fn| μh Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "88", "",
         "m |Fn| μh Δs v2 {v}", "m = |Fn| μh Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "88", "",
         "m |Fn| μh Δs Δv {v}", "m = |Fn| μh Δs : Δv : {v}", "m F Δs Δv {v}", "88", "",
         "m |Fn| μh Δt v1 {v}", "m = |Fn| μh Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "88", "",
         "m |Fn| μh Δt v1 W", "m = |Fn| μh Δt : (W : |Fn| : μh : Δt - v1) : 2", "m F Δt v1 W", "88", "",
         "m |Fn| μh Δt v2 {v}", "m = |Fn| μh Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "88", "",
         "m |Fn| μh Δt v2 W", "m = |Fn| μh Δt : (v2 - W : |Fn| : μh : Δt) : 2", "m F Δt v2 W", "88", "",
         "m |Fn| μh Δt Δv", "m = |Fn| μh Δt : Δv", "m F Δt Δv", "88", "",
         "m |Fn| μr P Δs v1", "m = (|Fn| μr) ^ 2 Δs : P : (P : |Fn| : μr - v1) : 2", "m F P Δs v1", "91", "",
         "m |Fn| μr P Δs v2", "m = (|Fn| μr) ^ 2 Δs : P : (v2 - P : |Fn| : μr) : 2", "m F P Δs v2", "91", "",
         "m |Fn| μr P Δs Δv", "m = (|Fn| μr) ^ 2 Δs : P : Δv", "m F P Δs Δv", "91", "",
         "m |Fn| μr P Δt v1", "m = |Fn| μr Δt : (P : |Fn| : μr - v1) : 2", "m F P Δt v1", "91", "",
         "m |Fn| μr P Δt v2", "m = |Fn| μr Δt : (v2 - P : |Fn| : μr) : 2", "m F P Δt v2", "91", "",
         "m |Fn| μr P v1 W", "m = |Fn| μr W : P : (P : |Fn| : μr - v1) : 2", "m F P v1 W", "91", "",
         "m |Fn| μr P v2 W", "m = |Fn| μr W : P : (v2 - P : |Fn| : μr) : 2", "m F P v2 W", "91", "",
         "m |Fn| μr P Δv W", "m = |Fn| μr W : P : Δv", "m F P Δv W", "91", "",
         "m |Fn| μr Δs Δt v1", "m = |Fn| μr Δt : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "91", "",
         "m |Fn| μr Δs Δt v2", "m = |Fn| μr Δt : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "91", "",
         "m |Fn| μr Δs v1 v2", "m = 2 |Fn| μr Δs : (v2 ^ 2 - v1 ^ 2)", "m F Δs v1 v2", "91", "",
         "m |Fn| μr Δs v1 Δv", "m = |Fn| μr Δs : Δv : (v1 + Δv : 2)", "m F Δs v1 Δv", "91", "",
         "m |Fn| μr Δs v1 {v}", "m = |Fn| μr Δs : {v} : ({v} - v1) : 2", "m F Δs v1 {v}", "91", "",
         "m |Fn| μr Δs v2 Δv", "m = |Fn| μr Δs : Δv : (v2 - Δv : 2)", "m F Δs v2 Δv", "91", "",
         "m |Fn| μr Δs v2 {v}", "m = |Fn| μr Δs : {v} : (v2 - {v}) : 2", "m F Δs v2 {v}", "91", "",
         "m |Fn| μr Δs Δv {v}", "m = |Fn| μr Δs : Δv : {v}", "m F Δs Δv {v}", "91", "",
         "m |Fn| μr Δt v1 {v}", "m = |Fn| μr Δt : ({v} - v1) : 2", "m F Δt v1 {v}", "91", "",
         "m |Fn| μr Δt v1 W", "m = |Fn| μr Δt : (W : |Fn| : μr : Δt - v1) : 2", "m F Δt v1 W", "91", "",
         "m |Fn| μr Δt v2 {v}", "m = |Fn| μr Δt : (v2 - {v}) : 2", "m F Δt v2 {v}", "91", "",
         "m |Fn| μr Δt v2 W", "m = |Fn| μr Δt : (v2 - W : |Fn| : μr : Δt) : 2", "m F Δt v2 W", "91", "",
         "m |Fn| μr Δt Δv", "m = |Fn| μr Δt : Δv", "m F Δt Δv", "91", "",
         "m M n", "m = M n", "", "49", "",
         "m k P Δs v1", "m = -k ^ 3 Δs ^ 4 : P : (P + k Δs v1) : 2", "m F k P v1", "57", "",
         "m k P Δs v2", "m = k ^ 3 Δs ^ 4 : P : (P + k Δs v2) : 2", "m F k P v2", "57", "",
         "m k P Δs Δv", "m = -k ^ 2 Δs ^ 3 : P : Δv", "m F P Δs Δv", "57", "",
         "m k P Δt v1", "m = -k Δt ^ 2 : (2 v1 √(-k Δt : P) + 2)", "m k Δt v1 W", "44", "",
         "m k P Δt v2", "m = k Δt ^ 2 : (2 v2 √(-k Δt : P) + 2)", "m k Δt v2 W", "44", "",
         "m k P Δt Δv", "m = √(-k P Δt) Δt : Δv", "m a k P Δt", "23", "",
         "m k P v1 v2", "m = -8 P ^ 2 : k : (v2 - v1) : (v1 + v2) ^ 3", "m k P Δv {v}", "19", "",
         "m k P v1 Δv", "m = -(P ^ 2) : k : Δv : (v1 + Δv : 2) ^ 3", "m k P Δv {v}", "18", "",
         "m k P v1 {v}", "m = -(P ^ 2) : k : {v} ^ 3 : ({v} - v1) : 2", "m k P Δv {v}", "16", "",
         "m k P v1 W", "m = -k W : (2 P v1 √(-k : W) + 2 P ^ 2 : W)", "m k Δt v1 W", "43", "",
         "m k P v2 Δv", "m = -(P ^ 2) : k : Δv : (v2 - Δv : 2) ^ 3", "m k P Δv {v}", "15", "",
         "m k P v2 {v}", "m = -(P ^ 2) : k : {v} ^ 3 : (v2 - {v}) : 2", "m k P Δv {v}", "13", "",
         "m k P v2 W", "m = k W : (2 P v2 √(-k : W) + 2 P ^ 2 : W)", "m k Δt v2 W", "43", "",
         "m k P Δv {v}", "m = -(P ^ 2) : k : Δv : {v} ^ 3", "m F k Δv {v}", "61", "",
         "m k P Δv W", "m = √(-k W) W : P : Δv", "m k P Δt Δv", "43", "",
         "m k Δs Δt v1", "m = -k Δs Δt : (Δs : Δt - v1) : 2", "m k Δs v1 {v}", "20", "",
         "m k Δs Δt v2", "m = -k Δs Δt : (v2 - Δs : Δt) : 2", "m k Δs v2 {v}", "20", "",
         "m k Δs Δt Δv", "m = -k Δs Δt : Δv", "m a k Δs", "23", "",
         "m k Δs v1 v2", "m = -2 k Δs ^ 2 : (v2 ^ 2 - v1 ^ 2)", "m k Δs Δv {v}", "19", "",
         "m k Δs v1 Δv", "m = -k Δs ^ 2 : Δv : (v1 + Δv : 2)", "m k Δs Δv {v}", "18", "",
         "m k Δs v1 {v}", "m = -k Δs ^ 2 : {v} : ({v} - v1) : 2", "m k Δs Δv {v}", "16", "",
         "m k Δs v2 Δv", "m = -k Δs ^ 2 : Δv : (v2 - Δv : 2)", "m k Δs Δv {v}", "15", "",
         "m k Δs v2 {v}", "m = -k Δs ^ 2 : {v} : (v2 - {v}) : 2", "m k Δs Δv {v}", "13", "",
         "m k Δs Δv {v}", "m = -k Δs ^ 2 : Δv : {v}", "m k Δs Δt Δv", "22", "",
         "m k Δt v1 v2", "m = -k Δt ^ 2 (v1 + v2) : (v2 - v1) : 2", "m k Δt Δv {v}", "19", "",
         "m k Δt v1 Δv", "m = -k Δt ^ 2 (v1 + Δv : 2) : Δv", "m k Δt Δv {v}", "18", "",
         "m k Δt v1 {v}", "m = -k Δt ^ 2 {v} : ({v} - v1) : 2", "m k Δt Δv {v}", "16", "",
         "m k Δt v1 W", "m = -k Δt : (2 v1 √(-k : W) + 2 : Δt)", "m k Δt Δv W", "70", "",
         "m k Δt v2 Δv", "m = -k Δt ^ 2 (v2 - Δv : 2) : Δv", "m k Δt Δv {v}", "15", "",
         "m k Δt v2 {v}", "m = -k Δt ^ 2 {v} : (v2 - {v}) : 2", "m k Δt Δv {v}", "13", "",
         "m k Δt v2 W", "m = k Δt : (2 v2 √(-k : W) + 2 : Δt)", "m k Δt Δv W", "74", "",
         "m k Δt Δv {v}", "m = -k Δt ^ 2 {v} : Δv", "m k Δs Δt Δv", "21", "",
         "m k Δt Δv W", "m = √(-k W) Δt : Δv", "m a k W", "23", "",
         "m P Δs Δt v1", "m = P Δt ^ 2 : Δs : (Δs : Δt - v1) : 2", "m Δs Δt v1 W", "44", "",
         "m P Δs Δt v2", "m = P Δt ^ 2 : Δs : (v2 - Δs : Δt) : 2", "m Δs Δt v2 W", "44", "",
         "m P Δs Δt Δv", "m = P Δt ^ 2 : Δs : Δv", "m a P Δs Δt", "23", "",
         "m P Δs v1 v2", "m = 4 P Δs : (v2 ^ 2 - v1 ^ 2) : (v1 + v2)", "m P Δs Δv {v}", "19", "",
         "m P Δs v1 Δv", "m = P Δs : Δv : (v1 + Δv : 2) ^ 2", "m P Δs Δv {v}", "18", "",
         "m P Δs v1 {v}", "m = P Δs : {v} ^ 2 : ({v} - v1) : 2", "m P Δs Δv {v}", "16", "",
         "m P Δs v1 W", "m = W ^ 3 : (2 (P Δs) ^ 2 - 2 P Δs v1 W)", "m F P Δs v1", "30", "",
         "m P Δs v2 Δv", "m = P Δs : Δv : (v2 - Δv : 2) ^ 2", "m P Δs Δv {v}", "15", "",
         "m P Δs v2 {v}", "m = P Δs : {v} ^ 2 : (v2 - {v}) : 2", "m P Δs Δv {v}", "13", "",
         "m P Δs v2 W", "m = W ^ 3 : (2 P Δs v2 W - 2 (P Δs) ^ 2)", "m F P Δs v2", "30", "",
         "m P Δs Δv {v}", "m = P Δs : Δv : {v} ^ 2", "m P Δt Δv {v}", "22", "",
         "m P Δs Δv W", "m = W ^ 2 : P : Δs : Δv", "m F P Δv W", "30", "",
         "m P Δt v1 v2", "m = 2 P Δt : (v2 ^ 2 - v1 ^ 2)", "m P Δt Δv {v}", "19", "",
         "m P Δt v1 Δv", "m = P Δt : Δv : (v1 + Δv : 2)", "m P Δt Δv {v}", "18", "",
         "m P Δt v1 {v}", "m = P Δt : {v} : ({v} - v1) : 2", "m P Δt Δv {v}", "16", "",
         "m P Δt v2 Δv", "m = P Δt : Δv : (v2 - Δv : 2)", "m P Δt Δv {v}", "15", "",
         "m P Δt v2 {v}", "m = P Δt : {v} : (v2 - {v}) : 2", "m P Δt Δv {v}", "13", "",
         "m P Δt Δv {v}", "m = P Δt : Δv : {v}", "m Δv {v} W", "61", "",
         "m p Δs Δt", "m = p Δt : Δs", "m p v", "51", "",
         "m p v", "m = p : v", "", "55", "",
         "m Δs Δt v1 W", "m = Δt W : Δs : (Δs : Δt - v1) : 2", "m F Δs Δt v1", "30", "",
         "m Δs Δt v2 W", "m = Δt W : Δs : (v2 - Δs : Δt) : 2", "m F Δs Δt v2", "30", "",
         "m Δs Δt Δv W", "m = W Δt : Δs : Δv", "m F Δt Δv", "30", "",
         "m v1 v2 W", "m = 2 W : (v2 ^ 2 - v1 ^ 2)", "m Δv {v} W", "19", "",
         "m v1 Δv W", "m = W : Δv : (v1 + Δv : 2)", "m Δv {v} W", "18", "",
         "m v1 {v} W", "m = W : {v} : ({v} - v1) : 2", "m Δv {v} W", "16", "",
         "m v2 Δv W", "m = W : Δv : (v2 - Δv : 2)", "m Δv {v} W", "15", "",
         "m v2 {v} W", "m = W : {v} : (v2 - {v}) : 2", "m Δv {v} W", "13", "",
         "m Δv {v} W", "m = W : Δv : {v}", "m a Δt {v} W", "23", ""];
          CAI = AA[0];
        } // m
        if (AA[0] == FAB[117])
        {
          FAC = [
         "μg a |Fn| m", "μg = a m : |Fn|", "μg F |Fn|", "26", "",
         "μg a |Fn| P Δs v1", "μg = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μg a |Fn| P v1 W", "94", "",
         "μg a |Fn| P Δs v2", "μg = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μg a |Fn| P v2 W", "94", "",
         "μg a |Fn| P Δs Δv", "μg = P Δv : a : |Fn| : Δs", "μg |Fn| P Δs Δt", "25", "",
         "μg a |Fn| P Δt v1", "μg = P : |Fn| : (v1 + a Δt : 2)", "μg |Fn| P v1 Δv", "24", "",
         "μg a |Fn| P Δt v2", "μg = P : |Fn| : (v2 - a Δt : 2)", "μg |Fn| P v2 Δv", "24", "",
         "μg a |Fn| P v1 W", "μg = P : |Fn| : (v1 + a W : 2 : P)", "μg a |Fn| P Δt v1", "43", "",
         "μg a |Fn| P v2 W", "μg = P : |Fn| : (v2 - a W : 2 : P)", "μg a |Fn| P Δt v2", "43", "",
         "μg a |Fn| Δt v1 W", "μg = W : |Fn| : Δt : (v1 + a Δt : 2)", "μg |Fn| Δt v1 Δv W", "24", "",
         "μg a |Fn| Δt v2 W", "μg = W : |Fn| : Δt : (v2 - a Δt : 2)", "μg |Fn| Δt v2 Δv W", "24", "",
         "μg a |Fn| v1 v2 W", "μg = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μg a |Fn| Δv {v} W", "19", "",
         "μg a |Fn| v1 Δv W", "μg = a W : |Fn| : Δv : (v1 + Δv : 2)", "μg a |Fn| Δv {v} W", "18", "",
         "μg a |Fn| v1 {v} W", "μg = a W : |Fn| : {v} : ({v} - v1) : 2", "μg a |Fn| Δv {v} W", "16", "",
         "μg a |Fn| v2 Δv W", "μg = a W : |Fn| : Δv : (v2 - Δv : 2)", "μg a |Fn| Δv {v} W", "15", "",
         "μg a |Fn| v2 {v} W", "μg = a W : |Fn| : {v} : (v2 - {v}) : 2", "μg a |Fn| Δv {v} W", "13", "",
         "μg a |Fn| Δv {v} W", "μg = a W : |Fn| : Δv : {v}", "μg |Fn| Δt {v} W", "25", "",
         "μg F Ff |Fn|", "μg = (F - Ff) : |Fn|", "", "0", "",
         "μg F Ff |Fn| Ft", "μg = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μg F |Fn|", "μg = F : |Fn|", "", "87", "",
         "μg F |Fn| Ft", "μg = (F - Ft) : |Fn|", "", "0", "",
         "μg F |Fn| Ft k Δs", "μg = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μg F |Fn| k Δs", "μg = (F + k Δs) : |Fn|", "", "0", "",
         "μg |Fn| Frg", "μg = Frg : |Fn|", "", "0", "",
         "μg |Fn| m P Δs Δv", "μg = √(P m Δv : Δs) : |Fn|", "μg |Fn| m P Δv W", "94", "",
         "μg |Fn| m P Δt v1", "μg = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μg |Fn| m Δt v1 W", "44", "",
         "μg |Fn| m P Δt v2", "μg = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μg |Fn| m Δt v2 W", "44", "",
         "μg |Fn| m P v1 W", "μg = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μg |Fn| m Δt v1 W", "43", "",
         "μg |Fn| m P v2 W", "μg = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μg |Fn| m Δt v2 W", "43", "",
         "μg |Fn| m P Δv W", "μg = m P Δv : |Fn| : W", "μg |Fn| m Δt Δv", "43", "",
         "μg |Fn| m Δs Δt v1", "μg = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μg |Fn| m Δt v1 {v}", "20", "",
         "μg |Fn| m Δs Δt v2", "μg = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μg |Fn| m Δt v2 {v}", "20", "",
         "μg |Fn| m Δs v1 v2", "μg = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μg |Fn| m Δs Δv {v}", "19", "",
         "μg |Fn| m Δs v1 Δv", "μg = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "18", "",
         "μg |Fn| m Δs v1 {v}", "μg = 2 m {v} ({v} - v1) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "16", "",
         "μg |Fn| m Δs v2 Δv", "μg = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "15", "",
         "μg |Fn| m Δs v2 {v}", "μg = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μg |Fn| m Δs Δv {v}", "13", "",
         "μg |Fn| m Δs Δv {v}", "μg = m Δv {v} : |Fn| : Δs", "μg |Fn| m Δt Δv", "22", "",
         "μg |Fn| m Δt v1 {v}", "μg = 2 m ({v} - v1) : |Fn| : Δt", "μg |Fn| m Δt Δv", "16", "",
         "μg |Fn| m Δt v1 W", "μg = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μg |Fn| m Δt Δv", "70", "",
         "μg |Fn| m Δt v2 {v}", "μg = 2 m (v2 - {v}) : |Fn| : Δt", "μg |Fn| m Δt Δv", "13", "",
         "μg |Fn| m Δt v2 W", "μg = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μg |Fn| m Δt Δv", "74", "",
         "μg |Fn| m Δt Δv", "μg = m Δv : |Fn| : Δt", "μg a |Fn| m", "23", "",
         "μg |Fn| P Δs Δt", "μg = P Δt : |Fn| : Δs", "μg |Fn| Δs W", "44", "",
         "μg |Fn| P v1 v2", "μg = 2 P : |Fn| : (v1 + v2)", "μg |Fn| P {v}", "10", "",
         "μg |Fn| P v1 Δv", "μg = P : |Fn| : (v1 + Δv : 2)", "μg |Fn| P {v}", "18", "",
         "μg |Fn| P v2 Δv", "μg = P : |Fn| : (v2 - Δv : 2)", "μg |Fn| P {v}", "15", "",
         "μg |Fn| P {v}", "μg = P : |Fn| : {v}", "μg |Fn| P Δs Δt", "21", "",
         "μg |Fn| Δs W", "μg = W : |Fn| : Δs", "", "96", "",
         "μg |Fn| Δt v1 v2 W", "μg = 2 W : |Fn| : Δt : (v1 + v2)", "μg |Fn| Δt {v} W", "10", "",
         "μg |Fn| Δt v1 Δv W", "μg = W : |Fn| : Δt : (v1 + Δv : 2)", "μg |Fn| Δt {v} W", "18", "",
         "μg |Fn| Δt v2 Δv W", "μg = W : |Fn| : Δt : (v2 - Δv : 2)", "μg |Fn| Δt {v} W", "15", "",
         "μg |Fn| Δt {v} W", "μg = W : |Fn| : Δt : {v}", "μg |Fn| Δs W", "21", ""];
          CAI = AA[0];
        } // μg
        if (AA[0] == FAB[120])
        {
          FAC = [
         "μh a |Fn| m", "μh = a m : |Fn|", "μh F |Fn|", "26", "",
         "μh a |Fn| P Δs v1", "μh = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μh a |Fn| P v1 W", "98", "",
         "μh a |Fn| P Δs v2", "μh = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μh a |Fn| P v2 W", "98", "",
         "μh a |Fn| P Δs Δv", "μh = P Δv : a : |Fn| : Δs", "μh |Fn| P Δs Δt", "25", "",
         "μh a |Fn| P Δt v1", "μh = P : |Fn| : (v1 + a Δt : 2)", "μh |Fn| P v1 Δv", "24", "",
         "μh a |Fn| P Δt v2", "μh = P : |Fn| : (v2 - a Δt : 2)", "μh |Fn| P v2 Δv", "24", "",
         "μh a |Fn| P v1 W", "μh = P : |Fn| : (v1 + a W : 2 : P)", "μh a |Fn| P Δt v1", "43", "",
         "μh a |Fn| P v2 W", "μh = P : |Fn| : (v2 - a W : 2 : P)", "μh a |Fn| P Δt v2", "43", "",
         "μh a |Fn| Δt v1 W", "μh = W : |Fn| : Δt : (v1 + a Δt : 2)", "μh |Fn| Δt v1 Δv W", "24", "",
         "μh a |Fn| Δt v2 W", "μh = W : |Fn| : Δt : (v2 - a Δt : 2)", "μh |Fn| Δt v2 Δv W", "24", "",
         "μh a |Fn| v1 v2 W", "μh = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μh a |Fn| Δv {v} W", "19", "",
         "μh a |Fn| v1 Δv W", "μh = a W : |Fn| : Δv : (v1 + Δv : 2)", "μh a |Fn| Δv {v} W", "18", "",
         "μh a |Fn| v1 {v} W", "μh = a W : |Fn| : {v} : ({v} - v1) : 2", "μh a |Fn| Δv {v} W", "16", "",
         "μh a |Fn| v2 Δv W", "μh = a W : |Fn| : Δv : (v2 - Δv : 2)", "μh a |Fn| Δv {v} W", "15", "",
         "μh a |Fn| v2 {v} W", "μh = a W : |Fn| : {v} : (v2 - {v}) : 2", "μh a |Fn| Δv {v} W", "13", "",
         "μh a |Fn| Δv {v} W", "μh = a W : |Fn| : Δv : {v}", "μh |Fn| Δt {v} W", "25", "",
         "μh F Ff |Fn|", "μh = (F - Ff) : |Fn|", "", "0", "",
         "μh F Ff |Fn| Ft", "μh = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μh F |Fn|", "μh = F : |Fn|", "", "90", "",
         "μh F |Fn| Ft", "μh = (F - Ft) : |Fn|", "", "0", "",
         "μh F |Fn| Ft k Δs", "μh = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μh F |Fn| k Δs", "μh = (F + k Δs) : |Fn|", "", "0", "",
         "μh |Fn| Frh", "μh = Frh : |Fn|", "", "0", "",
         "μh |Fn| m P Δs Δv", "μh = √(P m Δv : Δs) : |Fn|", "μh |Fn| m P Δv W", "98", "",
         "μh |Fn| m P Δt v1", "μh = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μh |Fn| m Δt v1 W", "44", "",
         "μh |Fn| m P Δt v2", "μh = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μh |Fn| m Δt v2 W", "44", "",
         "μh |Fn| m P v1 W", "μh = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μh |Fn| m Δt v1 W", "43", "",
         "μh |Fn| m P v2 W", "μh = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μh |Fn| m Δt v2 W", "43", "",
         "μh |Fn| m P Δv W", "μh = m P Δv : |Fn| : W", "μh |Fn| m Δt Δv", "43", "",
         "μh |Fn| m Δs Δt v1", "μh = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μh |Fn| m Δt v1 {v}", "20", "",
         "μh |Fn| m Δs Δt v2", "μh = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μh |Fn| m Δt v2 {v}", "20", "",
         "μh |Fn| m Δs v1 v2", "μh = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μh |Fn| m Δs Δv {v}", "19", "",
         "μh |Fn| m Δs v1 Δv", "μh = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "18", "",
         "μh |Fn| m Δs v1 {v}", "μh = 2 m {v} ({v} - v1) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "16", "",
         "μh |Fn| m Δs v2 Δv", "μh = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "15", "",
         "μh |Fn| m Δs v2 {v}", "μh = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μh |Fn| m Δs Δv {v}", "13", "",
         "μh |Fn| m Δs Δv {v}", "μh = m Δv {v} : |Fn| : Δs", "μh |Fn| m Δt Δv", "22", "",
         "μh |Fn| m Δt v1 {v}", "μh = 2 m ({v} - v1) : |Fn| : Δt", "μh |Fn| m Δt Δv", "16", "",
         "μh |Fn| m Δt v1 W", "μh = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μh |Fn| m Δt Δv", "70", "",
         "μh |Fn| m Δt v2 {v}", "μh = 2 m (v2 - {v}) : |Fn| : Δt", "μh |Fn| m Δt Δv", "13", "",
         "μh |Fn| m Δt v2 W", "μh = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μh |Fn| m Δt Δv", "74", "",
         "μh |Fn| m Δt Δv", "μh = m Δv : |Fn| : Δt", "μh a |Fn| m", "23", "",
         "μh |Fn| P Δs Δt", "μh = P Δt : |Fn| : Δs", "μh |Fn| Δs W", "44", "",
         "μh |Fn| P v1 v2", "μh = 2 P : |Fn| : (v1 + v2)", "μh |Fn| P {v}", "10", "",
         "μh |Fn| P v1 Δv", "μh = P : |Fn| : (v1 + Δv : 2)", "μh |Fn| P {v}", "18", "",
         "μh |Fn| P v2 Δv", "μh = P : |Fn| : (v2 - Δv : 2)", "μh |Fn| P {v}", "15", "",
         "μh |Fn| P {v}", "μh = P : |Fn| : {v}", "μh |Fn| P Δs Δt", "10", "",
         "μh |Fn| Δs W", "μh = W : |Fn| : Δs", "", "100", "",
         "μh |Fn| Δt v1 v2 W", "μh = 2 W : |Fn| : Δt : (v1 + v2)", "μh |Fn| Δt {v} W", "10", "",
         "μh |Fn| Δt v1 Δv W", "μh = W : |Fn| : Δt : (v1 + Δv : 2)", "μh |Fn| Δt {v} W", "18", "",
         "μh |Fn| Δt v2 Δv W", "μh = W : |Fn| : Δt : (v2 - Δv : 2)", "μh |Fn| Δt {v} W", "15", "",
         "μh |Fn| Δt {v} W", "μh = W : |Fn| : Δt : {v}", "μh |Fn| Δs W", "21", ""];
          CAI = AA[0];
        } // μh
        if (AA[0] == FAB[123])
        {
          FAC = [
         "μr a |Fn| m", "μr = a m : |Fn|", "μr F |Fn|", "26", "",
         "μr a |Fn| P Δs v1", "μr = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a : |Fn| : Δs", "μr a |Fn| P v1 W", "102", "",
         "μr a |Fn| P Δs v2", "μr = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a : |Fn| : Δs", "μr a |Fn| P v2 W", "102", "",
         "μr a |Fn| P Δs Δv", "μr = P Δv : a : |Fn| : Δs", "μr |Fn| P Δs Δt", "25", "",
         "μr a |Fn| P Δt v1", "μr = P : |Fn| : (v1 + a Δt : 2)", "μr |Fn| P v1 Δv", "24", "",
         "μr a |Fn| P Δt v2", "μr = P : |Fn| : (v2 - a Δt : 2)", "μr |Fn| P v2 Δv", "24", "",
         "μr a |Fn| P v1 W", "μr = P : |Fn| : (v1 + a W : 2 : P)", "μr a |Fn| P Δt v1", "43", "",
         "μr a |Fn| P v2 W", "μr = P : |Fn| : (v2 - a W : 2 : P)", "μr a |Fn| P Δt v2", "43", "",
         "μr a |Fn| Δt v1 W", "μr = W : |Fn| : Δt : (v1 + a Δt : 2)", "μr |Fn| Δt v1 Δv W", "24", "",
         "μr a |Fn| Δt v2 W", "μr = W : |Fn| : Δt : (v2 - a Δt : 2)", "μr |Fn| Δt v2 Δv W", "24", "",
         "μr a |Fn| v1 v2 W", "μr = 2 a W : |Fn| : (v2 ^ 2 - v1 ^ 2)", "μr a |Fn| Δv {v} W", "19", "",
         "μr a |Fn| v1 Δv W", "μr = a W : |Fn| : Δv : (v1 + Δv : 2)", "μr a |Fn| Δv {v} W", "18", "",
         "μr a |Fn| v1 {v} W", "μr = a W : |Fn| : {v} : ({v} - v1) : 2", "μr a |Fn| Δv {v} W", "16", "",
         "μr a |Fn| v2 Δv W", "μr = a W : |Fn| : Δv : (v2 - Δv : 2)", "μr a |Fn| Δv {v} W", "15", "",
         "μr a |Fn| v2 {v} W", "μr = a W : |Fn| : {v} : (v2 - {v}) : 2", "μr a |Fn| Δv {v} W", "13", "",
         "μr a |Fn| Δv {v} W", "μr = a W : |Fn| : Δv : {v}", "μr |Fn| Δt {v} W", "25", "",
         "μr F Ff |Fn|", "μr = (F - Ff) : |Fn|", "", "0", "",
         "μr F Ff |Fn| Ft", "μr = (F - Ft - Ff) : |Fn|", "", "0", "",
         "μr F |Fn|", "μr = F : |Fn|", "", "93", "",
         "μr F |Fn| Ft", "μr = (F - Ft) : |Fn|", "", "0", "",
         "μr F |Fn| Ft k Δs", "μr = (F + k Δs - Ft) : |Fn|", "", "0", "",
         "μr F |Fn| k Δs", "μr = (F + k Δs) : |Fn|", "", "0", "",
         "μr |Fn| Frr", "μr = Frr : |Fn|", "", "0", "",
         "μr |Fn| m P Δs Δv", "μr = √(P m Δv : Δs) : |Fn|", "μr |Fn| m P Δv W", "102", "",
         "μr |Fn| m P Δt v1", "μr = m (-v1 ± √(v1 ^ 2 + 2 P Δt : m)) : |Fn| : Δt", "μr |Fn| m Δt v1 W", "44", "",
         "μr |Fn| m P Δt v2", "μr = m (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : |Fn| : Δt", "μr |Fn| m Δt v2 W", "44", "",
         "μr |Fn| m P v1 W", "μr = m P (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : W", "μr |Fn| m Δt v1 W", "43", "",
         "μr |Fn| m P v2 W", "μr = m P (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : W", "μr |Fn| m Δt v2 W", "43", "",
         "μr |Fn| m P Δv W", "μr = m P Δv : |Fn| : W", "μr |Fn| m Δt Δv", "43", "",
         "μr |Fn| m Δs Δt v1", "μr = 2 m (Δs : Δt - v1) : |Fn| : Δt", "μr |Fn| m Δt v1 {v}", "20", "",
         "μr |Fn| m Δs Δt v2", "μr = 2 m (v2 - Δs : Δt) : |Fn| : Δt", "μr |Fn| m Δt v2 {v}", "20", "",
         "μr |Fn| m Δs v1 v2", "μr = m (v2 ^ 2 - v1 ^ 2) : |Fn| : Δs : 2", "μr |Fn| m Δs Δv {v}", "19", "",
         "μr |Fn| m Δs v1 Δv", "μr = m Δv (v1 + Δv : 2) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "18", "",
         "μr |Fn| m Δs v1 {v}", "μr = 2 m {v} ({v} - v1) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "16", "",
         "μr |Fn| m Δs v2 Δv", "μr = m Δv (v2 - Δv : 2) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "15", "",
         "μr |Fn| m Δs v2 {v}", "μr = 2 m {v} (v2 - {v}) : |Fn| : Δs", "μr |Fn| m Δs Δv {v}", "13", "",
         "μr |Fn| m Δs Δv {v}", "μr = m Δv {v} : |Fn| : Δs", "μr |Fn| m Δt Δv", "22", "",
         "μr |Fn| m Δt v1 {v}", "μr = 2 m ({v} - v1) : |Fn| : Δt", "μr |Fn| m Δt Δv", "16", "",
         "μr |Fn| m Δt v1 W", "μr = m (-v1 ± √(v1 ^ 2 + 2 W : m) : |Fn| : Δt", "μr |Fn| m Δt Δv", "70", "",
         "μr |Fn| m Δt v2 {v}", "μr = 2 m (v2 - {v}) : |Fn| : Δt", "μr |Fn| m Δt Δv", "13", "",
         "μr |Fn| m Δt v2 W", "μr = m (v2 ± √(v2 ^ 2 - 2 W : m) : |Fn| : Δt", "μr |Fn| m Δt Δv", "74", "",
         "μr |Fn| m Δt Δv", "μr = m Δv : |Fn| : Δt", "μr a |Fn| m", "23", "",
         "μr |Fn| P Δs Δt", "μr = P Δt : |Fn| : Δs", "μr |Fn| Δs W", "44", "",
         "μr |Fn| P v1 v2", "μr = 2 P : |Fn| : (v1 + v2)", "μr |Fn| P {v}", "10", "",
         "μr |Fn| P v1 Δv", "μr = P : |Fn| : (v1 + Δv : 2)", "μr |Fn| P {v}", "18", "",
         "μr |Fn| P v2 Δv", "μr = P : |Fn| : (v2 - Δv : 2)", "μr |Fn| P {v}", "15", "",
         "μr |Fn| P {v}", "μr = P : |Fn| : {v}", "μr |Fn| P Δs Δt", "21", "",
         "μr |Fn| Δs W", "μr = W : |Fn| : Δs", "", "104", "",
         "μr |Fn| Δt v1 v2 W", "μr = 2 W : |Fn| : Δt : (v1 + v2)", "μr |Fn| Δt {v} W", "10", "",
         "μr |Fn| Δt v1 Δv W", "μr = W : |Fn| : Δt : (v1 + Δv : 2)", "μr |Fn| Δt {v} W", "18", "",
         "μr |Fn| Δt v2 Δv W", "μr = W : |Fn| : Δt : (v2 - Δv : 2)", "μr |Fn| Δt {v} W", "15", "",
         "μr |Fn| Δt {v} W", "μr = W : |Fn| : Δt : {v}", "μr |Fn| Δs W", "21", ""];
          CAI = AA[0];
        } // μr
        if (AA[0] == FAB[126])
        {
          FAC = [
         "n c V", "n = c V", "", "45", "",
         "n M m", "n = m : M", "", "50", ""];
          CAI = AA[0];
        } // n
        if (AA[0] == FAB[129])
        {
          FAC = [
         "P a F k v1", "P = F (v1 ± √(v1 ^ 2 - 2 a F : k)) : 2", "P a F v1 W", "77", "",
         "P a F k v2", "P = F (v2 ± √(v2 ^ 2 + 2 a F : k)) : 2", "P a F v2 W", "77", "",
         "P a F k Δv", "P = -a F ^ 2 : k : Δv", "P F k Δt", "25", "",
         "P a F Δs v1", "P = F (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a m Δs v1 W", "29", "",
         "P a F Δs v2", "P = F (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a m Δs v2", "29", "",
         "P a F Δs Δv", "P = a F Δs : Δv", "P a Δv W", "29", "",
         "P a F Δt v1", "P = F (v1 + a Δt : 2)", "P F v1 Δv", "24", "",
         "P a F Δt v2", "P = F (v2 - a Δt : 2)", "P F v2 Δv", "24", "",
         "P a F v1 W", "P = F (v1 ± √(v1 ^ 2 + 2 a W : F)) : 2", "P F m v1 W", "43", "",
         "P a F v2 W", "P = F (v2 ± √(v2 ^ 2 - 2 a W : F)) : 2", "P F m v2 W", "43", "",
         "P a |Fn| μg Δs v1", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "85", "",
         "P a |Fn| μg Δs v2", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "85", "",
         "P a |Fn| μg Δs Δv", "P = a |Fn| μg Δs : Δv", "P a F Δs Δv", "85", "",
         "P a |Fn| μg Δt v1", "P = |Fn| μg (v1 + a Δt : 2)", "P a F Δt v1", "85", "",
         "P a |Fn| μg Δt v2", "P = |Fn| μg (v2 - a Δt : 2)", "P a F Δt v2", "85", "",
         "P a |Fn| μg v1 W", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : 2", "P a F v1 W", "85", "",
         "P a |Fn| μg v2 W", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : 2", "P a F v2 W", "85", "",
         "P a |Fn| μh Δs v1", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "88", "",
         "P a |Fn| μh Δs v2", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "88", "",
         "P a |Fn| μh Δs Δv", "P = a |Fn| μh Δs : Δv", "P a F Δs Δv", "88", "",
         "P a |Fn| μh Δt v1", "P = |Fn| μh (v1 + a Δt : 2)", "P a F Δt v1", "88", "",
         "P a |Fn| μh Δt v2", "P = |Fn| μh (v2 - a Δt : 2)", "P a F Δt v2", "88", "",
         "P a |Fn| μh v1 W", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : 2", "P a F v1 W", "88", "",
         "P a |Fn| μh v2 W", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : 2", "P a F v2 W", "88", "",
         "P a |Fn| μr Δs v1", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F Δs v1", "91", "",
         "P a |Fn| μr Δs v2", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F Δs v2", "91", "",
         "P a |Fn| μr Δs Δv", "P = a |Fn| μr Δs : Δv", "P a F Δs Δv", "91", "",
         "P a |Fn| μr Δt v1", "P = |Fn| μr (v1 + a Δt : 2)", "P a F Δt v1", "91", "",
         "P a |Fn| μr Δt v2", "P = |Fn| μr (v2 - a Δt : 2)", "P a F Δt v2", "91", "",
         "P a |Fn| μr v1 W", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : 2", "P a F v1 W", "91", "",
         "P a |Fn| μr v2 W", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : 2", "P a F v2 W", "91", "",
         "P a k m Δt", "P = -(a m) ^ 2 : k : Δt", "P F k Δt", "26", "",
         "P a k m v1", "P = a m (v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : 2", "P a F k v1", "26", "",
         "P a k m v2", "P = a m (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : 2", "P a F k v2", "26", "",
         "P a k m Δv", "P = -a ^ 3 m ^ 2 : k : Δv", "P F a k Δv", "26", "",
         "P a k Δs v1", "P = -k Δs (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P a F k v1", "57", "",
         "P a k Δs v2", "P = -k Δs (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P a F k v2", "57", "",
         "P a k Δs Δv", "P = -a k Δs ^ 2 : Δv", "P a F k Δv", "57", "",
         "P a k Δt v1", "P = -k Δt (v1 + a Δt : 2) ^ 2", "P k Δt v1 Δv", "24", "",
         "P a k Δt v2", "P = -k Δt (v2 - a Δt : 2) ^ 2", "P k Δt v2 Δv", "24", "",
         "P a k v1 v2", "P = -k (v2 - v1) (v1 + v2) ^ 2 : a : 4", "P a k Δv {v}", "19", "",
         "P a k v1 Δv", "P = -k Δv (v1 + Δv : 2) ^ 2 : a", "P a k Δv {v}", "18", "",
         "P a k v1 {v}", "P = -2 k ({v} - v1) {v} ^ 2 : a", "P a k Δv {v}", "16", "",
         "P a k v2 Δv", "P = -k Δv (v2 - Δv : 2) ^ 2 : a", "P a k Δv {v}", "15", "",
         "P a k v2 {v}", "P = -2 k (v2 - {v}) {v} ^ 2 : a", "P a k Δv {v}", "13", "",
         "P a k Δv {v}", "P = -k Δv {v} ^ 2 : a", "P k Δt {v}", "25", "",
         "P a m Δs Δt", "P = a m Δs : Δt", "P F Δs Δt", "26", "",
         "P a m Δs v1", "P = a m (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "P F m Δs v1", "26", "",
         "P a m Δs v2", "P = a m (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "P F m Δs v2", "26", "",
         "P a m Δs Δv", "P = a ^ 2 m Δs : Δv", "P a m Δs Δt", "25", "",
         "P a m Δt v1", "P = a m (v1 + a Δt : 2)", "P a m v1 Δv", "24", "",
         "P a m Δt v2", "P = a m (v2 - a Δt : 2)", "P a m v2 Δv", "24", "",
         "P a m v1 v2", "P = a m (v1 + v2) : 2", "P a m {v}", "10", "",
         "P a m v1 Δv", "P = a m (v1 + Δv : 2)", "P a m {v}", "18", "",
         "P a m v1 W", "P = a m (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "26", "",
         "P a m v2 Δv", "P = a m (v2 - Δv : 2)", "P a m {v}", "15", "",
         "P a m v2 W", "P = a m (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "26", "",
         "P a m {v}", "P = a m {v}", "P F {v}", "26", "",
         "P a Δs v1 W", "P = W (v1 ± √(v1 ^ 2 + 2 a Δs)) : Δs : 2", "P a F Δs v1", "30", "",
         "P a Δs v2 W", "P = W (v2 ± √(v2 ^ 2 - 2 a Δs)) : Δs : 2", "P a F Δs v2", "30", "",
         "P a v1 {v} W", "P = a W : ({v} - v1) : 2", "P a Δv W", "16", "",
         "P a v2 {v} W", "P = a W : (v2 - {v}) : 2", "P a Δv W", "13", "",
         "P a Δv W", "P = a W : Δv", "P Δt W", "25", "",
         "P F k m v1", "P = F (v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : 2", "P a F k v1", "27", "",
         "P F k m v2", "P = F (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : 2", "P a F k v2", "27", "",
         "P F k m Δv", "P = -F ^ 3 : k : m : Δv", "P a F k Δv", "27", "",
         "P F k Δt", "P = -(F ^ 2) : k : Δt", "P Δt W", "77", "",
         "P F m Δs v1", "P = F (v1 ± √(v1 ^ 2 + 2 F Δs : m)) : 2", "P F m v1 W", "27", "",
         "P F m Δs v2", "P = F (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : 2", "P F m v2 W", "27", "",
         "P F m Δs Δv", "P = F ^ 2 Δs : m : Δv", "P a F Δs Δv", "27", "",
         "P F m Δt v1", "P = F (v1 + F Δt : m : 2)", "P a F Δt v1", "27", "",
         "P F m Δt v2", "P = F (v2 - F Δt : m : 2)", "P a F Δt v2", "27", "",
         "P F m v1 W", "P = F (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m Δt v1", "43", "",
         "P F m v2 W", "P = F (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m Δt v2", "43", "",
         "P F m Δv W", "P = F W : m : Δv", "P a Δv W", "27", "",
         "P F Δs Δt", "P = F Δs : Δt", "P Δt W", "29", "",
         "P F v1 v2", "P = F (v1 + v2) : 2", "P F {v}", "10", "",
         "P F v1 Δv", "P = F (v1 + Δv : 2)", "P F {v}", "18", "",
         "P F v2 Δv", "P = F (v2 - Δv : 2)", "P F {v}", "15", "",
         "P F {v}", "P = F {v}", "P F Δs Δt", "21", "",
         "P |Fn| m μg Δs v1", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : 2", "P F m Δs v1", "85", "",
         "P |Fn| m μg Δs v2", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : 2", "P F m Δs v2", "85", "",
         "P |Fn| m μg Δs Δv", "P = (|Fn| μg) ^ 2 Δs : m : Δv", "P F m Δs Δv", "85", "",
         "P |Fn| m μg Δt v1", "P = |Fn| μg (v1 + |Fn| μg Δt : m : 2)", "P F m Δt v1", "85", "",
         "P |Fn| m μg Δt v2", "P = |Fn| μg (v2 - |Fn| μg Δt : m : 2)", "P F m Δt v2", "85", "",
         "P |Fn| m μg v1 W", "P = |Fn| μg (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "85", "",
         "P |Fn| m μg v2 W", "P = |Fn| μg (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "85", "",
         "P |Fn| m μg Δv W", "P = |Fn| μg W : m : Δv", "P F m Δv W", "85", "",
         "P |Fn| μg Δs Δt", "P = |Fn| μg Δs : Δt", "P F Δs Δt", "85", "",
         "P |Fn| μg v1 v2", "P = |Fn| μg (v1 + v2) : 2", "P F v1 v2", "85", "",
         "P |Fn| μg v1 Δv", "P = |Fn| μg (v1 + Δv : 2)", "P F v1 Δv", "85", "",
         "P |Fn| μg v2 Δv", "P = |Fn| μg (v2 - Δv : 2)", "P F v2 Δv", "85", "",
         "P |Fn| μg {v}", "P = |Fn| μg {v}", "P F {v}", "85", "",
         "P |Fn| m μh Δs v1", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : 2", "P F m Δs v1", "88", "",
         "P |Fn| m μh Δs v2", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : 2", "P F m Δs v2", "88", "",
         "P |Fn| m μh Δs Δv", "P = (|Fn| μh) ^ 2 Δs : m : Δv", "P F m Δs Δv", "88", "",
         "P |Fn| m μh Δt v1", "P = |Fn| μh (v1 + |Fn| μh Δt : m : 2)", "P F m Δt v1", "88", "",
         "P |Fn| m μh Δt v2", "P = |Fn| μh (v2 - |Fn| μh Δt : m : 2)", "P F m Δt v2", "88", "",
         "P |Fn| m μh v1 W", "P = |Fn| μh (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "88", "",
         "P |Fn| m μh v2 W", "P = |Fn| μh (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "88", "",
         "P |Fn| m μh Δv W", "P = |Fn| μh W : m : Δv", "P F m Δv W", "88", "",
         "P |Fn| μh Δs Δt", "P = |Fn| μh Δs : Δt", "P F Δs Δt", "88", "",
         "P |Fn| μh v1 v2", "P = |Fn| μh (v1 + v2) : 2", "P F v1 v2", "88", "",
         "P |Fn| μh v1 Δv", "P = |Fn| μh (v1 + Δv : 2)", "P F v1 Δv", "88", "",
         "P |Fn| μh v2 Δv", "P = |Fn| μh (v2 - Δv : 2)", "P F v2 Δv", "88", "",
         "P |Fn| μh {v}", "P = |Fn| μh {v}", "P F {v}", "88", "",
         "P |Fn| m μr Δs v1", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : 2", "P F m Δs v1", "91", "",
         "P |Fn| m μr Δs v2", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : 2", "P F m Δs v2", "91", "",
         "P |Fn| m μr Δs Δv", "P = (|Fn| μr) ^ 2 Δs : m : Δv", "P F m Δs Δv", "91", "",
         "P |Fn| m μr Δt v1", "P = |Fn| μr (v1 + |Fn| μr Δt : m : 2)", "P F m Δt v1", "91", "",
         "P |Fn| m μr Δt v2", "P = |Fn| μr (v2 - |Fn| μr Δt : m : 2)", "P F m Δt v2", "91", "",
         "P |Fn| m μr v1 W", "P = |Fn| μr (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "P F m v1 W", "91", "",
         "P |Fn| m μr v2 W", "P = |Fn| μr (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "P F m v2 W", "91", "",
         "P |Fn| m μr Δv W", "P = |Fn| μr W : m : Δv", "P F m Δv W", "91", "",
         "P |Fn| μr Δs Δt", "P = |Fn| μr Δs : Δt", "P F Δs Δt", "91", "",
         "P |Fn| μr v1 v2", "P = |Fn| μr (v1 + v2) : 2", "P F v1 v2", "91", "",
         "P |Fn| μr v1 Δv", "P = |Fn| μr (v1 + Δv : 2)", "P F v1 Δv", "91", "",
         "P |Fn| μr v2 Δv", "P = |Fn| μr (v2 - Δv : 2)", "P F v2 Δv", "91", "",
         "P |Fn| μr {v}", "P = |Fn| μr {v}", "P F {v}", "91", "",
         "P k m Δs v1", "P = -k Δs (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : 2", "P F k m v1", "57", "",
         "P k m Δs v2", "P = -k Δs (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : 2", "P F k m v2", "57", "",
         "P k m Δs Δv", "P = k ^ 2 Δs ^ 3 : m : Δv", "P F m Δs Δv", "57", "",
         "P k m Δt v1", "P = -(2 v1 : (Δt : m + 2 : k : Δt)) ^ 2 : k : Δt", "P k m v1 W", "44", "",
         "P k m Δt v2", "P = -(2 v2 : (Δt : m - 2 : k : Δt)) ^ 2 : k : Δt", "P k m v2 W", "44", "",
         "P k m Δt Δv", "P = -(m Δv) ^ 2 : k : Δt ^ 3", "P a k m Δt", "23", "",
         "P k m v1 v2", "P = √(-k m (v2 - v1) (v1 + v2) ^ 3 : 8)", "P k m Δv {v}", "19", "",
         "P k m v1 Δv", "P = √(-k m Δv (v1 + Δv : 2) ^ 3)", "P k m Δv {v}", "18", "",
         "P k m v1 {v}", "P = √(-2 k m {v} ^ 3 ({v} - v1))", "P k m Δv {v}", "16", "",
         "P k m v1 W", "P = √(-k W) (v1 ± √ (v1 ^ 2 + 2 W : m)) : 2)", "P F m v1 W", "75", "",
         "P k m v2 Δv", "P = √(-k m Δv (v2 - Δv : 2) ^ 3)", "P k m Δv {v}", "15", "",
         "P k m v2 {v}", "P = √(-2 k m {v} ^ 3 (v2 - {v}))", "P k m Δv {v}", "13", "",
         "P k m v2 W", "P = √(-k W) (v2 ± √ (v2 ^ 2 - 2 W : m)) : 2)", "P F m v2 W", "75", "",
         "P k m Δv {v}", "P = √(-k m Δv {v} ^ 3)", "P k {v} W", "61", "",
         "P k m Δv W", "P = √(-k W) W : m : Δv", "P F k m Δv", "75", "",
         "P k Δs Δt", "P = -k Δs ^ 2 : Δt", "P Δt W", "80", "",
         "P k Δs v1 v2", "P = -k Δs (v1 + v2) : 2", "P k Δs {v}", "10", "",
         "P k Δs v1 Δv", "P = -k Δs (v1 + Δv : 2)", "P k Δs {v}", "18", "",
         "P k Δs v2 Δv", "P = -k Δs (v2 - Δv : 2)", "P k Δs {v}", "15", "",
         "P k Δs {v}", "P = -k Δs {v}", "P k Δs Δt", "22", "",
         "P k Δt v1 v2", "P = -k Δt (v1 + v2) ^ 2 : 4", "P k Δt {v}", "10", "",
         "P k Δt v1 Δv", "P = -k Δt (v1 + Δv : 2) ^ 2", "P k Δt {v}", "18", "",
         "P k Δt v2 Δv", "P = -k Δt (v2 - Δv : 2) ^ 2", "P k Δt {v}", "15", "",
         "P k Δt {v}", "P = -k Δt {v} ^ 2", "P k Δs {v}", "21", "",
         "P k v1 v2 W", "P = √(-k W) (v1 + v2) : 2", "P k {v} W", "10", "",
         "P k v1 Δv W", "P = √(-k W) (v1 + Δv : 2)", "P k {v} W", "18", "",
         "P k v2 Δv W", "P = √(-k W) (v2 - Δv : 2)", "P k {v} W", "15", "",
         "P k {v} W", "P = √(-k W) {v}", "P F {v}", "75", "",
         "P m Δs Δt v1", "P = 2 m Δs (Δs : Δt - v1) : Δt ^ 2", "P m Δt v1 {v}", "20", "",
         "P m Δs Δt v2", "P = 2 m Δs (v2 - Δs : Δt) : Δt ^ 2", "P m Δt v2 {v}", "20", "",
         "P m Δs Δt Δv", "P = m Δs Δv : Δt ^ 2", "P a m Δs Δt", "23", "",
         "P m Δs v1 v2", "P = m (v2 ^ 2 - v1 ^ 2) (v1 + v2) : Δs : 4", "P m Δs Δv {v}", "19", "",
         "P m Δs v1 Δv", "P = m Δv (v1 + Δv : 2) ^ 2 : Δs", "P m Δs Δv {v}", "18", "",
         "P m Δs v1 {v}", "P = 2 m {v} ^ 2 ({v} - v1) : Δs", "P m Δs Δv {v}", "16", "",
         "P m Δs v1 W", "P = W (v1 ± √(v1 ^ 2 + 2 W : m)) : Δs : 2", "P F m v1 W", "30", "",
         "P m Δs v2 Δv", "P = m Δv (v2 - Δv : 2) ^ 2 : Δs", "P m Δs Δv {v}", "15", "",
         "P m Δs v2 {v}", "P = 2 m {v} ^ 2 (v2 - {v}) : Δs", "P m Δs Δv {v}", "13", "",
         "P m Δs v2 W", "P = W (v2 ± √(v2 ^ 2 - 2 W : m)) : Δs : 2", "P F m v2 W", "30", "",
         "P m Δs Δv {v}", "P = m Δv {v} ^ 2 : Δs", "P m Δs Δt Δv", "22", "",
         "P m Δs Δv W", "P = W ^ 2 : m : Δs : Δv", "P F m Δv W", "30", "",
         "P m Δt v1 v2", "P = m (v2 ^ 2 - v1 ^ 2) : Δt : 2", "P m Δt Δv {v}", "19", "",
         "P m Δt v1 Δv", "P = m (v1 + Δv : 2) Δv : Δt", "P m Δt Δv {v}", "18", "",
         "P m Δt v1 {v}", "P = 2 m ({v} - v1) {v} : Δt", "P m Δt Δv {v}", "16", "",
         "P m Δt v2 Δv", "P = m (v2 - Δv : 2) Δv : Δt", "P m Δt Δv {v}", "15", "",
         "P m Δt v2 {v}", "P = 2 m (v2 - {v}) {v} : Δt", "P m Δt Δv {v}", "13", "",
         "P m Δt Δv {v}", "P = m Δv {v} : Δt", "P m Δs Δt Δv", "21", "",
         "P Δs v1 v2 W", "P = (v1 + v2) W : Δs : 2", "P Δs {v} W", "10", "",
         "P Δs v1 Δv W", "P = (v1 + Δv : 2) W : Δs", "P Δs {v} W", "18", "",
         "P Δs v2 Δv W", "P = (v2 - Δv : 2) W : Δs", "P Δs {v} W", "15", "",
         "P Δs {v} W", "P = {v} W : Δs", "P Δt W", "22", "",
         "P Δt W", "P = W : Δt", "", "42", ""];
          CAI = AA[0];
        } // P
        if (AA[0] == FAB[132])
        {
          FAC = [
         "p m Δs Δt", "p = m Δs : Δt", "", "51", "",
         "p m v", "p = m v", "", "54", "",
         "p px", "p = px", "", "0", "",
         "p py", "p = py", "", "0", "",
         "p pz", "p = pz", "", "0", "",
         "p px θ", "p = px : cos(θ)", "", "0", "",
         "p py θ", "p = py : sin(θ)", "", "0", "",
         "p pz θ", "p = pz : cos(θ)", "", "0", "",
         "p px θ ϕ", "p = px : cos(θ) : sin(ϕ)", "", "0", "",
         "p pz θ ϕ", "p = pz : cos(θ) : cos(ϕ)", "", "0", "",
         "p px py", "p = √(px ^ 2 + py ^ 2)", "", "0", "",
         "p px pz", "p = √(px ^ 2 + pz ^ 2)", "", "0", "",
         "p py pz", "p = √(py ^ 2 + pz ^ 2)", "", "0", "",
         "p px py pz", "p = √(px ^ 2 + py ^ 2 + pz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // p
        if (AA[0] == FAB[135])
        {
          FAC = [
         "px p", "px = p", "", "0", "",
         "px p θ", "px = p cos(θ)", "", "0", "",
         "px py θ", "px = py : tan(θ)", "", "0", "",
         "px pz ϕ", "px = pz tan(ϕ)", "", "0", "",
         "px p py", "px = √(p ^ 2 - py ^ 2)", "", "0", "",
         "px p pz", "px = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "px p θ ϕ", "px = p cos(θ) sin(ϕ)", "", "0", "",
         "px py θ ϕ", "px = py sin(ϕ) : tan(θ)", "", "0", "",
         "px p py pz", "px = √(p ^ 2 - py ^ 2 - pz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // px
        if (AA[0] == FAB[138])
        {
          FAC = [
         "py p", "py = p", "", "0", "",
         "py p θ", "py = p sin(θ)", "", "0", "",
         "py px θ", "py = px tan(θ)", "", "0", "",
         "py pz θ", "py = pz tan(θ)", "", "0", "",
         "py p px", "py = √(p ^ 2 - px ^ 2)", "", "0", "",
         "py p pz", "py = √(p ^ 2 - pz ^ 2)", "", "0", "",
         "py px θ ϕ", "py = px tan(θ) : sin(ϕ)", "", "0", "",
         "py pz θ ϕ", "py = pz tan(θ) : cos(ϕ)", "", "0", "",
         "py p px pz", "py = √(p ^ 2 - px ^ 2 - pz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // py
        if (AA[0] == FAB[141])
        {
          FAC = [
         "pz p", "pz = p", "", "0", "",
         "pz p θ", "pz = p cos(θ)", "", "0", "",
         "pz px ϕ", "pz = px : tan(ϕ)", "", "0", "",
         "pz py θ", "pz = py : tan(θ)", "", "0", "",
         "pz p px", "pz = √(p ^ 2 - px ^ 2)", "", "0", "",
         "pz p py", "pz = √(p ^ 2 - py ^ 2)", "", "0", "",
         "pz py θ ϕ", "pz = py cos(ϕ) : tan(θ)", "", "0", "",
         "pz p θ ϕ", "pz = p cos(θ) cos(ϕ)", "", "0", "",
         "pz p px py", "pz = √(p ^ 2 - px ^ 2 - py ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // pz
        if (AA[0] == FAB[144])
        {
          FAC = [
            "s1 s2 Δs", "s1 = s2 - Δs", "", "2", "1"];
          CAI = AA[0];
        } // s1
        if (AA[0] == FAB[147])
        {
          FAC = [
         "sx1 s1", "sx1 = s1", "", "0", "",
         "sx1 s1 θ", "sx1 = s1 cos(θ)", "", "0", "",
         "sx1 sy1 θ", "sx1 = sy1 : tan(θ)", "", "0", "",
         "sx1 sz1 ϕ", "sx1 = sz1 tan(ϕ)", "", "0", "",
         "sx1 s1 sy1", "sx1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sx1 s1 sz1", "sx1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sx1 s1 θ ϕ", "sx1 = s1 cos(θ) sin(ϕ)", "", "0", "",
         "sx1 sy1 θ ϕ", "sx1 = sy1 sin(ϕ) : tan(θ)", "", "0", "",
         "sx1 s1 sy1 sz1", "sx1 = √(s1 ^ 2 - sy1 ^ 2 - sz1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sx1
        if (AA[0] == FAB[150])
        {
          FAC = [
         "sy1 s1", "sy1 = s1", "", "0", "",
         "sy1 s1 θ", "sy1 = s1 sin(θ)", "", "0", "",
         "sy1 sx1 θ", "sy1 = sx1 tan(θ)", "", "0", "",
         "sy1 sz1 θ", "sy1 = sz1 tan(θ)", "", "0", "",
         "sy1 s1 sx1", "sy1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sy1 s1 sz1", "sy1 = √(s1 ^ 2 - sz1 ^ 2)", "", "0", "",
         "sy1 sx1 θ ϕ", "sy1 = sx1 tan(θ) : sin(ϕ)", "", "0", "",
         "sy1 sz1 θ ϕ", "sy1 = sz1 tan(θ) : cos(ϕ)", "", "0", "",
         "sy1 s1 sx1 sz1", "sy1 = √(s1 ^ 2 - sx1 ^ 2 - sz1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sy1
        if (AA[0] == FAB[153])
        {
          FAC = [
         "sz1 s1", "sz1 = s1", "", "0", "",
         "sz1 s1 θ", "sz1 = s1 cos(θ)", "", "0", "",
         "sz1 sx1 ϕ", "sz1 = sx1 : tan(ϕ)", "", "0", "",
         "sz1 sy1 θ", "sz1 = sy1 : tan(θ)", "", "0", "",
         "sz1 s1 sx1", "sz1 = √(s1 ^ 2 - sx1 ^ 2)", "", "0", "",
         "sz1 s1 sy1", "sz1 = √(s1 ^ 2 - sy1 ^ 2)", "", "0", "",
         "sz1 sy1 θ ϕ", "sz1 = sy1 cos(ϕ) : tan(θ)", "", "0", "",
         "sz1 s1 θ ϕ", "sz1 = s1 cos(θ) cos(ϕ)", "", "0", "",
         "sz1 s1 sx1 sy1", "sz1 = √(s1 ^ 2 - sx1 ^ 2 - sy1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sz1
        if (AA[0] == FAB[156])
        {
          FAC = [
            "s2 s1 Δs", "s2 = s1 + Δs", "", "3", "1"];
          CAI = AA[0];
        } // s2
        if (AA[0] == FAB[159])
        {
          FAC = [
         "sx2 s2", "sx2 = s2", "", "0", "",
         "sx2 s2 θ", "sx2 = s2 cos(θ)", "", "0", "",
         "sx2 sy2 θ", "sx2 = sy2 : tan(θ)", "", "0", "",
         "sx2 sz2 ϕ", "sx2 = sz2 tan(ϕ)", "", "0", "",
         "sx2 s2 sy2", "sx2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sx2 s2 sz2", "sx2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sx2 s2 θ ϕ", "sx2 = s2 cos(θ) sin(ϕ)", "", "0", "",
         "sx2 sy2 θ ϕ", "sx2 = sy2 sin(ϕ) : tan(θ)", "", "0", "",
         "sx2 s2 sy2 sz2", "sx2 = √(s2 ^ 2 - sy2 ^ 2 - sz2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sx2
        if (AA[0] == FAB[162])
        {
          FAC = [
         "sy2 s2", "sy2 = s2", "", "0", "",
         "sy2 s2 θ", "sy2 = s2 sin(θ)", "", "0", "",
         "sy2 sx2 θ", "sy2 = sx2 tan(θ)", "", "0", "",
         "sy2 sz2 θ", "sy2 = sz2 tan(θ)", "", "0", "",
         "sy2 s2 sx2", "sy2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sy2 s2 sz2", "sy2 = √(s2 ^ 2 - sz2 ^ 2)", "", "0", "",
         "sy2 sx2 θ ϕ", "sy2 = sx2 tan(θ) : sin(ϕ)", "", "0", "",
         "sy2 sz2 θ ϕ", "sy2 = sz2 tan(θ) : cos(ϕ)", "", "0", "",
         "sy2 s2 sx2 sz2", "sy2 = √(s2 ^ 2 - sx2 ^ 2 - sz2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sy2
        if (AA[0] == FAB[165])
        {
          FAC = [
         "sz2 s2", "sz2 = s2", "", "0", "",
         "sz2 s2 θ", "sz2 = s2 cos(θ)", "", "0", "",
         "sz2 sx2 ϕ", "sz2 = sx2 : tan(ϕ)", "", "0", "",
         "sz2 sy2 θ", "sz2 = sy2 : tan(θ)", "", "0", "",
         "sz2 s2 sx2", "sz2 = √(s2 ^ 2 - sx2 ^ 2)", "", "0", "",
         "sz2 s2 sy2", "sz2 = √(s2 ^ 2 - sy2 ^ 2)", "", "0", "",
         "sz2 sy2 θ ϕ", "sz2 = sy2 cos(ϕ) : tan(θ)", "", "0", "",
         "sz2 s2 θ ϕ", "sz2 = s2 cos(θ) cos(ϕ)", "", "0", "",
         "sz2 s2 sx2 sy2", "sz2 = √(s2 ^ 2 - sx2 ^ 2 - sy2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // sz2
        if (AA[0] == FAB[168])
        {
          FAC = [
         "Δs a F P v1", "Δs = 2 P (P : F - v1) : a : F", "Δs a P v1 W", "29", "",
         "Δs a F P v2", "Δs = 2 P (v2 - P : F) : a : F", "Δs a P v2 W", "29", "",
         "Δs a F P Δv", "Δs = P Δv : a : F", "Δs F P Δt", "25", "",
         "Δs a |Fn| μg P v1", "Δs = 2 P (P : |Fn| : μg - v1) : a : |Fn| : μg", "Δs a F P v1", "85", "",
         "Δs a |Fn| μg P v2", "Δs = 2 P (v2 - P : |Fn| : μg) : a : |Fn| : μg", "Δs a F P v2", "85", "",
         "Δs a |Fn| μg P Δv", "Δs = P Δv : a : |Fn| : μg", "Δs a F P Δv", "85", "",
         "Δs a |Fn| μh P v1", "Δs = 2 P (P : |Fn| : μh - v1) : a : |Fn| : μh", "Δs a F P v1", "88", "",
         "Δs a |Fn| μh P v2", "Δs = 2 P (v2 - P : |Fn| : μh) : a : |Fn| : μh", "Δs a F P v2", "88", "",
         "Δs a |Fn| μh P Δv", "Δs = P Δv : a : |Fn| : μh", "Δs a F P Δv", "88", "",
         "Δs a |Fn| μr P v1", "Δs = 2 P (P : |Fn| : μr - v1) : a : |Fn| : μr", "Δs a F P v1", "91", "",
         "Δs a |Fn| μr P v2", "Δs = 2 P (v2 - P : |Fn| : μr) : a : |Fn| : μr", "Δs a F P v2", "91", "",
         "Δs a |Fn| μr P Δv", "Δs = P Δv : a : |Fn| : μr", "Δs a F P Δv", "91", "",
         "Δs a k m", "Δs = -a m : k", "Δs F k", "2", "",
         "Δs a k P Δv", "Δs = √(-P Δv : a : k)", "Δs k P Δt", "2", "",
         "Δs a m P Δt", "Δs = P Δt : a : m", "Δs a m W", "44", "",
         "Δs a m P v1", "Δs = 2 P (P : a : m - v1) : (a ^ 2 m)", "Δs a F P v1", "26", "",
         "Δs a m P v2", "Δs = 2 P (v2 - P : a : m) : a ^ 2 : m", "Δs a F P v2", "26", "",
         "Δs a m P Δv", "Δs = P Δv : a ^ 2 : m", "Δs a F P Δv", "26", "",
         "Δs a m W", "Δs = W : a : m", "Δs F W", "26", "",
         "Δs a P v1 W", "Δs = a W ^ 2 : P ^ 2 : 2 + v1 W : P", "Δs a Δt v1", "43", "",
         "Δs a P v2 W", "Δs = v2 W : P - a W ^ 2 : P ^ 2 : 2", "Δs a Δt v2", "43", "",
         "Δs a Δt v1", "Δs = Δt (v1 + a Δt : 2)", "Δs Δt v1 Δv", "24", "",
         "Δs a Δt v2", "Δs = Δt (v2 - a Δt : 2)", "Δs Δt v2 Δv", "24", "",
         "Δs a v1 v2", "Δs = (v2 ^ 2 - v1 ^ 2) : a : 2", "Δs a Δv {v}", "19", "",
         "Δs a v1 Δv", "Δs = Δv (v1 + Δv : 2) : a", "Δs a Δv {v}", "18", "",
         "Δs a v1 {v}", "Δs = 2 {v} ({v} - v1) : a", "Δs a Δv {v}", "16", "",
         "Δs a v2 Δv", "Δs = Δv (v2 - Δv : 2) : a", "Δs a Δv {v}", "15", "",
         "Δs a v2 {v}", "Δs = 2 {v} (v2 - {v}) : a", "Δs a Δv {v}", "13", "",
         "Δs a Δv {v}", "Δs = Δv {v} : a", "Δs Δt {v}", "25", "",
         "Δs F |Fn| Ft k μg", "Δs = (Ft + μg |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| Ft k μh", "Δs = (Ft + μh |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| Ft k μr", "Δs = (Ft + μr |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μg", "Δs = (μg |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μh", "Δs = (μh |Fn| - F) : k", "", "0", "",
         "Δs F |Fn| k μr", "Δs = (μr |Fn| - F) : k", "", "0", "",
         "Δs F Frg Ft k", "Δs = (Ft + Frg - F) : k", "", "0", "",
         "Δs F Frg k", "Δs = (Frg - F) : k", "", "0", "",
         "Δs F Frh Ft k", "Δs = (Ft + Frh - F) : k", "", "0", "",
         "Δs F Frh k", "Δs = (Frh - F) : k", "", "0", "",
         "Δs F Frr Ft k", "Δs = (Ft + Frr - F) : k", "", "0", "",
         "Δs F Frr k", "Δs = (Frr - F) : k", "", "0", "",
         "Δs F Ft k", "Δs = (Ft - F) : k", "", "0", "",
         "Δs F k", "Δs = -F : k", "", "0", "",
         "Δs F m P v1", "Δs = 2 m P (P - F v1) : F ^ 3", "Δs a F P v1", "27", "",
         "Δs F m P v2", "Δs = 2 m P (F v2 - P) : F ^ 3", "Δs a F P v2", "27", "",
         "Δs F m P Δv", "Δs = P m Δv : F ^ 2", "Δs a F P Δv", "27", "",
         "Δs F m Δt v1", "Δs = Δt (v1 + F Δt) : m : 2", "Δs a Δt v1", "27", "",
         "Δs F m Δt v2", "Δs = Δt (v2 - F Δt) : m : 2", "Δs a Δt v2", "27", "",
         "Δs F m v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : F : 2", "Δs F m Δv {v}", "19", "",
         "Δs F m v1 Δv", "Δs = m Δv (v1 + Δv : 2) : F", "Δs F m Δv {v}", "18", "",
         "Δs F m v1 {v}", "Δs = 2 m {v} ({v} - v1) : F", "Δs F m Δv {v}", "16", "",
         "Δs F m v2 Δv", "Δs = m Δv (v2 - Δv : 2) : F", "Δs F m Δv {v}", "15", "",
         "Δs F m v2 {v}", "Δs = 2 m {v} (v2 - {v}) : F", "Δs F m Δv {v}", "13", "",
         "Δs F m Δv {v}", "Δs = m Δv {v} : F", "Δs a Δv {v}", "27", "",
         "Δs F P Δt", "Δs = P Δt : F", "Δs F W", "44", "",
         "Δs F W", "Δs = W : F", "", "29", "",
         "Δs Ff k", "Δs = -Ff : k", "", "0", "",
         "Δs |Fn| m μg P v1", "Δs = 2 m P (P - |Fn| : μg v1) : (|Fn| μg) ^ 3", "Δs F m P v1", "85", "",
         "Δs |Fn| m μg P v2", "Δs = 2 m P (|Fn| μg v2 - P) : (|Fn| μg) ^ 3", "Δs F m P v2", "85", "",
         "Δs |Fn| m μg P Δv", "Δs = P m Δv : (|Fn| μg) ^ 2", "Δs F m P Δv", "85", "",
         "Δs |Fn| m μg Δt v1", "Δs = Δt (v1 + |Fn| μg Δt : m : 2)", "Δs F m Δt v1", "85", "",
         "Δs |Fn| m μg Δt v2", "Δs = Δt (v2 - |Fn| μg Δt : m : 2)", "Δs F m Δt v2", "85", "",
         "Δs |Fn| m μg v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μg : 2", "Δs F m v1 v2", "85", "",
         "Δs |Fn| m μg v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μg", "Δs F m v1 Δv", "85", "",
         "Δs |Fn| m μg v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μg", "Δs F m v1 {v}", "85", "",
         "Δs |Fn| m μg v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μg", "Δs F m v2 Δv", "85", "",
         "Δs |Fn| m μg v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μg", "Δs F m v2 {v}", "85", "",
         "Δs |Fn| m μg Δv {v}", "Δs = m Δv {v} : |Fn| : μg", "Δs F m Δv {v}", "85", "",
         "Δs |Fn| μg P Δt", "Δs = P Δt : |Fn| : μg", "Δs F P Δt", "85", "",
         "Δs |Fn| μg W", "Δs = W : |Fn| : μg", "Δs F W", "85", "",
         "Δs |Fn| m μh P v1", "Δs = 2 m P (P - |Fn| : μh v1) : (|Fn| μh) ^ 3", "Δs F m P v1", "88", "",
         "Δs |Fn| m μh P v2", "Δs = 2 m P (|Fn| μh v2 - P) : (|Fn| μh) ^ 3", "Δs F m P v2", "88", "",
         "Δs |Fn| m μh P Δv", "Δs = P m Δv : (|Fn| μh) ^ 2", "Δs F m P Δv", "88", "",
         "Δs |Fn| m μh Δt v1", "Δs = Δt (v1 + |Fn| μh Δt : m : 2)", "Δs F m Δt v1", "88", "",
         "Δs |Fn| m μh Δt v2", "Δs = Δt (v2 - |Fn| μh Δt : m : 2)", "Δs F m Δt v2", "88", "",
         "Δs |Fn| m μh v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μh : 2", "Δs F m v1 v2", "88", "",
         "Δs |Fn| m μh v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μh", "Δs F m v1 Δv", "88", "",
         "Δs |Fn| m μh v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μh", "Δs F m v1 {v}", "88", "",
         "Δs |Fn| m μh v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μh", "Δs F m v2 Δv", "88", "",
         "Δs |Fn| m μh v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μh", "Δs F m v2 {v}", "88", "",
         "Δs |Fn| m μh Δv {v}", "Δs = m Δv {v} : |Fn| : μh", "Δs F m Δv {v}", "88", "",
         "Δs |Fn| μh P Δt", "Δs = P Δt : |Fn| : μh", "Δs F P Δt", "88", "",
         "Δs |Fn| μh W", "Δs = W : |Fn| : μh", "Δs F W", "88", "",
         "Δs |Fn| m μr P v1", "Δs = 2 m P (P - |Fn| : μr v1) : (|Fn| μr) ^ 3", "Δs F m P v1", "91", "",
         "Δs |Fn| m μr P v2", "Δs = 2 m P (|Fn| μr v2 - P) : (|Fn| μr) ^ 3", "Δs F m P v2", "91", "",
         "Δs |Fn| m μr P Δv", "Δs = P m Δv : (|Fn| μr) ^ 2", "Δs F m P Δv", "91", "",
         "Δs |Fn| m μr Δt v1", "Δs = Δt (v1 + |Fn| μr Δt : m : 2)", "Δs F m Δt v1", "91", "",
         "Δs |Fn| m μr Δt v2", "Δs = Δt (v2 - |Fn| μr Δt : m : 2)", "Δs F m Δt v2", "91", "",
         "Δs |Fn| m μr v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) : |Fn| : μr : 2", "Δs F m v1 v2", "91", "",
         "Δs |Fn| m μr v1 Δv", "Δs = m (v1 + Δv : 2) Δv : |Fn| : μr", "Δs F m v1 Δv", "91", "",
         "Δs |Fn| m μr v1 {v}", "Δs = 2 m {v} ({v} - v1) : |Fn| : μr", "Δs F m v1 {v}", "91", "",
         "Δs |Fn| m μr v2 Δv", "Δs = m (v2 - Δv : 2) Δv : |Fn| : μr", "Δs F m v2 Δv", "91", "",
         "Δs |Fn| m μr v2 {v}", "Δs = 2 m {v} (v2 - {v}) : |Fn| : μr", "Δs F m v2 {v}", "91", "",
         "Δs |Fn| m μr Δv {v}", "Δs = m Δv {v} : |Fn| : μr", "Δs F m Δv {v}", "91", "",
         "Δs |Fn| μr P Δt", "Δs = P Δt : |Fn| : μr", "Δs F P Δt", "91", "",
         "Δs |Fn| μr W", "Δs = W : |Fn| : μr", "Δs F W", "91", "",
         "Δs k m P v1", "Δs = √(-2 m P (P + k Δs v1) : k ^ 3 ' 4)", "Δs F m P v1", "2", "",
         "Δs k m P v2", "Δs = √(2 m P (P + k Δs v2) : k ^ 3 ' 4)", "Δs F m P v2", "2", "",
         "Δs k m P Δv", "Δs = √(-P m Δv : k ^ 2 ' 3)", "Δs F m P Δv", "2", "",
         "Δs k m Δt v1", "Δs = v1 : (1 : Δt + k Δt : m : 2)", "Δs k m v1 {v}", "2", "",
         "Δs k m Δt v2", "Δs = v2 : (1 : Δt - k Δt : m : 2)", "Δs k m v2 {v}", "2", "",
         "Δs k m Δt Δv", "Δs = -m Δv : k : Δt", "Δs a k m", "2", "",
         "Δs k m v1 v2", "Δs = √(-m (v2 ^ 2 - v1 ^ 2) : k : 2)", "Δs k m Δv {v}", "2", "",
         "Δs k m v1 Δv", "Δs = √(-m Δv (v1 + Δv : 2) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v1 {v}", "Δs = √(-2 m {v} ({v} - v1) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v2 Δv", "Δs = √(-m Δv (v2 - Δv : 2) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m v2 {v}", "Δs = √(-2 m {v} (v2 - {v}) : k)", "Δs k m Δv {v}", "2", "",
         "Δs k m Δv {v}", "Δs = √(-m Δv {v} : k)", "Δs k W", "2", "",
         "Δs k P Δt", "Δs = √(-P Δt : k)", "Δs k W", "2", "",
         "Δs k P v1 v2", "Δs = -2 P : k : (v1 + v2)", "Δs k P {v}", "2", "",
         "Δs k P v1 Δv", "Δs = -P : k : (v1 + Δv : 2)", "Δs k P {v}", "2", "",
         "Δs k P v2 Δv", "Δs = -P : k : (v2 - Δv : 2)", "Δs k P {v}", "2", "",
         "Δs k P {v}", "Δs = -P : k : {v}", "Δs F k", "2", "",
         "Δs k W", "Δs = √(-W : k)", "Δs F k", "2", "",
         "Δs m P Δt v1", "Δs = Δt (v1 ± √(v1 ^ 2 + 2 P Δt : m)) : 2", "Δs m Δt v1 W", "44", "",
         "Δs m P Δt v2", "Δs = Δt (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : 2", "Δs m Δt v2 W", "44", "",
         "Δs m P Δt Δv", "Δs = P Δt ^ 2 : (m Δv)", "Δs m Δt Δv W", "44", "",
         "Δs m P v1 v2", "Δs = m (v2 ^ 2 - v1 ^ 2) (v1 + v2) : P : 4", "Δs m P Δv {v}", "19", "",
         "Δs m P v1 Δv", "Δs = m Δv (v1 + Δv : 2) ^ 2 : P", "Δs m P Δv {v}", "18", "",
         "Δs m P v1 {v}", "Δs = 2 m {v} ^ 2 ({v} - v1) : P", "Δs m P Δv {v}", "16", "",
         "Δs m P v1 W", "Δs = W (v1 ± √(v1 ^ 2 + 2 W : m)) : P : 2", "Δs m Δt v1 W", "43", "",
         "Δs m P v2 Δv", "Δs = m Δv (v2 - Δv : 2) ^ 2 : P", "Δs m P Δv {v}", "15", "",
         "Δs m P v2 {v}", "Δs = 2 m {v} ^ 2 (v2 - {v}) : P", "Δs m P Δv {v}", "13", "",
         "Δs m P v2 W", "Δs = W (v2 ± √(v2 ^ 2 - 2 W : m)) : P : 2", "Δs m Δt v2 W", "43", "",
         "Δs m P Δv {v}", "Δs = m Δv {v} ^ 2 : P", "Δs m P Δt Δv", "22", "",
         "Δs m P Δv W", "Δs = W ^ 2 : m : P : Δv", "Δs m Δt Δv W", "43", "",
         "Δs m p Δt", "Δs = p Δt : m", "Δs Δt v", "56", "",
         "Δs m Δt v1 W", "Δs = Δt (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "Δs F m Δt v1", "30", "",
         "Δs m Δt v2 W", "Δs = Δt (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "Δs F m Δt v2", "30", "",
         "Δs m Δt Δv W", "Δs = W Δt : m : Δv", "Δs a m W", "23", "",
         "Δs P v1 v2 W", "Δs = (v1 + v2) W : P : 2", "Δs P {v} W", "10", "",
         "Δs P v1 Δv W", "Δs = (v1 + Δv : 2) W : P", "Δs P {v} W", "18", "",
         "Δs P v2 Δv W", "Δs = (v2 - Δv : 2) W : P", "Δs P {v} W", "15", "",
         "Δs P {v} W", "Δs = {v} W : P", "Δs Δt {v}", "43", "",
         "Δs s1 s2", "Δs = s2 - s1", "", "1", "1",
         "Δs Δsx", "Δs = Δsx", "", "0", "",
         "Δs Δsy", "Δs = Δsy", "", "0", "",
         "Δs Δsz", "Δs = Δsz", "", "0", "",
         "Δs Δsx θ", "Δs = Δsx : cos(θ)", "", "0", "",
         "Δs Δsy θ", "Δs = Δsy : sin(θ)", "", "0", "",
         "Δs Δsz θ", "Δs = Δsz : cos(θ)", "", "0", "",
         "Δs Δsx θ ϕ", "Δs = Δsx : cos(θ) : sin(ϕ)", "", "0", "",
         "Δs Δsz θ ϕ", "Δs = Δsz : cos(θ) : cos(ϕ)", "", "0", "",
         "Δs Δsx Δsy", "Δs = √(Δsx ^ 2 + Δsy ^ 2)", "", "0", "",
         "Δs Δsx Δsz", "Δs = √(Δsx ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δsy Δsz", "Δs = √(Δsy ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δsx Δsy Δsz", "Δs = √(Δsx ^ 2 + Δsy ^ 2 + Δsz ^ 2)", "", "0", "",
         "Δs Δt v", "Δs = v Δt", "", "51", "",
         "Δs Δt v1 v2", "Δs = Δt (v1 + v2) : 2", "Δs Δt {v}", "10", "",
         "Δs Δt v1 Δv", "Δs = Δt (v1 + Δv : 2)", "Δs Δt {v}", "18", "",
         "Δs Δt v2 Δv", "Δs = Δt (v2 - Δv : 2)", "Δs Δt {v}", "15", "",
         "Δs Δt {v}", "Δs = Δt {v}", "", "20", ""];
          CAI = AA[0];
        } // Δs
        if (AA[0] == FAB[171])
        {
          FAC = [
         "Δsx Δs", "Δsx = Δs", "", "0", "",
         "Δsx Δs θ", "Δsx = Δs cos(θ)", "", "0", "",
         "Δsx Δsy θ", "Δsx = Δsy : tan(θ)", "", "0", "",
         "Δsx Δsz ϕ", "Δsx = Δsz tan(ϕ)", "", "0", "",
         "Δsx Δs Δsy", "Δsx = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsx Δs Δsz", "Δsx = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsx Δs θ ϕ", "Δsx = Δs cos(θ) sin(ϕ)", "", "0", "",
         "Δsx Δsy θ ϕ", "Δsx = Δsy sin(ϕ) : tan(θ)", "", "0", "",
         "Δsx Δs Δsy Δsz", "Δsx = √(Δs ^ 2 - Δsy ^ 2 - Δsz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δsx
        if (AA[0] == FAB[174])
        {
          FAC = [
         "Δsy Δs", "Δsy = Δs", "", "0", "",
         "Δsy Δs θ", "Δsy = Δs sin(θ)", "", "0", "",
         "Δsy Δsx θ", "Δsy = Δsx tan(θ)", "", "0", "",
         "Δsy Δsz θ", "Δsy = Δsz tan(θ)", "", "0", "",
         "Δsy Δs Δsx", "Δsy = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsy Δs Δsz", "Δsy = √(Δs ^ 2 - Δsz ^ 2)", "", "0", "",
         "Δsy Δsx θ ϕ", "Δsy = Δsx tan(θ) : sin(ϕ)", "", "0", "",
         "Δsy Δsz θ ϕ", "Δsy = Δsz tan(θ) : cos(ϕ)", "", "0", "",
         "Δsy Δs Δsx Δsz", "Δsy = √(Δs ^ 2 - Δsx ^ 2 - Δsz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δsy
        if (AA[0] == FAB[177])
        {
          FAC = [
         "Δsz Δs", "Δsz = Δs", "", "0", "",
         "Δsz Δs θ", "Δsz = Δs cos(θ)", "", "0", "",
         "Δsz Δsx ϕ", "Δsz = Δsx : tan(ϕ)", "", "0", "",
         "Δsz Δsy θ", "Δsz = Δsy : tan(θ)", "", "0", "",
         "Δsz Δs Δsx", "Δsz = √(Δs ^ 2 - Δsx ^ 2)", "", "0", "",
         "Δsz Δs Δsy", "Δsz = √(Δs ^ 2 - Δsy ^ 2)", "", "0", "",
         "Δsz Δsy θ ϕ", "Δsz = Δsy cos(ϕ) : tan(θ)", "", "0", "",
         "Δsz Δs θ ϕ", "Δsz = Δs cos(θ) cos(ϕ)", "", "0", "",
         "Δsz Δs Δsx Δsy", "Δsz = √(Δs ^ 2 - Δsx ^ 2 - Δsy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δsz
        if (AA[0] == FAB[180])
        {
          FAC = [
            "t1 t2 Δt", "t1 = t2 - Δt", "", "5", "2"];
          CAI = AA[0];
        } // t1
        if (AA[0] == FAB[183])
        {
          FAC = [
            "t2 t1 Δt", "t2 = t1 + Δt", "", "6", "2"];
          CAI = AA[0];
        } // t2
        if (AA[0] == FAB[186])
        {
          FAC = [
         "Δt a F k v1", "Δt = (-v1 ± √(v1 ^ 2 - 2 a F : k)) : a", "Δt a Δs v1", "59", "",
         "Δt a F k v2", "Δt = (v2 ± √(v2 ^ 2 + 2 a F : k)) : a", "Δt a Δs v2", "59", "",
         "Δt a F P v1", "Δt = 2 (P : F - v1) : a", "Δt a F v1 W", "44", "",
         "Δt a F P v2", "Δt = 2 (v2 - P : F) : a", "Δt a F v2 W", "44", "",
         "Δt a F v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : F)) : a", "Δt a Δs v1", "31", "",
         "Δt a F v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : F)) : a", "Δt a Δs v2", "31", "",
         "Δt a |Fn| μg P v1", "Δt = 2 (P : |Fn| : μg - v1) : a", "Δt a F P v1", "85", "",
         "Δt a |Fn| μg P v2", "Δt = 2 (v2 - P : |Fn| : μg) : a", "Δt a F P v2", "85", "",
         "Δt a |Fn| μg v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : a", "Δt a F v1 W", "85", "",
         "Δt a |Fn| μg v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : a", "Δt a F v2 W", "85", "",
         "Δt a |Fn| μh P v1", "Δt = 2 (P : |Fn| : μh - v1) : a", "Δt a F P v1", "88", "",
         "Δt a |Fn| μh P v2", "Δt = 2 (v2 - P : |Fn| : μh) : a", "Δt a F P v2", "88", "",
         "Δt a |Fn| μh v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : a", "Δt a F v1 W", "88", "",
         "Δt a |Fn| μh v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : a", "Δt a F v2 W", "88", "",
         "Δt a |Fn| μr P v1", "Δt = 2 (P : |Fn| : μr - v1) : a", "Δt a F P v1", "91", "",
         "Δt a |Fn| μr P v2", "Δt = 2 (v2 - P : |Fn| : μr) : a", "Δt a F P v2", "91", "",
         "Δt a |Fn| μr v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : a", "Δt a F v1 W", "91", "",
         "Δt a |Fn| μr v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : a", "Δt a F v2 W", "91", "",
         "Δt a k m P", "Δt = -(a m) ^ 2 : k : P", "Δt F k P", "26", "",
         "Δt a k m v1", "Δt = (-v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : a", "Δt a F k v1", "26", "",
         "Δt a k m v2", "Δt = (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : a", "Δt a F k v2", "26", "",
         "Δt a k m {v}", "Δt = -a m : k : {v}", "Δt F k {v}", "26", "",
         "Δt a k v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 a √(-W : k))) : a", "Δt a Δs v1", "78", "",
         "Δt a k v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 a √(-W : k))) : a", "Δt a Δs v2", "78", "",
         "Δt a m P Δs", "Δt = a m Δs : P", "Δt F P Δs", "26", "",
         "Δt a m P v1", "Δt = 2 (P : a : m - v1) : a", "Δt a F P v1", "26", "",
         "Δt a m P v2", "Δt = 2 (v2 - P : a : m) : a", "Δt a F P v2", "26", "",
         "Δt a m v1 W", "Δt = (-v1 ± √(v1 ^ 2 + 2 W : m)) : a", "Δt a F v1 W", "26", "",
         "Δt a m v2 W", "Δt = (v2 ± √(v2 ^ 2 - 2 W : m)) : a", "Δt a F v2 W", "26", "",
         "Δt a m {v} W", "Δt = W : a : m : {v}", "Δt F {v} W", "26", "",
         "Δt a Δs v1", "Δt = (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a", "Δt a v1 {v}", "20", "",
         "Δt a Δs v2", "Δt = (v2 ± √(v2 ^ 2 - 2 a Δs)) : a", "Δt a v2 {v}", "20", "",
         "Δt a v1 {v}", "Δt = 2 ({v} - v1) : a", "Δt a Δv", "16", "",
         "Δt a v2 {v}", "Δt = 2 (v2 - {v}) : a", "Δt a Δv", "13", "",
         "Δt a Δv", "Δt = Δv : a", "", "23", "",
         "Δt F k m v1", "Δt = m (-v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : F", "Δt a F k v1", "27", "",
         "Δt F k m v2", "Δt = m (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : F", "Δt a F k v2", "27", "",
         "Δt F k P", "Δt = -(F ^ 2) : k : P", "Δt F k {v}", "62", "",
         "Δt F k v1 v2", "Δt = -2 F : k : (v1 + v2)", "Δt F k {v}", "10", "",
         "Δt F k v1 Δv", "Δt = -F : k : (v1 + Δv : 2)", "Δt F k {v}", "18", "",
         "Δt F k v2 Δv", "Δt = -F : k : (v2 - Δv : 2)", "Δt F k {v}", "15", "",
         "Δt F k {v}", "Δt = -F : k : {v}", "Δt Δs {v}", "59", "",
         "Δt F m P v1", "Δt = 2 m (P : F - v1) : F", "Δt a F P v1", "27", "",
         "Δt F m P v2", "Δt = 2 m (v2 - P : F) : F", "Δt F m P v2", "27", "",
         "Δt F m Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 F Δs : m)) : F", "Δt a Δs v1", "27", "",
         "Δt F m Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : F", "Δt a Δs v2", "27", "",
         "Δt F m v1 {v}", "Δt = 2 m ({v} - v1) : F", "Δt F m Δv", "16", "",
         "Δt F m v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : F", "Δt F m Δs v1", "31", "",
         "Δt F m v2 {v}", "Δt = 2 m (v2 - {v}) : F", "Δt F m Δv", "13", "",
         "Δt F m v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : F", "Δt F m Δs v2", "31", "",
         "Δt F m Δv", "Δt = m Δv : F", "Δt a Δv", "27", "",
         "Δt F P Δs", "Δt = F Δs : P", "Δt P W", "29", "",
         "Δt F v1 v2 W", "Δt = 2 W : F : (v1 + v2)", "Δt F {v} W", "10", "",
         "Δt F v1 Δv W", "Δt = W : F : (v1 + Δv : 2)", "Δt F {v} W", "18", "",
         "Δt F v2 Δv W", "Δt = W : F : (v2 - Δv : 2)", "Δt F {v} W", "15", "",
         "Δt F {v} W", "Δt = W : F : {v}", "Δt Δs {v}", "31", "",
         "Δt |Fn| m μg P v1", "Δt = 2 m (P : |Fn| : μg - v1) : |Fn| : μg", "Δt F m P v1", "85", "",
         "Δt |Fn| m μg P v2", "Δt = 2 m (v2 - P : |Fn| : μg) : |Fn| : μg", "Δt F m P v2", "85", "",
         "Δt |Fn| m μg Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : |Fn| : μg", "Δt F m Δs v1", "85", "",
         "Δt |Fn| m μg Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : |Fn| : μg", "Δt F m Δs v2", "85", "",
         "Δt |Fn| m μg v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μg", "Δt F m v1 {v}", "85", "",
         "Δt |Fn| m μg v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μg", "Δt F m v1 W", "85", "",
         "Δt |Fn| m μg v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μg", "Δt F m v2 {v}", "85", "",
         "Δt |Fn| m μg v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μg", "Δt F m v2 W", "85", "",
         "Δt |Fn| m μg Δv", "Δt = m Δv : |Fn| : μg", "Δt F m Δv", "85", "",
         "Δt |Fn| m μh P v1", "Δt = 2 m (P : |Fn| : μh - v1) : |Fn| : μh", "Δt F m P v1", "88", "",
         "Δt |Fn| m μh P v2", "Δt = 2 m (v2 - P : |Fn| : μh) : |Fn| : μh", "Δt F m P v2", "88", "",
         "Δt |Fn| m μh Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : |Fn| : μh", "Δt F m Δs v1", "88", "",
         "Δt |Fn| m μh Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : |Fn| : μh", "Δt F m Δs v2", "88", "",
         "Δt |Fn| m μh v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μh", "Δt F m v1 {v}", "88", "",
         "Δt |Fn| m μh v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μh", "Δt F m v1 W", "88", "",
         "Δt |Fn| m μh v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μh", "Δt F m v2 {v}", "88", "",
         "Δt |Fn| m μh v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μh", "Δt F m v2 W", "88", "",
         "Δt |Fn| m μh Δv", "Δt = m Δv : |Fn| : μh", "Δt F m Δv", "88", "",
         "Δt |Fn| m μr P v1", "Δt = 2 m (P : |Fn| : μr - v1) : |Fn| : μr", "Δt F m P v1", "91", "",
         "Δt |Fn| m μr P v2", "Δt = 2 m (v2 - P : |Fn| : μr) : |Fn| : μr", "Δt F m P v2", "91", "",
         "Δt |Fn| m μr Δs v1", "Δt = m (-v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : |Fn| : μr", "Δt F m Δs v1", "91", "",
         "Δt |Fn| m μr Δs v2", "Δt = m (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : |Fn| : μr", "Δt F m Δs v2", "91", "",
         "Δt |Fn| m μr v1 {v}", "Δt = 2 m ({v} - v1) : |Fn| : μr", "Δt F m v1 {v}", "91", "",
         "Δt |Fn| m μr v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : |Fn| : μr", "Δt F m v1 W", "91", "",
         "Δt |Fn| m μr v2 {v}", "Δt = 2 m (v2 - {v}) : |Fn| : μr", "Δt F m v2 {v}", "91", "",
         "Δt |Fn| m μr v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : |Fn| : μr", "Δt F m v2 W", "91", "",
         "Δt |Fn| m μr Δv", "Δt = m Δv : |Fn| : μr", "Δt F m Δv", "91", "",
         "Δt |Fn| μg P Δs", "Δt = |Fn| μg Δs : P", "Δt F P Δs", "85", "",
         "Δt |Fn| μg v1 v2 W", "Δt = 2 W : |Fn| : μg : (v1 + v2)", "Δt F v1 v2 W", "85", "",
         "Δt |Fn| μg v1 Δv W", "Δt = W : |Fn| : μg : (v1 + Δv : 2)", "Δt F v1 Δv W", "85", "",
         "Δt |Fn| μg v2 Δv W", "Δt = W : |Fn| : μg : (v2 - Δv : 2)", "Δt F v2 Δv W", "85", "",
         "Δt |Fn| μg {v} W", "Δt = W : |Fn| : μg : {v}", "Δt F {v} W", "85", "",
         "Δt |Fn| μh P Δs", "Δt = |Fn| μh Δs : P", "Δt F P Δs", "88", "",
         "Δt |Fn| μh v1 v2 W", "Δt = 2 W : |Fn| : μh : (v1 + v2)", "Δt F v1 v2 W", "88", "",
         "Δt |Fn| μh v1 Δv W", "Δt = W : |Fn| : μh : (v1 + Δv : 2)", "Δt F v1 Δv W", "88", "",
         "Δt |Fn| μh v2 Δv W", "Δt = W : |Fn| : μh : (v2 - Δv : 2)", "Δt F v2 Δv W", "88", "",
         "Δt |Fn| μh {v} W", "Δt = W : |Fn| : μh : {v}", "Δt F {v} W", "88", "",
         "Δt |Fn| μr P Δs", "Δt = |Fn| μr Δs : P", "Δt F P Δs", "91", "",
         "Δt |Fn| μr v1 v2 W", "Δt = 2 W : |Fn| : μr : (v1 + v2)", "Δt F v1 v2 W", "91", "",
         "Δt |Fn| μr v1 Δv W", "Δt = W : |Fn| : μr : (v1 + Δv : 2)", "Δt F v1 Δv W", "91", "",
         "Δt |Fn| μr v2 Δv W", "Δt = W : |Fn| : μr : (v2 - Δv : 2)", "Δt F v2 Δv W", "91", "",
         "Δt |Fn| μr {v} W", "Δt = W : |Fn| : μr : {v}", "Δt F {v} W", "91", "",
         "Δt k m P Δv", "Δt = √(-(m Δv) ^ 2 : k : P ' 3)", "Δt k m Δv W", "44", "",
         "Δt k m Δs v1", "Δt = m (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : k : Δs", "Δt F k m v1", "57", "",
         "Δt k m Δs v2", "Δt = -m (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : k : Δs", "Δt F k m v2", "57", "",
         "Δt k m Δs Δv", "Δt = -m Δv : k : Δs", "Δt F m Δv", "57", "",
         "Δt k m v1 v2", "Δt = √(-2 m (v2 - v1) : k : (v1 + v2))", "Δt k m Δv {v}", "19", "",
         "Δt k m v1 Δv", "Δt = √(-m Δv : k : (v1 + Δv : 2))", "Δt k m Δv {v}", "18", "",
         "Δt k m v1 {v}", "Δt = √(-2 m ({v} - v1) : k : {v})", "Δt k m Δv {v}", "16", "",
         "Δt k m v1 W", "Δt = m (-v1 ± √(v1 ^ 2 + 2 W : m)) : √(-k W)", "Δt F k m v1", "75", "",
         "Δt k m v2 Δv", "Δt = √(-m Δv : k : (v2 - Δv : 2))", "Δt k m Δv {v}", "15", "",
         "Δt k m v2 {v}", "Δt = √(-2 m (v2 - {v}) : k : {v})", "Δt k m Δv {v}", "13", "",
         "Δt k m v2 W", "Δt = m (v2 ± √(v2 ^ 2 - 2 W : m)) : √(-k W)", "Δt F k m v2", "75", "",
         "Δt k m Δv W", "Δt = m Δv : √(-k W)", "Δt F m Δv", "75", "",
         "Δt k m Δv {v}", "Δt = √(-m Δv : k : {v})", "Δt k m Δs Δv", "21", "",
         "Δt k P Δs", "Δt = -k Δs ^ 2 : P", "Δt F k P", "57", "",
         "Δt k P v1 v2", "Δt = -4 P : k : (v1 + v2) ^ 2", "Δt k P {v}", "10", "",
         "Δt k P v1 Δv", "Δt = -P : k : (v1 + Δv : 2) ^ 2", "Δt k P {v}", "18", "",
         "Δt k P v2 Δv", "Δt = -P : k : (v2 - Δv : 2) ^ 2", "Δt k P {v}", "15", "",
         "Δt k P {v}", "Δt = -P : k : {v} ^ 2", "Δt F k {v}", "61", "",
         "Δt k v1 v2 W", "Δt = 2 √(-W : k) : (v1 + v2)", "Δt k {v} W", "10", "",
         "Δt k v1 Δv W", "Δt = √(-W : k) : (v1 + Δv : 2)", "Δt k {v} W", "18", "",
         "Δt k v2 Δv W", "Δt = √(-W : k) : (v2 - Δv : 2)", "Δt k {v} W", "15", "",
         "Δt k {v} W", "Δt = √(-W : k) : {v}", "Δt F k {v}", "75", "",
         "Δt m P Δs Δv", "Δt = √(m Δs Δv : P)", "Δt m Δs Δv W", "44", "",
         "Δt m P v1 v2", "Δt = m (v2 ^ 2 - v1 ^ 2) : P : 2", "Δt m P Δv {v}", "19", "",
         "Δt m P v1 Δv", "Δt = m Δv (v1 + Δv : 2) : P", "Δt m P Δv {v}", "18", "",
         "Δt m P v1 {v}", "Δt = 2 m {v} ({v} - v1) : P", "Δt m P Δv {v}", "16", "",
         "Δt m P v2 Δv", "Δt = m Δv (v2 - Δv : 2) : P", "Δt m P Δv {v}", "15", "",
         "Δt m P v2 {v}", "Δt = 2 m {v} (v2 - {v}) : P", "Δt m P Δv {v}", "13", "",
         "Δt m P Δv {v}", "Δt = m Δv {v} : P", "Δt m P Δs Δv", "61", "",
         "Δt m p Δs", "Δt = m Δs : p", "Δt Δs v", "56", "",
         "Δt m Δs v1 W", "Δt = m Δs (-v1 ± √(v1 ^ 2 + 2 W : m)) : W", "Δt F m Δs v1", "30", "",
         "Δt m Δs v2 W", "Δt = m Δs (v2 ± √(v2 ^ 2 - 2 W : m)) : W", "Δt F m Δs v2", "30", "",
         "Δt m Δs Δv W", "Δt = m Δs Δv : W", "Δt F m Δv", "30", "",
         "Δt P W", "Δt = W : P", "", "43", "",
         "Δt Δs v", "Δt = Δs : v", "", "53", "",
         "Δt Δs v1 v2", "Δt = 2 Δs : (v1 + v2)", "Δt Δs {v}", "10", "",
         "Δt Δs v1 Δv", "Δt = Δs : (v1 + Δv : 2)", "Δt Δs {v}", "18", "",
         "Δt Δs v2 Δv", "Δt = Δs : (v2 - Δv : 2)", "Δt Δs {v}", "15", "",
         "Δt Δs {v}", "Δt = Δs : {v}", "", "22", "",
         "Δt t1 t2", "Δt = t2 - t1", "", "4", "2"];
          CAI = AA[0];
        } // Δt
        if (AA[0] == FAB[189])
        {
          FAC = [
         "V c n", "V = n : c", "", "47", "",
         "V c M m", "V = m : c : M", "V c n", "50", ""];
          CAI = AA[0];
        } // V
        if (AA[0] == FAB[192])
        {
          FAC = [
         "v m p", "v = p : m", "", "56", "",
         "v Δs Δt", "v = Δs : Δt", "", "51", "",
         "v vx", "v = vx", "", "0", "",
         "v vy", "v = vy", "", "0", "",
         "v vz", "v = vz", "", "0", "",
         "v vx θ", "v = vx : cos(θ)", "", "0", "",
         "v vy θ", "v = vy : sin(θ)", "", "0", "",
         "v vz θ", "v = vz : cos(θ)", "", "0", "",
         "v vx θ ϕ", "v = vx : cos(θ) : sin(ϕ)", "", "0", "",
         "v vz θ ϕ", "v = vz : cos(θ) : cos(ϕ)", "", "0", "",
         "v vx vy", "v = √(vx ^ 2 + vy ^ 2)", "", "0", "",
         "v vx vz", "v = √(vx ^ 2 + vz ^ 2)", "", "0", "",
         "v vy vz", "v = √(vy ^ 2 + vz ^ 2)", "", "0", "",
         "v vx vy vz", "v = √(vx ^ 2 + vy ^ 2 + vz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // v
        if (AA[0] == FAB[195])
        {
          FAC = [
         "vx v", "vx = v", "", "0", "",
         "vx v θ", "vx = v cos(θ)", "", "0", "",
         "vx vy θ", "vx = vy : tan(θ)", "", "0", "",
         "vx vz ϕ", "vx = vz tan(ϕ)", "", "0", "",
         "vx v vy", "vx = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vx v vz", "vx = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vx v θ ϕ", "vx = v cos(θ) sin(ϕ)", "", "0", "",
         "vx vy θ ϕ", "vx = vy sin(ϕ) : tan(θ)", "", "0", "",
         "vx v vy vz", "vx = √(v ^ 2 - vy ^ 2 - vz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vx
        if (AA[0] == FAB[198])
        {
          FAC = [
         "vy v", "vy = v", "", "0", "",
         "vy v θ", "vy = v sin(θ)", "", "0", "",
         "vy vx θ", "vy = vx tan(θ)", "", "0", "",
         "vy vz θ", "vy = vz tan(θ)", "", "0", "",
         "vy v vx", "vy = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vy v vz", "vy = √(v ^ 2 - vz ^ 2)", "", "0", "",
         "vy vx θ ϕ", "vy = vx tan(θ) : sin(ϕ)", "", "0", "",
         "vy vz θ ϕ", "vy = vz tan(θ) : cos(ϕ)", "", "0", "",
         "vy v vx vz", "vy = √(v ^ 2 - vx ^ 2 - vz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vy
        if (AA[0] == FAB[201])
        {
          FAC = [
         "vz v", "vz = v", "", "0", "",
         "vz v θ", "vz = v cos(θ)", "", "0", "",
         "vz vx ϕ", "vz = vx : tan(ϕ)", "", "0", "",
         "vz vy θ", "vz = vy : tan(θ)", "", "0", "",
         "vz v vx", "vz = √(v ^ 2 - vx ^ 2)", "", "0", "",
         "vz v vy", "vz = √(v ^ 2 - vy ^ 2)", "", "0", "",
         "vz vy θ ϕ", "vz = vy cos(ϕ) : tan(θ)", "", "0", "",
         "vz v θ ϕ", "vz = v cos(θ) cos(ϕ)", "", "0", "",
         "vz v vx vy", "vz = √(v ^ 2 - vx ^ 2 - vy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vz
        if (AA[0] == FAB[204])
        {
          FAC = [
         "v1 a F k P", "v1 = P : F + a F ^ 2 : k : P : 2", "v1 a F k {v}", "62", "",
         "v1 a F k Δt", "v1 = -F : k : Δt - a Δt : 2", "v1 F k Δt Δv", "24", "",
         "v1 a F k v2", "v1 = √(v2 ^ 2 + 2 a F : k)", "v1 a Δs v2", "59", "",
         "v1 a F k Δv", "v1 = -a F : k : Δv - Δv : 2", "v1 F k Δt Δv", "25", "",
         "v1 a F k {v}", "v1 = {v} + a F : k : {v} : 2", "v1 a Δs {v}", "59", "",
         "v1 a F P Δs", "v1 = P : F - a F Δs : P : 2", "v1 a F P W", "29", "",
         "v1 a F P Δt", "v1 = P : F - a Δt : 2", "v1 F P Δv", "24", "",
         "v1 a F P W", "v1 = P (2 a W : F - (a W : P) ^ 2) : a : W : 2", "v1 a F P Δt", "43", "",
         "v1 a F Δt W", "v1 = W : F : Δt - a Δt : 2", "v1 a Δs Δt", "31", "",
         "v1 a F v2 W", "v1 = √(v2 ^ 2 - 2 a W : F)", "v1 a Δs v2", "31", "",
         "v1 a F Δv W", "v1 = a W : F : Δv - Δv : 2", "v1 a Δs Δv", "31", "",
         "v1 a F {v} W", "v1 = {v} - a W : F : {v} : 2", "v1 a Δs {v}", "31", "",
         "v1 a |Fn| μg P Δs", "v1 = P : |Fn| : μg - a |Fn| μg Δs : P : 2", "v1 a F P Δs", "85", "",
         "v1 a |Fn| μg P Δt", "v1 = P : |Fn| : μg - a Δt : 2", "v1 a F P Δt", "85", "",
         "v1 a |Fn| μg P W", "v1 = P : |Fn| : μg - a W : P : 2", "v1 a F P W", "85", "",
         "v1 a |Fn| μg Δt W", "v1 = W : |Fn| : μg : Δt - a Δt : 2", "v1 a F Δt W", "85", "",
         "v1 a |Fn| μg v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μg)", "v1 a F v2 W", "85", "",
         "v1 a |Fn| μg Δv W", "v1 = a W : |Fn| : μg : Δv - Δv : 2", "v1 a F Δv W", "85", "",
         "v1 a |Fn| μg {v} W", "v1 = {v} - a W : |Fn| : μg : {v} : 2", "v1 a F {v} W", "85", "",
         "v1 a |Fn| μh P Δs", "v1 = P : |Fn| : μh - a |Fn| μh Δs : P : 2", "v1 a F P Δs", "88", "",
         "v1 a |Fn| μh P Δt", "v1 = P : |Fn| : μh - a Δt : 2", "v1 a F P Δt", "88", "",
         "v1 a |Fn| μh P W", "v1 = P : |Fn| : μh - a W : P : 2", "v1 a F P W", "88", "",
         "v1 a |Fn| μh Δt W", "v1 = W : |Fn| : μh : Δt - a Δt : 2", "v1 a F Δt W", "88", "",
         "v1 a |Fn| μh v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μh)", "v1 a F v2 W", "88", "",
         "v1 a |Fn| μh Δv W", "v1 = a W : |Fn| : μh : Δv - Δv : 2", "v1 a F Δv W", "88", "",
         "v1 a |Fn| μh {v} W", "v1 = {v} - a W : |Fn| : μh : {v} : 2", "v1 a F {v} W", "88", "",
         "v1 a |Fn| μr P Δs", "v1 = P : |Fn| : μr - a |Fn| μr Δs : P : 2", "v1 a F P Δs", "91", "",
         "v1 a |Fn| μr P Δt", "v1 = P : |Fn| : μr - a Δt : 2", "v1 a F P Δt", "91", "",
         "v1 a |Fn| μr P W", "v1 = P : |Fn| : μr - a W : P : 2", "v1 a F P W", "91", "",
         "v1 a |Fn| μr Δt W", "v1 = W : |Fn| : μr : Δt - a Δt : 2", "v1 a F Δt W", "91", "",
         "v1 a |Fn| μr v2 W", "v1 = √(v2 ^ 2 - 2 a W : |Fn| : μr)", "v1 a F v2 W", "91", "",
         "v1 a |Fn| μr Δv W", "v1 = a W : |Fn| : μr : Δv - Δv : 2", "v1 a F Δv W", "91", "",
         "v1 a |Fn| μr {v} W", "v1 = {v} - a W : |Fn| : μr : {v} : 2", "v1 a F {v} W", "91", "",
         "v1 a k m P", "v1 = P : a : m + a ^ 3 m ^ 2 : k : P : 2", "v1 a F k P", "26", "",
         "v1 a k m Δt", "v1 = -a m : k : Δt - a Δt : 2", "v1 a F k Δt", "26", "",
         "v1 a k m v2", "v1 = √(v2 ^ 2 + 2 a ^ 2 m : k)", "v1 a F k v2", "26", "",
         "v1 a k m Δv", "v1 = -(a ^ 2) m : k : Δv - Δv : 2", "v1 a F k Δv", "26", "",
         "v1 a k m {v}", "v1 = {v} + a ^ 2 m : k : {v} : 2", "v1 a F k {v}", "26", "",
         "v1 a k P Δs", "v1 = -P : k : Δs + a k Δs ^ 2 : P : 2", "v1 a F k P", "57", "",
         "v1 a k P Δt", "v1 = √(-P : k : Δt) - a Δt : 2", "v1 k P Δt Δv", "24", "",
         "v1 a k P Δv", "v1 = √(-a P : k : Δv) - Δv : 2", "v1 k P Δt Δv", "25", "",
         "v1 a k P {v}", "v1 = {v} + a P : k : {v} ^ 2 : 2", "v1 a F k {v}", "61", "",
         "v1 a k P W", "v1 = P : √(-k W) - a W : P : 2", "v1 a k P Δt", "43", "",
         "v1 a k Δt W", "v1 = √(-W : k) : Δt - a Δt : 2", "v1 a k P Δt", "42", "",
         "v1 a k v2 W", "v1 = √(v2 ^ 2 - 2 a √(-W : k))", "v1 a F k v2", "75", "",
         "v1 a k Δv W", "v1 = a √(-W : k) : Δv - Δv : 2", "v1 k Δt Δv W", "25", "",
         "v1 a k {v} W", "v1 = {v} - a √(-W : k) : {v} : 2", "v1 a F k {v}", "75", "",
         "v1 a m P Δs", "v1 = P : a : m - a ^ 2 m Δs : P : 2", "v1 a F P Δs", "26", "",
         "v1 a m P Δt", "v1 = P : a : m - a Δt : 2", "v1 a m P Δv", "24", "",
         "v1 a m P v2", "v1 = 2 P : a : m - v2", "v1 F P v2", "26", "",
         "v1 a m P Δv", "v1 = P : a : m - Δv : 2", "v1 F P Δv", "26", "",
         "v1 a m P W", "v1 = P : a : m - a W : P : 2", "v1 F P W", "26", "",
         "v1 a m Δt W", "v1 = W : a : m : Δt - a Δt : 2", "v1 a F Δt W", "26", "",
         "v1 a P Δs W", "v1 = P Δs : W - a W : P : 2", "v1 a F P W", "30", "",
         "v1 a P {v} W", "v1 = {v} - a W : P : 2", "v1 a Δt {v}", "43", "",
         "v1 a Δs Δt", "v1 = Δs : Δt - a Δt : 2", "v1 a Δt {v}", "20", "",
         "v1 a Δs v2", "v1 = √(v2 ^ 2 - 2 a Δs)", "v1 a Δs Δv", "7", "",
         "v1 a Δs Δv", "v1 = a Δs : Δv - Δv : 2", "v1 Δs Δt Δv", "25", "",
         "v1 a Δs {v}", "v1 = {v} - a Δs : {v} : 2", "v1 a Δt {v}", "22", "",
         "v1 a Δt {v}", "v1 = {v} - a Δt : 2", "v1 Δv {v}", "24", "",
         "v1 F k m P", "v1 = P : F + F ^ 3 : k : m : P : 2", "v1 a F k P", "27", "",
         "v1 F k m Δt", "v1 = -F : k : Δt - F Δt : m : 2", "v1 a F k Δt", "27", "",
         "v1 F k m v2", "v1 = √(v2 ^ 2 + 2 F ^ 2 : k : m)", "v1 a F k v2", "27", "",
         "v1 F k m Δv", "v1 = -(F ^ 2) : k : m : Δv - Δv : 2", "v1 a F k Δv", "27", "",
         "v1 F k m {v}", "v1 = {v} + F ^ 2 : k : m : {v} : 2", "v1 a F k {v}", "27", "",
         "v1 F k Δt v2", "v1 = -2 F : k : Δt - v2", "v1 Δs Δt v2", "59", "",
         "v1 F k Δt Δv", "v1 = -F : k : Δt - Δv : 2", "v1 Δs Δt Δv", "59", "",
         "v1 F m P Δs", "v1 = P : F - F ^ 2 Δs : m : P : 2", "v1 F m P W", "29", "",
         "v1 F m P Δt", "v1 = P : F - F Δt : m : 2", "v1 a F P Δt", "27", "",
         "v1 F m P W", "v1 = P : F - F W : m : P : 2", "v1 a F P W", "27", "",
         "v1 F m Δs Δt", "v1 = Δs : Δt - F Δt : m : 2", "v1 a Δs Δt", "27", "",
         "v1 F m Δs v2", "v1 = √(v2 ^ 2 - 2 F Δs : m)", "v1 a Δs v2", "27", "",
         "v1 F m Δs Δv", "v1 = F Δs : m : Δv - Δv : 2", "v1 a Δs Δv", "27", "",
         "v1 F m Δs {v}", "v1 = {v} - F Δs : m : {v} : 2", "v1 a Δs {v}", "27", "",
         "v1 F m Δt {v}", "v1 = {v} - F Δt : m : 2", "v1 a Δt {v}", "27", "",
         "v1 F m Δt W", "v1 = W : F : Δt - F Δt : m : 2", "v1 a F Δt W", "27", "",
         "v1 F P v2", "v1 = 2 P : F - v2", "v1 F Δt v2 W", "43", "",
         "v1 F P Δv", "v1 = P : F - Δv : 2", "v1 Δv {v}", "62", "",
         "v1 F Δt v2 W", "v1 = 2 W : F : Δt - v2", "v1 Δs Δt v2", "31", "",
         "v1 F Δt Δv W", "v1 = W : F : Δt - Δv : 2", "v1 Δs Δt Δv", "31", "",
         "v1 |Fn| m μg P Δs", "v1 = P : |Fn| : μg - (|Fn| μg) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "85", "",
         "v1 |Fn| m μg P Δt", "v1 = P : |Fn| : μg - |Fn| μg Δt : m : 2", "v1 F m P Δt", "85", "",
         "v1 |Fn| m μg P W", "v1 = P : |Fn| : μg - |Fn| μg W : m : P : 2", "v1 F m P W", "85", "",
         "v1 |Fn| m μg Δs Δt", "v1 = Δs : Δt - |Fn| μg Δt : m : 2", "v1 F m Δs Δt", "85", "",
         "v1 |Fn| m μg Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μg Δs : m)", "v1 F m Δs v2", "85", "",
         "v1 |Fn| m μg Δs Δv", "v1 = |Fn| μg Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "85", "",
         "v1 |Fn| m μg Δs {v}", "v1 = {v} - |Fn| μg Δs : m : {v} : 2", "v1 F m Δs {v}", "85", "",
         "v1 |Fn| m μg Δt {v}", "v1 = {v} - |Fn| μg Δt : m : 2", "v1 F m Δt {v}", "85", "",
         "v1 |Fn| m μg Δt W", "v1 = W : |Fn| : μg : Δt - |Fn| μg Δt : m : 2", "v1 F m Δt W", "85", "",
         "v1 |Fn| m μh P Δs", "v1 = P : |Fn| : μh - (|Fn| μh) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "88", "",
         "v1 |Fn| m μh P Δt", "v1 = P : |Fn| : μh - |Fn| μh Δt : m : 2", "v1 F m P Δt", "88", "",
         "v1 |Fn| m μh P W", "v1 = P : |Fn| : μh - |Fn| μh W : m : P : 2", "v1 F m P W", "88", "",
         "v1 |Fn| m μh Δs Δt", "v1 = Δs : Δt - |Fn| μh Δt : m : 2", "v1 F m Δs Δt", "88", "",
         "v1 |Fn| m μh Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μh Δs : m)", "v1 F m Δs v2", "88", "",
         "v1 |Fn| m μh Δs Δv", "v1 = |Fn| μh Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "88", "",
         "v1 |Fn| m μh Δs {v}", "v1 = {v} - |Fn| μh Δs : m : {v} : 2", "v1 F m Δs {v}", "88", "",
         "v1 |Fn| m μh Δt {v}", "v1 = {v} - |Fn| μh Δt : m : 2", "v1 F m Δt {v}", "88", "",
         "v1 |Fn| m μh Δt W", "v1 = W : |Fn| : μh : Δt - |Fn| μh Δt : m : 2", "v1 F m Δt W", "88", "",
         "v1 |Fn| m μr P Δs", "v1 = P : |Fn| : μr - (|Fn| μr) ^ 2 Δs : m : P : 2", "v1 F m P Δs", "91", "",
         "v1 |Fn| m μr P Δt", "v1 = P : |Fn| : μr - |Fn| μr Δt : m : 2", "v1 F m P Δt", "91", "",
         "v1 |Fn| m μr P W", "v1 = P : |Fn| : μr - |Fn| μr W : m : P : 2", "v1 F m P W", "91", "",
         "v1 |Fn| m μr Δs Δt", "v1 = Δs : Δt - |Fn| μr Δt : m : 2", "v1 F m Δs Δt", "91", "",
         "v1 |Fn| m μr Δs v2", "v1 = √(v2 ^ 2 - 2 |Fn| μr Δs : m)", "v1 F m Δs v2", "91", "",
         "v1 |Fn| m μr Δs Δv", "v1 = |Fn| μr Δs : m : Δv - Δv : 2", "v1 F m Δs Δv", "91", "",
         "v1 |Fn| m μr Δs {v}", "v1 = {v} - |Fn| μr Δs : m : {v} : 2", "v1 F m Δs {v}", "91", "",
         "v1 |Fn| m μr Δt {v}", "v1 = {v} - |Fn| μr Δt : m : 2", "v1 F m Δt {v}", "91", "",
         "v1 |Fn| m μr Δt W", "v1 = W : |Fn| : μr : Δt - |Fn| μr Δt : m : 2", "v1 F m Δt W", "91", "",
         "v1 |Fn| μg P v2", "v1 = 2 P : |Fn| : μg - v2", "v1 F P v2", "85", "",
         "v1 |Fn| μg P Δv", "v1 = P : |Fn| : μg - Δv : 2", "v1 F P Δv", "85", "",
         "v1 |Fn| μg Δt v2 W", "v1 = 2 W : |Fn| : μg : Δt - v2", "v1 F Δt v2 W", "85", "",
         "v1 |Fn| μg Δt Δv W", "v1 = W : |Fn| : μg : Δt - Δv : 2", "v1 F Δt Δv W", "85", "",
         "v1 |Fn| μh P v2", "v1 = 2 P : |Fn| : μh - v2", "v1 F P v2", "88", "",
         "v1 |Fn| μh P Δv", "v1 = P : |Fn| : μh - Δv : 2", "v1 F P Δv", "88", "",
         "v1 |Fn| μh Δt v2 W", "v1 = 2 W : |Fn| : μh : Δt - v2", "v1 F Δt v2 W", "88", "",
         "v1 |Fn| μh Δt Δv W", "v1 = W : |Fn| : μh : Δt - Δv : 2", "v1 F Δt Δv W", "88", "",
         "v1 |Fn| μr P v2", "v1 = 2 P : |Fn| : μr - v2", "v1 F P v2", "91", "",
         "v1 |Fn| μr P Δv", "v1 = P : |Fn| : μr - Δv : 2", "v1 F P Δv", "91", "",
         "v1 |Fn| μr Δt v2 W", "v1 = 2 W : |Fn| : μr : Δt - v2", "v1 F Δt v2 W", "91", "",
         "v1 |Fn| μr Δt Δv W", "v1 = W : |Fn| : μr : Δt - Δv : 2", "v1 F Δt Δv W", "91", "",
         "v1 k m P Δs", "v1 = (-k ^ 3 Δs ^ 4 : m : P : 2 - P) : k : Δs", "v1 F k m P", "57", "",
         "v1 k m P Δt", "v1 = √(-k P Δt) (-Δt : m : 2 - 1 : k : Δt)", "v1 k m Δt W", "44", "",
         "v1 k m P Δv", "v1 = √(-(P ^ 2) : k : m : Δv ' 3) - Δv : 2", "v1 k P Δv W", "67", "",
         "v1 k m P {v}", "v1 = {v} + P ^ 2 : k : m : {v} ^ 3 : 2", "v1 F k m {v}", "61", "",
         "v1 k m P W", "v1 = √(-k W) (-W : m : P : 2 - P : k : W)", "v1 k m Δt W", "43", "",
         "v1 k m Δs Δt", "v1 = Δs : Δt + k Δs Δt : m : 2", "v1 k m Δs {v}", "20", "",
         "v1 k m Δs v2", "v1 = √(v2 ^ 2 + 2 k Δs ^ 2 : m)", "v1 F k m v2", "57", "",
         "v1 k m Δs Δv", "v1 = -k Δs ^ 2 : m : Δv - Δv : 2", "v1 F k m Δv", "57", "",
         "v1 k m Δs {v}", "v1 = {v} + k Δs ^ 2 : m : {v} : 2", "v1 F k m {v}", "57", "",
         "v1 k m Δt v2", "v1 = v2 (2 m : k : Δt ^ 2 + 1) : (2 m : k : Δt ^ 2 - 1)", "v1 k Δt v2 W", "81", "",
         "v1 k m Δt Δv", "v1 = -m Δv : k : Δt ^ 2 - Δv : 2", "v1 a k m Δt", "23", "",
         "v1 k m Δt {v}", "v1 = {v} + k Δt ^ 2 {v} : m : 2", "v1 k m Δs {v}", "21", "",
         "v1 k m Δt W", "v1 = √(-k W) (-Δt : m : 2 - 1 : k : Δt)", "v1 k Δt Δv W", "70", "",
         "v1 k P Δs v2", "v1 = -2 P : k : Δs - v2", "v1 F P v2", "57", "",
         "v1 k P Δs Δv", "v1 = -P : k : Δs - Δv : 2", "v1 F P Δv", "57", "",
         "v1 k P Δt v2", "v1 = 2 √(-P : k : Δt) - v2", "v1 k P v2 W", "44", "",
         "v1 k P Δt Δv", "v1 = √(-P : k : Δt) - Δv : 2", "v1 k P Δv W", "44", "",
         "v1 k P v2 W", "v1 = 2 P : √(-k W) - v2", "v1 k P Δs v2", "78", "",
         "v1 k P Δv W", "v1 = P : √(-k W) - Δv : 2", "v1 k P Δs Δv", "78", "",
         "v1 k Δt v2 W", "v1 = 2 √(-W : k) : Δt - v2", "v1 F k Δt v2", "75", "",
         "v1 k Δt Δv W", "v1 = √(-W : k) : Δt - Δv : 2", "v1 k P Δv W", "42", "",
         "v1 m P Δs Δt", "v1 = Δs : Δt - P Δt ^ 2 : m : Δs : 2", "v1 m Δs Δt W", "44", "",
         "v1 m P Δs Δv", "v1 = -Δv : 2 ± √(P Δs : m : Δv)", "v1 m P Δs {v}", "18", "",
         "v1 m P Δs {v}", "v1 = {v} - P Δs : m : {v} ^ 2 : 2", "v1 m P Δt {v}", "22", "",
         "v1 m P Δs W", "v1 = P Δs : W - W ^ 2 : m : P : Δs : 2", "v1 F m P W", "30", "",
         "v1 m P Δt v2", "v1 = √(v2 ^ 2 - 2 P Δt : m)", "v1 m v2 W", "44", "",
         "v1 m P Δt Δv", "v1 = P Δt : m : Δv - Δv : 2", "v1 m P Δt {v}", "18", "",
         "v1 m P Δt {v}", "v1 = {v} - P Δt : m : {v} : 2", "v1 F m Δt {v}", "61", "",
         "v1 m Δs Δt W", "v1 = Δs : Δt - Δt W : m : Δs : 2", "v1 F m Δs Δt", "30", "",
         "v1 m v2 W", "v1 = √(v2 ^ 2 - 2 W : m)", "v1 F m Δs v2", "30", "",
         "v1 m Δv W", "v1 = W : m : Δv - Δv : 2", "v1 F m Δs Δv", "30", "",
         "v1 m {v} W", "v1 = {v} - W : m : {v} : 2", "v1 F m Δs {v}", "30", "",
         "v1 P Δs v2 W", "v1 = 2 P Δs : W - v2", "v1 Δs Δt v2", "43", "",
         "v1 P Δs Δv W", "v1 = P Δs : W - Δv : 2", "v1 F P Δv", "30", "",
         "v1 Δs Δt v2", "v1 = 2 Δs : Δt - v2", "v1 v2 {v}", "20", "",
         "v1 Δs Δt Δv", "v1 = Δs : Δt - Δv : 2", "v1 Δv {v}", "20", "",
         "v1 v2 Δv", "v1 = v2 - Δv", "", "8", "3",
         "v1 v2 {v}", "v1 = 2 {v} - v2", "", "11", "3",
         "v1 Δv {v}", "v1 = {v} - Δv : 2", "v1 v2 Δv", "12", "3"];
          CAI = AA[0];
        } // v1
        if (AA[0] == FAB[207])
        {
          FAC = [
         "vx1 v1", "vx1 = v1", "", "0", "",
         "vx1 v1 θ", "vx1 = v1 cos(θ)", "", "0", "",
         "vx1 vy1 θ", "vx1 = vy1 : tan(θ)", "", "0", "",
         "vx1 vz1 ϕ", "vx1 = vz1 tan(ϕ)", "", "0", "",
         "vx1 v1 vy1", "vx1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vx1 v1 vz1", "vx1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vx1 v1 θ ϕ", "vx1 = v1 cos(θ) sin(ϕ)", "", "0", "",
         "vx1 vy1 θ ϕ", "vx1 = vy1 sin(ϕ) : tan(θ)", "", "0", "",
         "vx1 v1 vy1 vz1", "vx1 = √(v1 ^ 2 - vy1 ^ 2 - vz1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vx1
        if (AA[0] == FAB[210])
        {
          FAC = [
         "vy1 v1", "vy1 = v1", "", "0", "",
         "vy1 v1 θ", "vy1 = v1 sin(θ)", "", "0", "",
         "vy1 vx1 θ", "vy1 = vx1 tan(θ)", "", "0", "",
         "vy1 vz1 θ", "vy1 = vz1 tan(θ)", "", "0", "",
         "vy1 v1 vx1", "vy1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vy1 v1 vz1", "vy1 = √(v1 ^ 2 - vz1 ^ 2)", "", "0", "",
         "vy1 vx1 θ ϕ", "vy1 = vx1 tan(θ) : sin(ϕ)", "", "0", "",
         "vy1 vz1 θ ϕ", "vy1 = vz1 tan(θ) : cos(ϕ)", "", "0", "",
         "vy1 v1 vx1 vz1", "vy1 = √(v1 ^ 2 - vx1 ^ 2 - vz1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vy1
        if (AA[0] == FAB[213])
        {
          FAC = [
         "vz1 v1", "vz1 = v1", "", "0", "",
         "vz1 v1 θ", "vz1 = v1 cos(θ)", "", "0", "",
         "vz1 vx1 ϕ", "vz1 = vx1 : tan(ϕ)", "", "0", "",
         "vz1 vy1 θ", "vz1 = vy1 : tan(θ)", "", "0", "",
         "vz1 v1 vx1", "vz1 = √(v1 ^ 2 - vx1 ^ 2)", "", "0", "",
         "vz1 v1 vy1", "vz1 = √(v1 ^ 2 - vy1 ^ 2)", "", "0", "",
         "vz1 vy1 θ ϕ", "vz1 = vy1 cos(ϕ) : tan(θ)", "", "0", "",
         "vz1 v1 θ ϕ", "vz1 = v1 cos(θ) cos(ϕ)", "", "0", "",
         "vz1 v1 vx1 vy1", "vz1 = √(v1 ^ 2 - vx1 ^ 2 - vy1 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vz1
        if (AA[0] == FAB[216])
        {
          FAC = [
         "v2 a F k P", "v2 = P : F - a F ^ 2 : k : P : 2", "v2 a F k {v}", "62", "",
         "v2 a F k Δt", "v2 = a Δt : 2 - F : k : Δt", "v2 F k Δt Δv", "24", "",
         "v2 a F k v1", "v2 = √(v1 ^ 2 - 2 a F : k)", "v2 a Δs v1", "59", "",
         "v2 a F k Δv", "v2 = Δv : 2 - a F : k : Δv", "v2 F k Δt Δv", "25", "",
         "v2 a F k {v}", "v2 = {v} - a F : k : {v} : 2", "v2 a Δs {v}", "59", "",
         "v2 a F P Δs", "v2 = P : F + a F Δs : P : 2", "v2 a F P W", "29", "",
         "v2 a F P Δt", "v2 = P : F + a Δt : 2", "v2 F P Δv", "24", "",
         "v2 a F P W", "v2 = P : F + a W : P : 2", "v2 a F P Δt", "43", "",
         "v2 a F Δt W", "v2 = W : F : Δt + a Δt : 2", "v2 a Δs Δt", "31", "",
         "v2 a F v1 W", "v2 = √(v1 ^ 2 + 2 a W : F)", "v2 a Δs v1", "31", "",
         "v2 a F Δv W", "v2 = a W : F : Δv + Δv : 2", "v2 a Δs Δv", "31", "",
         "v2 a F {v} W", "v2 = {v} + a W : F : {v} : 2", "v2 a Δs {v}", "31", "",
         "v2 a |Fn| μg P Δs", "v2 = P : |Fn| : μg + a |Fn| μg Δs : P : 2", "v2 a F P Δs", "85", "",
         "v2 a |Fn| μg P Δt", "v2 = P : |Fn| : μg + a Δt : 2", "v2 a F P Δt", "85", "",
         "v2 a |Fn| μg P W", "v2 = P : |Fn| : μg + a W : P : 2", "v2 a F P W", "85", "",
         "v2 a |Fn| μg Δt W", "v2 = W : |Fn| : μg : Δt + a Δt : 2", "v2 a F Δt W", "85", "",
         "v2 a |Fn| μg v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μg)", "v2 a F v1 W", "85", "",
         "v2 a |Fn| μg Δv W", "v2 = a W : |Fn| : μg : Δv + Δv : 2", "v2 a F Δv W", "85", "",
         "v2 a |Fn| μg {v} W", "v2 = {v} + a W : |Fn| : μg : {v} : 2", "v2 a F {v} W", "85", "",
         "v2 a |Fn| μh P Δs", "v2 = P : |Fn| : μh + a |Fn| μh Δs : P : 2", "v2 a F P Δs", "88", "",
         "v2 a |Fn| μh P Δt", "v2 = P : |Fn| : μh + a Δt : 2", "v2 a F P Δt", "88", "",
         "v2 a |Fn| μh P W", "v2 = P : |Fn| : μh + a W : P : 2", "v2 a F P W", "88", "",
         "v2 a |Fn| μh Δt W", "v2 = W : |Fn| : μh : Δt + a Δt : 2", "v2 a F Δt W", "88", "",
         "v2 a |Fn| μh v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μh)", "v2 a F v1 W", "88", "",
         "v2 a |Fn| μh Δv W", "v2 = a W : |Fn| : μh : Δv + Δv : 2", "v2 a F Δv W", "88", "",
         "v2 a |Fn| μh {v} W", "v2 = {v} + a W : |Fn| : μh : {v} : 2", "v2 a F {v} W", "88", "",
         "v2 a |Fn| μr P Δs", "v2 = P : |Fn| : μr + a |Fn| μr Δs : P : 2", "v2 a F P Δs", "91", "",
         "v2 a |Fn| μr P Δt", "v2 = P : |Fn| : μr + a Δt : 2", "v2 a F P Δt", "91", "",
         "v2 a |Fn| μr P W", "v2 = P : |Fn| : μr + a W : P : 2", "v2 a F P W", "91", "",
         "v2 a |Fn| μr Δt W", "v2 = W : |Fn| : μr : Δt + a Δt : 2", "v2 a F Δt W", "91", "",
         "v2 a |Fn| μr v1 W", "v2 = √(v1 ^ 2 + 2 a W : |Fn| : μr)", "v2 a F v1 W", "91", "",
         "v2 a |Fn| μr Δv W", "v2 = a W : |Fn| : μr : Δv + Δv : 2", "v2 a F Δv W", "91", "",
         "v2 a |Fn| μr {v} W", "v2 = {v} + a W : |Fn| : μr : {v} : 2", "v2 a F {v} W", "91", "",
         "v2 a k m P", "v2 = P : a : m - a ^ 3 m ^ 2 : k : P : 2", "v2 a F k P", "26", "",
         "v2 a k m Δt", "v2 = a Δt : 2 - a m : k : Δt", "v2 a F k Δt", "26", "",
         "v2 a k m v1", "v2 = √(v1 ^ 2 - 2 a ^ 2 m : k)", "v2 a F k v1", "26", "",
         "v2 a k m Δv", "v2 = Δv : 2 - a ^ 2 m : k : Δv", "v2 a F k Δv", "26", "",
         "v2 a k m {v}", "v2 = {v} - a ^ 2 m : k : {v} : 2", "v2 a F k {v}", "26", "",
         "v2 a k P Δs", "v2 = -P : k : Δs - a k Δs ^ 2 : P : 2", "v2 a F k P", "57", "",
         "v2 a k P Δt", "v2 = a Δt : 2 + √(-P : k : Δt)", "v2 k P Δt Δv", "24", "",
         "v2 a k P Δv", "v2 = Δv : 2 + √(-a P : k : Δv)", "v2 k P Δt Δv", "25", "",
         "v2 a k P {v}", "v2 = {v} - a P : k : {v} ^ 2 : 2", "v2 a F k {v}", "61", "",
         "v2 a k P W", "v2 = P : √(-k W) + a W : P : 2", "v2 a k P Δt", "43", "",
         "v2 a k Δt W", "v2 = a Δt : 2 + √(-W : k) : Δt", "v2 a k P Δt", "42", "",
         "v2 a k v1 W", "v2 = √(v1 ^ 2 + 2 a √(-W : k))", "v2 a F k v1", "75", "",
         "v2 a k Δv W", "v2 = Δv : 2 + a √(-W : k) : Δv", "v2 k Δt Δv W", "25", "",
         "v2 a k {v} W", "v2 = {v} + a √(-W : k) : {v} : 2", "v2 a F k {v}", "75", "",
         "v2 a m P Δs", "v2 = P : a : m + a ^ 2 m Δs : P : 2", "v2 a F P Δs", "26", "",
         "v2 a m P Δt", "v2 = P : a : m + a Δt : 2", "v2 a m P Δv", "24", "",
         "v2 a m P v1", "v2 = 2 P : a : m - v1", "v2 F P v1", "26", "",
         "v2 a m P Δv", "v2 = P : a : m + Δv : 2", "v2 F P Δv", "26", "",
         "v2 a m P W", "v2 = P : a : m + a W : P : 2", "v2 a F P W", "26", "",
         "v2 a m Δt W", "v1 = W : a : m : Δt + a Δt : 2", "v2 a F Δt W", "26", "",
         "v2 a P Δs W", "v2 = P Δs : W + a W : P : 2", "v2 a F P W", "30", "",
         "v2 a P {v} W", "v2 = {v} + a W : P : 2", "v2 a Δt {v}", "43", "",
         "v2 a Δs Δt", "v2 = Δs : Δt + a Δt : 2", "v2 a Δt {v}", "20", "",
         "v2 a Δs v1", "v2 = √(v1 ^ 2 + 2 a Δs)", "v2 a Δs Δv", "7", "",
         "v2 a Δs Δv", "v2 = a Δs : Δv + Δv : 2", "v2 Δs Δt Δv", "25", "",
         "v2 a Δs {v}", "v2 = {v} + a Δs : {v} : 2", "v2 a Δt {v}", "22", "",
         "v2 a Δt {v}", "v2 = {v} + a Δt : 2", "v2 Δv {v}", "24", "",
         "v2 F k m P", "v2 = P : F - F ^ 3 : k : m : P : 2", "v2 a F k P", "27", "",
         "v2 F k m Δt", "v2 = F Δt : m : 2 - F : k : Δt", "v2 a F k Δt", "27", "",
         "v2 F k m v1", "v2 = √(v1 ^ 2 - 2 F ^ 2 : k : m)", "v2 a F k v1", "27", "",
         "v2 F k m Δv", "v2 = Δv : 2 - F ^ 2 : k : m : Δv", "v2 a F k Δv", "27", "",
         "v2 F k m {v}", "v2 = {v} - F ^ 2 : k : m : {v} : 2", "v2 a F k {v}", "27", "",
         "v2 F k Δt v1", "v2 = -2 F : k : Δt - v1", "v2 Δs Δt v1", "59", "",
         "v2 F k Δt Δv", "v2 = Δv : 2 - F : k : Δt", "v2 Δs Δt Δv", "59", "",
         "v2 F m P Δs", "v2 = P : F + F ^ 2 Δs : m : P : 2", "v2 F m P W", "29", "",
         "v2 F m P Δt", "v2 = P : F + F Δt : m : 2", "v2 a F P Δt", "27", "",
         "v2 F m P W", "v2 = P : F + F W : m : P : 2", "v2 a F P W", "27", "",
         "v2 F m Δs Δt", "v2 = Δs : Δt + F Δt : m : 2", "v2 a Δs Δt", "27", "",
         "v2 F m Δs v1", "v2 = √(v1 ^ 2 + 2 F Δs : m)", "v2 a Δs v1", "27", "",
         "v2 F m Δs Δv", "v2 = F Δs : m : Δv + Δv : 2", "v2 a Δs Δv", "27", "",
         "v2 F m Δs {v}", "v2 = {v} + F Δs : m : {v} : 2", "v2 a Δs {v}", "27", "",
         "v2 F m Δt {v}", "v2 = {v} + F Δt : m : 2", "v2 a Δt {v}", "27", "",
         "v2 F m Δt W", "v2 = W : F : Δt + F Δt : m : 2", "v2 a F Δt W", "27", "",
         "v2 F P v1", "v2 = 2 P : F - v1", "v2 F Δt v1 W", "43", "",
         "v2 F P Δv", "v2 = P : F + Δv : 2", "v2 Δv {v}", "62", "",
         "v2 F Δt v1 W", "v2 = 2 W : F : Δt - v1", "v2 Δs Δt v1", "31", "",
         "v2 F Δt Δv W", "v2 = W : F : Δt + Δv : 2", "v2 Δs Δt Δv", "31", "",
         "v2 |Fn| m μg P Δs", "v2 = P : |Fn| : μg + (|Fn| μg) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "85", "",
         "v2 |Fn| m μg P Δt", "v2 = P : |Fn| : μg + |Fn| μg Δt : m : 2", "v2 F m P Δt", "85", "",
         "v2 |Fn| m μg P W", "v2 = P : |Fn| : μg + |Fn| μg W : m : P : 2", "v2 F m P W", "85", "",
         "v2 |Fn| m μg Δs Δt", "v2 = Δs : Δt + |Fn| μg Δt : m : 2", "v2 F m Δs Δt", "85", "",
         "v2 |Fn| m μg Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μg Δs : m)", "v2 F m Δs v1", "85", "",
         "v2 |Fn| m μg Δs Δv", "v2 = |Fn| μg Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "85", "",
         "v2 |Fn| m μg Δs {v}", "v2 = {v} + |Fn| μg Δs : m : {v} : 2", "v2 F m Δs {v}", "85", "",
         "v2 |Fn| m μg Δt {v}", "v2 = {v} + |Fn| μg Δt : m : 2", "v2 F m Δt {v}", "85", "",
         "v2 |Fn| m μg Δt W", "v2 = W : |Fn| : μg : Δt + |Fn| μg Δt : m : 2", "v2 F m Δt W", "85", "",
         "v2 |Fn| m μh P Δs", "v2 = P : |Fn| : μh + (|Fn| μh) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "88", "",
         "v2 |Fn| m μh P Δt", "v2 = P : |Fn| : μh + |Fn| μh Δt : m : 2", "v2 F m P Δt", "88", "",
         "v2 |Fn| m μh P W", "v2 = P : |Fn| : μh + |Fn| μh W : m : P : 2", "v2 F m P W", "88", "",
         "v2 |Fn| m μh Δs Δt", "v2 = Δs : Δt + |Fn| μh Δt : m : 2", "v2 F m Δs Δt", "88", "",
         "v2 |Fn| m μh Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μh Δs : m)", "v2 F m Δs v1", "88", "",
         "v2 |Fn| m μh Δs Δv", "v2 = |Fn| μh Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "88", "",
         "v2 |Fn| m μh Δs {v}", "v2 = {v} + |Fn| μh Δs : m : {v} : 2", "v2 F m Δs {v}", "88", "",
         "v2 |Fn| m μh Δt {v}", "v2 = {v} + |Fn| μh Δt : m : 2", "v2 F m Δt {v}", "88", "",
         "v2 |Fn| m μh Δt W", "v2 = W : |Fn| : μh : Δt + |Fn| μh Δt : m : 2", "v2 F m Δt W", "88", "",
         "v2 |Fn| m μr P Δs", "v2 = P : |Fn| : μr + (|Fn| μr) ^ 2 Δs : m : P : 2", "v2 F m P Δs", "91", "",
         "v2 |Fn| m μr P Δt", "v2 = P : |Fn| : μr + |Fn| μr Δt : m : 2", "v2 F m P Δt", "91", "",
         "v2 |Fn| m μr P W", "v2 = P : |Fn| : μr + |Fn| μr W : m : P : 2", "v2 F m P W", "91", "",
         "v2 |Fn| m μr Δs Δt", "v2 = Δs : Δt + |Fn| μr Δt : m : 2", "v2 F m Δs Δt", "91", "",
         "v2 |Fn| m μr Δs v1", "v2 = √(v1 ^ 2 + 2 |Fn| μr Δs : m)", "v2 F m Δs v1", "91", "",
         "v2 |Fn| m μr Δs Δv", "v2 = |Fn| μr Δs : m : Δv + Δv : 2", "v2 F m Δs Δv", "91", "",
         "v2 |Fn| m μr Δs {v}", "v2 = {v} + |Fn| μr Δs : m : {v} : 2", "v2 F m Δs {v}", "91", "",
         "v2 |Fn| m μr Δt {v}", "v2 = {v} + |Fn| μr Δt : m : 2", "v2 F m Δt {v}", "91", "",
         "v2 |Fn| m μr Δt W", "v2 = W : |Fn| : μr : Δt + |Fn| μr Δt : m : 2", "v2 F m Δt W", "91", "",
         "v2 |Fn| μg P v1", "v2 = 2 P : |Fn| : μg - v1", "v2 F P v1", "85", "",
         "v2 |Fn| μg P Δv", "v2 = P : |Fn| : μg + Δv : 2", "v2 F P Δv", "85", "",
         "v2 |Fn| μg Δt v1 W", "v2 = 2 W : |Fn| : μg : Δt - v1", "v2 F Δt v1 W", "85", "",
         "v2 |Fn| μg Δt Δv W", "v2 = W : |Fn| : μg : Δt + Δv : 2", "v2 F Δt Δv W", "85", "",
         "v2 |Fn| μh P v1", "v2 = 2 P : |Fn| : μh - v1", "v2 F P v1", "88", "",
         "v2 |Fn| μh P Δv", "v2 = P : |Fn| : μh + Δv : 2", "v2 F P Δv", "88", "",
         "v2 |Fn| μh Δt v1 W", "v2 = 2 W : |Fn| : μh : Δt - v1", "v2 F Δt v1 W", "88", "",
         "v2 |Fn| μh Δt Δv W", "v2 = W : |Fn| : μh : Δt + Δv : 2", "v2 F Δt Δv W", "88", "",
         "v2 |Fn| μr P v1", "v2 = 2 P : |Fn| : μr - v1", "v2 F P v1", "91", "",
         "v2 |Fn| μr P Δv", "v2 = P : |Fn| : μr + Δv : 2", "v2 F P Δv", "91", "",
         "v2 |Fn| μr Δt v1 W", "v2 = 2 W : |Fn| : μr : Δt - v1", "v2 F Δt v1 W", "91", "",
         "v2 |Fn| μr Δt Δv W", "v2 = W : |Fn| : μr : Δt + Δv : 2", "v2 F Δt Δv W", "91", "",
         "v2 k m P Δs", "v2 = k ^ 2 Δs ^ 3 : m : P : 2 - P : k : Δs", "v2 F k m P", "57", "",
         "v2 k m P Δt", "v2 = √(-k P Δt) (Δt : m - 2 : k : Δt) : 2", "v2 k m Δt W", "44", "",
         "v2 k m P Δv", "v2 = Δv : 2 + √(-(P ^ 2) : k : m : Δv ' 3)", "v2 k P Δv W", "71", "",
         "v2 k m P {v}", "v2 = {v} - P ^ 2 : k : m : {v} ^ 3 : 2", "v2 F k m {v}", "61", "",
         "v2 k m P W", "v2 = √(-k W) (W : m : P : 2 - P : k : W)", "v2 k m Δt W", "43", "",
         "v2 k m Δs Δt", "v2 = Δs : Δt - k Δs Δt : m : 2", "v2 k m Δs {v}", "20", "",
         "v2 k m Δs v1", "v2 = √(v1 ^ 2 - 2 k Δs ^ 2 : m)", "v2 F k m v1", "57", "",
         "v2 k m Δs Δv", "v2 = Δv : 2 - k Δs ^ 2 : m : Δv", "v2 F k m Δv", "57", "",
         "v2 k m Δs {v}", "v2 = {v} - k Δs ^ 2 : m : {v} : 2", "v2 F k m {v}", "57", "",
         "v2 k m Δt v1", "v2 = v1 (2 m : k : Δt ^ 2 - 1) : (2 m : k : Δt ^ 2 + 1)", "v2 k Δt v1 W", "81", "",
         "v2 k m Δt Δv", "v2 = Δv : 2 - m Δv : k : Δt ^ 2", "v2 a k m Δt", "23", "",
         "v2 k m Δt {v}", "v2 = {v} - k Δt ^ 2 {v} : m : 2", "v2 k m Δs {v}", "21", "",
         "v2 k m Δt W", "v2  = √(-k W) (Δt : m : 2 - 1 : k : Δt)", "v2 k Δt Δv W", "74", "",
         "v2 k P Δs v1", "v2 = -2 P : k : Δs - v1", "v2 F P v1", "57", "",
         "v2 k P Δs Δv", "v2 = Δv : 2 - P : k : Δs", "v2 F P Δv", "57", "",
         "v2 k P Δt v1", "v2 = √(-4 P : k : Δt) - v1", "v2 k P v1 W", "44", "",
         "v2 k P Δt Δv", "v2 = Δv : 2 + √(-P : k : Δt)", "v2 k P Δv W", "44", "",
         "v2 k P v1 W", "v2 = 2 P √(-1 : k : W) - v1", "v2 k P Δs v1", "78", "",
         "v2 k P Δv W", "v2 = Δv : 2 + P √(-1 : k : W)", "v2 k P Δs Δv", "78", "",
         "v2 k Δt v1 W", "v2 = 2 √(-W : k) : Δt - v1", "v2 F k Δt v1", "75", "",
         "v2 k Δt Δv W", "v2 = Δv : 2 + √(-W : k) : Δt", "v2 k P Δv W", "42", "",
         "v2 m P Δs Δt", "v2 = Δs : Δt + P Δt ^ 2 : m : Δs : 2", "v2 m Δs Δt W", "44", "",
         "v2 m P Δs Δv", "v2 = Δv : 2 ± √(P Δs : m : Δv)", "v2 m P Δs {v}", "15", "",
         "v2 m P Δs {v}", "v2 = {v} + P Δs : m : {v} ^ 2 : 2", "v2 m P Δt {v}", "22", "",
         "v2 m P Δs W", "v2 = P Δs : W + W ^ 2 : m : P : Δs : 2", "v2 F m P W", "30", "",
         "v2 m P Δt v1", "v2 = √(v1 ^ 2 + 2 P Δt : m)", "v2 m v1 W", "44", "",
         "v2 m P Δt Δv", "v2 = P Δt : m : Δv + Δv : 2", "v2 m P Δt {v}", "15", "",
         "v2 m P Δt {v}", "v2 = {v} + P Δt : m : {v} : 2", "v2 F m Δt {v}", "61", "",
         "v2 m Δs Δt W", "v2 = Δs : Δt + Δt W : m : Δs : 2", "v2 F m Δs Δt", "30", "",
         "v2 m v1 W", "v2 = √(v1 ^ 2 + 2 W : m)", "v2 F m Δs v1", "30", "",
         "v2 m Δv W", "v2 = W : m : Δv + Δv : 2", "v2 F m Δs Δv", "30", "",
         "v2 m {v} W", "v2 = {v} + W : m : {v} : 2", "v2 F m Δs {v}", "30", "",
         "v2 P Δs v1 W", "v2 = 2 P Δs : W - v1", "v2 Δs Δt v1", "43", "",
         "v2 P Δs Δv W", "v2 = P Δs : W + Δv : 2", "v2 F P Δv", "30", "",
         "v2 Δs Δt v1", "v2 = 2 Δs : Δt - v1", "v2 v1 {v}", "20", "",
         "v2 Δs Δt Δv", "v2 = Δs : Δt + Δv : 2", "v2 Δv {v}", "20", "",
         "v2 v1 Δv", "v2 = v1 + Δv", "", "9", "3",
         "v2 v1 {v}", "v2 = 2 {v} - v1", "", "12", "3",
         "v2 Δv {v}", "v2 = {v} + Δv : 2", "v2 v1 Δv", "11", "3"];
          CAI = AA[0];
        } // v2
        if (AA[0] == FAB[219])
        {
          FAC = [
         "vx2 v2", "vx2 = v2", "", "0", "",
         "vx2 v2 θ", "vx2 = v2 cos(θ)", "", "0", "",
         "vx2 vy2 θ", "vx2 = vy2 : tan(θ)", "", "0", "",
         "vx2 vz2 ϕ", "vx2 = vz2 tan(ϕ)", "", "0", "",
         "vx2 v2 vy2", "vx2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vx2 v2 vz2", "vx2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vx2 v2 θ ϕ", "vx2 = v2 cos(θ) sin(ϕ)", "", "0", "",
         "vx2 vy2 θ ϕ", "vx2 = vy2 sin(ϕ) : tan(θ)", "", "0", "",
         "vx2 v2 vy2 vz2", "vx2 = √(v2 ^ 2 - vy2 ^ 2 - vz2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vx2
        if (AA[0] == FAB[222])
        {
          FAC = [
         "vy2 v2", "vy2 = v2", "", "0", "",
         "vy2 v2 θ", "vy2 = v2 sin(θ)", "", "0", "",
         "vy2 vx2 θ", "vy2 = vx2 tan(θ)", "", "0", "",
         "vy2 vz2 θ", "vy2 = vz2 tan(θ)", "", "0", "",
         "vy2 v2 vx2", "vy2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vy2 v2 vz2", "vy2 = √(v2 ^ 2 - vz2 ^ 2)", "", "0", "",
         "vy2 vx2 θ ϕ", "vy2 = vx2 tan(θ) : sin(ϕ)", "", "0", "",
         "vy2 vz2 θ ϕ", "vy2 = vz2 tan(θ) : cos(ϕ)", "", "0", "",
         "vy2 v2 vx2 vz2", "vy2 = √(v2 ^ 2 - vx2 ^ 2 - vz2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vy2
        if (AA[0] == FAB[225])
        {
          FAC = [
         "vz2 v2", "vz2 = v2", "", "0", "",
         "vz2 v2 θ", "vz2 = v2 cos(θ)", "", "0", "",
         "vz2 vx2 ϕ", "vz2 = vx2 : tan(ϕ)", "", "0", "",
         "vz2 vy2 θ", "vz2 = vy2 : tan(θ)", "", "0", "",
         "vz2 v2 vx2", "vz2 = √(v2 ^ 2 - vx2 ^ 2)", "", "0", "",
         "vz2 v2 vy2", "vz2 = √(v2 ^ 2 - vy2 ^ 2)", "", "0", "",
         "vz2 vy2 θ ϕ", "vz2 = vy2 cos(ϕ) : tan(θ)", "", "0", "",
         "vz2 v2 θ ϕ", "vz2 = v2 cos(θ) cos(ϕ)", "", "0", "",
         "vz2 v2 vx2 vy2", "vz2 = √(v2 ^ 2 - vx2 ^ 2 - vy2 ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // vz2
        if (AA[0] == FAB[228])
        {
          FAC = [
         "Δv a F k P", "Δv = -a F ^ 2 : k : P", "Δv a F k {v}", "62", "",
         "Δv a F k v1", "Δv = -v1 ± √(v1 ^ 2 - 2 a F : k)", "Δv a Δs v1", "59", "",
         "Δv a F k v2", "Δv = v2 ± √(v2 ^ 2 + 2 a F : k)", "Δv a Δs v2", "59", "",
         "Δv a F k {v}", "Δv = -a F : k : {v}", "Δv a Δs {v}", "59", "",
         "Δv a F P Δs", "Δv = a F Δs : P", "Δv a P W", "29", "",
         "Δv a F v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : F)", "Δv a Δs v1", "31", "",
         "Δv a F v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : F)", "Δv a Δs v2", "31", "",
         "Δv a F {v} W", "Δv = a W : F : {v}", "Δv a Δs {v}", "31", "",
         "Δv a |Fn| μg P Δs", "Δv = a |Fn| μg Δs : P", "Δv a F P Δs", "85", "",
         "Δv a |Fn| μg v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)", "Δv a F v1 W", "85", "",
         "Δv a |Fn| μg v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)", "Δv a F v2 W", "85", "",
         "Δv a |Fn| μg {v} W", "Δv = a W : |Fn| : μg : {v}", "Δv a F {v} W", "85", "",
         "Δv a |Fn| μh P Δs", "Δv = a |Fn| μh Δs : P", "Δv a F P Δs", "88", "",
         "Δv a |Fn| μh v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)", "Δv a F v1 W", "88", "",
         "Δv a |Fn| μh v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)", "Δv a F v2 W", "88", "",
         "Δv a |Fn| μh {v} W", "Δv = a W : |Fn| : μh : {v}", "Δv a F {v} W", "88", "",
         "Δv a |Fn| μr P Δs", "Δv = a |Fn| μr Δs : P", "Δv a F P Δs", "91", "",
         "Δv a |Fn| μr v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)", "Δv a F v1 W", "91", "",
         "Δv a |Fn| μr v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)", "Δv a F v2 W", "91", "",
         "Δv a |Fn| μr {v} W", "Δv = a W : |Fn| : μr : {v}", "Δv a F {v} W", "91", "",
         "Δv a k m P", "Δv = -a ^ 3 m ^ 2 : k : P", "Δv a F k P", "26", "",
         "Δv a k m v1", "Δv = -v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)", "Δv a F k v1", "26", "",
         "Δv a k m v2", "Δv = v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)", "Δv a F k v2", "26", "",
         "Δv a k m {v}", "Δv = -(a ^ 2) m : k : {v}", "Δv a F k {v}", "26", "",
         "Δv a k P Δs", "Δv = -a k Δs ^ 2 : P", "Δv a F k P", "57", "",
         "Δv a k P {v}", "Δv = -a P : k : {v} ^ 2", "Δv a F k {v}", "61", "",
         "Δv a k v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 a √(-W : k))", "Δv a F k v1", "75", "",
         "Δv a k v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 a √(-W : k))", "Δv a F k v2", "75", "",
         "Δv a k {v} W", "Δv = a √(-W : k) : {v}", "Δv a F k {v}", "75", "",
         "Δv a m P Δs", "Δv = a ^ 2 m Δs : P", "Δv a F P Δs", "26", "",
         "Δv a m P v1", "Δv = 2 (P : a : m - v1)", "Δv F P v1", "26", "",
         "Δv a m P v2", "Δv = 2 (v2 - P : a : m)", "Δv F P v2", "26", "",
         "Δv a P W", "Δv = a W : P", "Δv a Δt", "43", "",
         "Δv a Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 a Δs)", "Δv Δs Δt v1", "25", "",
         "Δv a Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 a Δs)", "Δv Δs Δt v2", "25", "",
         "Δv a Δs {v}", "Δv = a Δs : {v}", "Δv a Δt", "22", "",
         "Δv a Δt", "Δv = a Δt", "", "24", "",
         "Δv F k m P", "Δv = -F ^ 3 : k : P : m", "Δv F k m {v}", "62", "",
         "Δv F k m v1", "Δv = -v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)", "Δv a F k v1", "27", "",
         "Δv F k m v2", "Δv = v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)", "Δv a F k v2", "27", "",
         "Δv F k m {v}", "Δv = -(F ^ 2) : k : m : {v}", "Δv a F k {v}", "27", "",
         "Δv F k Δt v1", "Δv = -2 (F : k : Δt + v1)", "Δv Δs Δt v1", "59", "",
         "Δv F k Δt v2", "Δv = 2 (v2 + F : k : Δt)", "Δv Δs Δt v2", "59", "",
         "Δv F m P Δs", "Δv = F ^ 2 Δs : m : P", "Δv a m P Δs", "27", "",
         "Δv F m P W", "Δv = F W : m : P", "Δv F m P Δs", "31", "",
         "Δv F m Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 F Δs : m)", "Δv a Δs v1", "27", "",
         "Δv F m Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 F Δs : m)", "Δv a Δs v2", "27", "",
         "Δv F m Δs {v}", "Δv = F Δs : m : {v}", "Δv a Δs {v}", "27", "",
         "Δv F m Δt", "Δv = F Δt : m", "Δv a Δt", "27", "",
         "Δv F P v1", "Δv = 2 (P : F - v1)", "Δv v1 {v}", "62", "",
         "Δv F P v2", "Δv = 2 (v2 - P : F)", "Δv v2 {v}", "62", "",
         "Δv F Δt v1 W", "Δv = 2 (W : F : Δt - v1)", "Δv Δs Δt v1", "31", "",
         "Δv F Δt v2 W", "Δv = 2 (v2 - W : F : Δt)", "Δv Δs Δt v2", "31", "",
         "Δv |Fn| m μg P Δs", "Δv = (|Fn| μg) ^ 2 Δs : m : P", "Δv F m P Δs", "85", "",
         "Δv |Fn| m μg P W", "Δv = |Fn| μg W : m : P", "Δv F m P W", "85", "",
         "Δv |Fn| m μg Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)", "Δv F m Δs v1", "85", "",
         "Δv |Fn| m μg Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)", "Δv F m Δs v2", "85", "",
         "Δv |Fn| m μg Δs {v}", "Δv = |Fn| μg Δs  :  m : {v}", "Δv F m Δs {v}", "85", "",
         "Δv |Fn| m μg Δt", "Δv = |Fn| μg Δt : m", "Δv F m Δt", "85", "",
         "Δv |Fn| m μh P Δs", "Δv = (|Fn| μh) ^ 2 Δs : m : P", "Δv F m P Δs", "88", "",
         "Δv |Fn| m μh P W", "Δv = |Fn| μh W : m : P", "Δv F m P W", "88", "",
         "Δv |Fn| m μh Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)", "Δv F m Δs v1", "88", "",
         "Δv |Fn| m μh Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)", "Δv F m Δs v2", "88", "",
         "Δv |Fn| m μh Δs {v}", "Δv = |Fn| μh Δs  :  m : {v}", "Δv F m Δs {v}", "88", "",
         "Δv |Fn| m μh Δt", "Δv = |Fn| μh Δt : m", "Δv F m Δt", "88", "",
         "Δv |Fn| m μr P Δs", "Δv = (|Fn| μr) ^ 2 Δs : m : P", "Δv F m P Δs", "91", "",
         "Δv |Fn| m μr P W", "Δv = |Fn| μr W : m : P", "Δv F m P W", "91", "",
         "Δv |Fn| m μr Δs v1", "Δv = -v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)", "Δv F m Δs v1", "91", "",
         "Δv |Fn| m μr Δs v2", "Δv = v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)", "Δv F m Δs v2", "91", "",
         "Δv |Fn| m μr Δs {v}", "Δv = |Fn| μr Δs  :  m : {v}", "Δv F m Δs {v}", "91", "",
         "Δv |Fn| m μr Δt", "Δv = |Fn| μr Δt : m", "Δv F m Δt", "91", "",
         "Δv |Fn| μg P v1", "Δv = 2 (P : |Fn| : μg - v1)", "Δv F P v1", "85", "",
         "Δv |Fn| μg P v2", "Δv = 2 (v2 - P : |Fn| : μg)", "Δv F P v2", "85", "",
         "Δv |Fn| μg Δt v1 W", "Δv = 2 (W : |Fn| : μg : Δt - v1)", "Δv F Δt v1 W", "85", "",
         "Δv |Fn| μg Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μg : Δt)", "Δv F Δt v2 W", "85", "",
         "Δv |Fn| μh P v1", "Δv = 2 (P : |Fn| : μh - v1)", "Δv F P v1", "88", "",
         "Δv |Fn| μh P v2", "Δv = 2 (v2 - P : |Fn| : μh)", "Δv F P v2", "88", "",
         "Δv |Fn| μh Δt v1 W", "Δv = 2 (W : |Fn| : μh : Δt - v1)", "Δv F Δt v1 W", "88", "",
         "Δv |Fn| μh Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μh : Δt)", "Δv F Δt v2 W", "88", "",
         "Δv |Fn| μr P v1", "Δv = 2 (P : |Fn| : μr - v1)", "Δv F P v1", "91", "",
         "Δv |Fn| μr P v2", "Δv = 2 (v2 - P : |Fn| : μr)", "Δv F P v2", "91", "",
         "Δv |Fn| μr Δt v1 W", "Δv = 2 (W : |Fn| : μr : Δt - v1)", "Δv F Δt v1 W", "91", "",
         "Δv |Fn| μr Δt v2 W", "Δv = 2 (v2 - W : |Fn| : μr : Δt)", "Δv F Δt v2 W", "91", "",
         "Δv k m P Δs", "Δv = -k ^ 2 Δs ^ 3 : m : P", "Δv F k m P", "57", "",
         "Δv k m P Δt", "Δv = √(-k P Δt ^ 3) : m", "Δv k m Δt W", "44", "",
         "Δv k m P {v}", "Δv = -(P ^ 2) : k : m : {v} ^ 3", "Δv F k m {v}", "61", "",
         "Δv k m P W", "Δv = √(-k W ^ 3) : m : P", "Δv k m Δt W", "43", "",
         "Δv k m Δs Δt", "Δv = -k Δs Δt : m", "Δv F m  Δt", "57", "",
         "Δv k m Δs v1", "Δv = -v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)", "Δv F k m v1", "57", "",
         "Δv k m Δs v2", "Δv = v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)", "Δv F k m v2", "57", "",
         "Δv k m Δs {v}", "Δv = -k Δs ^ 2 : m : {v}", "Δv F k m {v}", "57", "",
         "Δv k m Δt v1", "Δv = -v1 : (1 : 2 + m : k : Δt ^ 2)", "Δv k Δt v1 W", "67", "",
         "Δv k m Δt v2", "Δv = v2 : (1 : 2 - m : k : Δt ^ 2)", "Δv k Δt v2 W", "67", "",
         "Δv k m Δt {v}", "Δv = -k Δt ^ 2 {v} : m", "Δv k m Δs {v}", "21", "",
         "Δv k m Δt W", "Δv = Δt √(-k W) : m", "Δv k m Δs Δt", "78", "",
         "Δv k P Δs v1", "Δv = -2 (P : k : Δs + v1)", "Δv F P v1", "57", "",
         "Δv k P Δs v2", "Δv = 2 (v2 + P : k : Δs)", "Δv F P v2", "57", "",
         "Δv k P Δt v1", "Δv = 2 (√(-P : k : Δt) - v1)", "Δv k Δt v1 W", "44", "",
         "Δv k P Δt v2", "Δv = 2 (v2 - √(-P : k : Δt))", "Δv k Δt v2 W", "44", "",
         "Δv k P v1 W", "Δv = 2 (P √(-1 : k : W) - v1)", "Δv k Δt v1 W", "43", "",
         "Δv k P v2 W", "Δv = 2 (v2 - P √(-1 : k : W))", "Δv k Δt v2 W", "43", "",
         "Δv k Δt v1 W", "Δv = 2 (√(-W : k) : Δt - v1)", "Δv Δs Δt v1", "78", "",
         "Δv k Δt v2 W", "Δv = 2 (v2 - √(-W : k) : Δt)", "Δv Δs Δt v2", "78", "",
         "Δv m P Δs Δt", "Δv = P Δt ^ 2 : m : Δs", "Δv m Δs Δt W", "44", "",
         "Δv m P Δs {v}", "Δv = P Δs : m : {v} ^ 2", "Δv m P Δt {v}", "22", "",
         "Δv m P Δs W", "Δv = W ^ 2 : m : P : Δs", "Δv m Δs Δt W", "43", "",
         "Δv m P Δt v1", "Δv = -v1 ± √(v1 ^ 2 + 2 P Δt : m)", "Δv m v1 W", "44", "",
         "Δv m P Δt v2", "Δv = v2 ± √(v2 ^ 2 - 2 P Δt : m)", "Δv m v2 W", "44", "",
         "Δv m P Δt {v}", "Δv = P Δt : m : {v}", "Δv m {v} W", "44", "",
         "Δv m Δs Δt W", "Δv = W Δt : m : Δs", "Δv F m Δt", "30", "",
         "Δv m v1 W", "Δv = -v1 ± √(v1 ^ 2 + 2 W : m)", "Δv a F v1 W", "27", "",
         "Δv m v2 W", "Δv = v2 ± √(v2 ^ 2 - 2 W : m)", "Δv a F v2 W", "27", "",
         "Δv m {v} W", "Δv = W : m : {v}", "Δv a F {v} W", "27", "",
         "Δv P Δs v1 W", "Δv = 2 (P Δs : W - v1)", "Δv Δs Δt v1", "43", "",
         "Δv P Δs v2 W", "Δv = 2 (v2 - P Δs : W)", "Δv Δs Δt v2", "43", "",
         "Δv Δs Δt v1", "Δv = 2 (Δs : Δt - v1)", "Δv v1 {v}", "20", "",
         "Δv Δs Δt v2", "Δv = 2 (v2 - Δs : Δt)", "Δv v2 {v}", "20", "",
         "Δv v1 v2", "Δv = v2 - v1", "", "7", "3",
         "Δv v1 {v}", "Δv = 2 ({v} - v1)", "Δv v1 v2", "12", "3",
         "Δv v2 {v}", "Δv = 2 (v2 - {v})", "Δv v1 v2", "11", "3",
         "Δv Δvx", "Δv = Δvx", "", "0", "",
         "Δv Δvy", "Δv = Δvy", "", "0", "",
         "Δv Δvz", "Δv = Δvz", "", "0", "",
         "Δv Δvx θ", "Δv = Δvx : cos(θ)", "", "0", "",
         "Δv Δvy θ", "Δv = Δvy : sin(θ)", "", "0", "",
         "Δv Δvz θ", "Δv = Δvz : cos(θ)", "", "0", "",
         "Δv Δvx θ ϕ", "Δv = Δvx : cos(θ) : sin(ϕ))", "", "0", "",
         "Δv Δvz θ ϕ", "Δv = Δvz : cos(θ) : cos(ϕ)", "", "0", "",
         "Δv Δvx Δvy", "Δv = √(Δvx ^ 2 + Δvy ^ 2)", "", "0", "",
         "Δv Δvx Δvz", "Δv = √(Δvx ^ 2 + Δvz ^ 2)", "", "0", "",
         "Δv Δvy Δvz", "Δv = √(Δvy ^ 2 + Δvz ^ 2)", "", "0", "",
         "Δv Δvx Δvy Δvz", "Δv = √(Δvx ^ 2 + Δvy ^ 2 + Δvz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δv
        if (AA[0] == FAB[231])
        {
          FAC = [
         "Δvx Δv", "Δvx = Δv", "", "0", "",
         "Δvx Δv θ", "Δvx = Δv cos(θ)", "", "0", "",
         "Δvx Δvy θ", "Δvx = Δvy : tan(θ)", "", "0", "",
         "Δvx Δvz ϕ", "Δvx = Δvz tan(ϕ)", "", "0", "",
         "Δvx Δv Δvy", "Δvx = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvx Δv Δvz", "Δvx = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvx Δv θ ϕ", "Δvx = Δv cos(θ) sin(ϕ)", "", "0", "",
         "Δvx Δvy θ ϕ", "Δvx = Δvy sin(ϕ) : tan(θ)", "", "0", "",
         "Δvx Δv Δvy Δvz", "Δvx = √(Δv ^ 2 - Δvy ^ 2 - Δvz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δvx
        if (AA[0] == FAB[234])
        {
          FAC = [
         "Δvy Δv", "Δvy = Δv", "", "0", "",
         "Δvy Δv θ", "Δvy = Δv sin(θ)", "", "0", "",
         "Δvy Δvx θ", "Δvy = Δvx tan(θ)", "", "0", "",
         "Δvy Δvz θ", "Δvy = Δvz tan(θ)", "", "0", "",
         "Δvy Δv Δvx", "Δvy = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvy Δv Δvz", "Δvy = √(Δv ^ 2 - Δvz ^ 2)", "", "0", "",
         "Δvy Δvx θ ϕ", "Δvy = Δvx tan(θ) : sin(ϕ)", "", "0", "",
         "Δvy Δvz θ ϕ", "Δvy = Δvz tan(θ) : cos(ϕ)", "", "0", "",
         "Δvy Δv Δvx Δvz", "Δvy = √(Δv ^ 2 - Δvx ^ 2 - Δvz ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δvy
        if (AA[0] == FAB[237])
        {
          FAC = [
         "Δvz Δv", "Δvz = Δv", "", "0", "",
         "Δvz Δv θ", "Δvz = Δv cos(θ)", "", "0", "",
         "Δvz Δvx ϕ", "Δvz = Δvx : tan(ϕ)", "", "0", "",
         "Δvz Δvy θ", "Δvz = Δvy : tan(θ)", "", "0", "",
         "Δvz Δv Δvx", "Δvz = √(Δv ^ 2 - Δvx ^ 2)", "", "0", "",
         "Δvz Δv Δvy", "Δvz = √(Δv ^ 2 - Δvy ^ 2)", "", "0", "",
         "Δvz Δvy θ ϕ", "Δvz = Δvy cos(ϕ) : tan(θ)", "", "0", "",
         "Δvz Δv θ ϕ", "Δvz = Δv cos(θ) cos(ϕ)", "", "0", "",
         "Δvz Δv Δvx Δvy", "Δvz = √(Δv ^ 2 - Δvx ^ 2 - Δvy ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // Δvz
        if (AA[0] == FAB[240])
        {
          FAC = [
         "{v} a F k v1", "{v} = (v1 ± √(v1 ^ 2 - 2 a F : k)) : 2", "{v} a Δs v1", "59", "",
         "{v} a F k v2", "{v} = (v2 ± √(v2 ^ 2 + 2 a F : k)) : 2", "{v} a Δs v2", "59", "",
         "{v} a F k Δv", "{v} = -a F : k : Δv", "{v} F k Δt", "25", "",
         "{v} a F v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : F)) : 2", "{v} m v1 W", "28", "",
         "{v} a F v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : F)) : 2", "{v} m v2 W", "28", "",
         "{v} a F Δv W", "{v} = a W : F : Δv", "{v} a Δs Δv", "31", "",
         "{v} a |Fn| μg v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μg)) : 2", "{v} a F v1 W", "85", "",
         "{v} a |Fn| μg v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μg)) : 2", "{v} a F v2 W", "85", "",
         "{v} a |Fn| μg Δv W", "{v} = a W : |Fn| : μg : Δv", "{v} a F Δv W", "85", "",
         "{v} a |Fn| μh v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μh)) : 2", "{v} a F v1 W", "88", "",
         "{v} a |Fn| μh v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μh)) : 2", "{v} a f v2 W", "88", "",
         "{v} a |Fn| μh Δv W", "{v} = a W : |Fn| : μh : Δv", "{v} a F Δv W", "88", "",
         "{v} a |Fn| μr v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a W : |Fn| : μr)) : 2", "{v} a F v1 W", "91", "",
         "{v} a |Fn| μr v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a W : |Fn| : μr)) : 2", "{v} a F v2 W", "91", "",
         "{v} a |Fn| μr Δv W", "{v} = a W : |Fn| : μr : Δv", "{v} a F Δv W", "91", "",
         "{v} a k m Δt", "{v} = -a m : k : Δt", "{v} F k Δt", "26", "",
         "{v} a k m v1", "{v} = (v1 ± √(v1 ^ 2 - 2 a ^ 2 m : k)) : 2", "{v} a F k v1", "26", "",
         "{v} a k m v2", "{v} = (v2 ± √(v2 ^ 2 + 2 a ^ 2 m : k)) : 2", "{v} a F k v2", "26", "",
         "{v} a k m Δv", "{v} = -(a ^ 2) m : k : Δv", "{v} a F k Δv", "26", "",
         "{v} a k P Δv", "{v} = √(-a P : k : Δv)", "{v} k P Δt", "25", "",
         "{v} a k v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 a √(-W : k))) : 2", "{v} a F k v1", "75", "",
         "{v} a k v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 a √(-W : k))) : 2", "{v} a F k v2", "75", "",
         "{v} a k Δv W", "{v} = a √(-W : k) : Δv", "{v} a F k Δv", "75", "",
         "{v} a m P", "{v} = P : a : m", "{v} F P", "26", "",
         "{v} a m Δt W", "{v} = W : a : m : Δt", "{v} F Δt W", "26", "",
         "{v} a P v1 W", "{v} = v1 + a W : P : 2", "{v} a Δt v1", "43", "",
         "{v} a P v2 W", "{v} = v2 - a W : P : 2", "{v} a Δt v2", "43", "",
         "{v} a Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 a Δs)) : 2", "{v} a Δt v1", "22", "",
         "{v} a Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 a Δs)) : 2", "{v} a Δt v2", "22", "",
         "{v} a Δs Δv", "{v} = a Δs : Δv", "{v} Δs Δt", "25", "",
         "{v} a Δt v1", "{v} = v1 + a Δt : 2", "{v} v1 Δv", "24", "",
         "{v} a Δt v2", "{v} = v2 - a Δt : 2", "{v} v2 Δv", "24", "",
         "{v} F k m v1", "{v} = (v1 ± √(v1 ^ 2 - 2 F ^ 2 : k : m)) : 2", "{v} a F k v1", "27", "",
         "{v} F k m v2", "{v} = (v2 ± √(v2 ^ 2 + 2 F ^ 2 : k : m)) : 2", "{v} a F k v2", "27", "",
         "{v} F k m Δv", "{v} = -(F ^ 2) : k : m : Δv", "{v} a F k Δv", "27", "",
         "{v} F k Δt", "{v} = -F : k : Δt", "{v} Δs Δt", "59", "",
         "{v} F m Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 F Δs : m)) : 2", "{v} a Δs v1", "27", "",
         "{v} F m Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 F Δs : m)) : 2", "{v} a Δs v2", "27", "",
         "{v} F m Δs Δv", "{v} = F Δs : m : Δv", "{v} a Δs Δv", "27", "",
         "{v} F m Δt v1", "{v} = v1 + F Δt : m : 2", "{v} a Δt v1", "27", "",
         "{v} F m Δt v2", "{v} = v2 - F Δt : m : 2", "{v} a Δt v2", "27", "",
         "{v} F P", "{v} = P : F", "{v} F Δt W", "43", "",
         "{v} F Δt W", "{v} = W : F : Δt", "{v} Δs Δt", "31", "",
         "{v} |Fn| m μg Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μg Δs : m)) : 2", "{v} F m  Δs v1", "85", "",
         "{v} |Fn| m μg Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μg Δs : m)) : 2", "{v} F m Δs v2", "85", "",
         "{v} |Fn| m μg Δs Δv", "{v} = |Fn| μg Δs : m : Δv", "{v} F m Δs Δv", "85", "",
         "{v} |Fn| m μg Δt v1", "{v} = v1 + |Fn| μg Δt : m : 2", "{v} F m Δt v1", "85", "",
         "{v} |Fn| m μg Δt v2", "{v} = v2 - |Fn| μg Δt : m : 2", "{v} F m Δt v2", "85", "",
         "{v} |Fn| m μh Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μh Δs : m)) : 2", "{v} F m Δs v1", "88", "",
         "{v} |Fn| m μh Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μh Δs : m)) : 2", "{v} F m Δs v2", "88", "",
         "{v} |Fn| m μh Δs Δv", "{v} = |Fn| μh Δs : m : Δv", "{v} F m Δs Δv", "88", "",
         "{v} |Fn| m μh Δt v1", "{v} = v1 + |Fn| μh Δt : m : 2", "{v} F m Δt v1", "88", "",
         "{v} |Fn| m μh Δt v2", "{v} = v2 - |Fn| μh Δt : m : 2", "{v} F m Δt v2", "88", "",
         "{v} |Fn| m μr Δs v1", "{v} = (v1 ± √(v1 ^ 2 + 2 |Fn| μr Δs : m)) : 2", "{v} F m Δs v1", "91", "",
         "{v} |Fn| m μr Δs v2", "{v} = (v2 ± √(v2 ^ 2 - 2 |Fn| μr Δs : m)) : 2", "{v} F m Δs v2", "91", "",
         "{v} |Fn| m μr Δs Δv", "{v} = |Fn| μr Δs : m : Δv", "{v} F m Δs Δv", "91", "",
         "{v} |Fn| m μr Δt v1", "{v} = v1 + |Fn| μr Δt : m : 2", "{v} F m Δt v1", "91", "",
         "{v} |Fn| m μr Δt v2", "{v} = v2 - |Fn| μr Δt : m : 2", "{v} F m Δt v2", "91", "",
         "{v} |Fn| μg P", "{v} = P : |Fn| : μg", "{v} F P", "85", "",
         "{v} |Fn| μg Δt W", "{v} = W : |Fn| : μg : Δt", "{v} F Δt W", "85", "",
         "{v} |Fn| μh P", "{v} = P : |Fn| : μh", "{v} F P", "88", "",
         "{v} |Fn| μh Δt W", "{v} = W : |Fn| : μh : Δt", "{v} F Δt W", "88", "",
         "{v} |Fn| μr P", "{v} = P : |Fn| : μr", "{v} F P", "91", "",
         "{v} |Fn| μr Δt W", "{v} = W : |Fn| : μr : Δt", "{v} F Δt W", "91", "",
         "{v} k m P Δv", "{v} = √(-(P ^ 2) : k : m : Δv ' 3)", "{v} k P W", "63", "",
         "{v} k m Δs v1", "{v} = (v1 ± √(v1 ^ 2 - 2 k Δs ^ 2 : m)) : 2", "{v} F k m v1", "57", "",
         "{v} k m Δs v2", "{v} = (v2 ± √(v2 ^ 2 + 2 k Δs ^ 2 : m)) : 2", "{v} F k m v2", "57", "",
         "{v} k m Δs Δv", "{v} = -k Δs ^ 2 : m : Δv", "{v} F k m Δv", "57", "",
         "{v} k m Δt v1", "{v} = v1 : (1 + k Δt ^ 2 : m : 2)", "{v} k m Δt Δv", "16", "",
         "{v} k m Δt v2", "{v} = v2 : (1 - k Δt ^ 2 : m : 2)", "{v} k m Δt Δv", "13", "",
         "{v} k m Δt Δv", "{v} = -m Δv : k : Δt ^ 2", "{v} a k m Δt", "23", "",
         "{v} k P Δs", "{v} = -P : k : Δs", "{v} F P", "57", "",
         "{v} k P Δt", "{v} = √(-P : k : Δt)", "{v} k P Δs", "21", "",
         "{v} k P W", "{v} = P √(-1 : k : W)", "{v} k P Δt", "43", "",
         "{v} k Δt W", "{v} = √(-W : k) : Δt", "{v} k P Δt", "42", "",
         "{v} m P Δs Δv", "{v} = √(P Δs : m : Δv)", "{v} m P Δt Δv", "22", "",
         "{v} m P Δt v1", "{v} = (v1 ± √(v1 ^ 2 + 2 P Δt : m)) : 2", "{v} m v1 W", "44", "",
         "{v} m P Δt v2", "{v} = (v2 ± √(v2 ^ 2 - 2 P Δt : m)) : 2", "{v} m v2 W", "44", "",
         "{v} m P Δt Δv", "{v} = P Δt : m : Δv", "{v} m Δv W", "44", "",
         "{v} m v1 W", "{v} = (v1 ± √(v1 ^ 2 + 2 W : m)) : 2", "{v} F m Δs v1", "30", "",
         "{v} m v2 W", "{v} = (v2 ± √(v2 ^ 2 - 2 W : m)) : 2", "{v} F m Δs v2", "30", "",
         "{v} m Δv W", "{v} = W : m : Δv", "{v} a m Δt W", "23", "",
         "{v} P Δs W", "{v} = P Δs : W", "{v} Δs Δt", "43", "",
         "{v} Δs Δt", "{v} = Δs : Δt", "", "20", "",
         "{v} v1 v2", "{v} = (v1 + v2) : 2", "", "10", "3",
         "{v} v1 Δv", "{v} = v1 + Δv : 2", "{v} v1 v2", "9", "3",
         "{v} v2 Δv", "{v} = v2 - Δv : 2", "{v} v1 v2", "8", "3",
         "{v} {vx}", "{v} = {vx}", "", "0", "",
         "{v} {vy}", "{v} = {vy}", "", "0", "",
         "{v} {vz}", "{v} = {vz}", "", "0", "",
         "{v} {vx} θ", "{v} = {vx} : cos(θ)", "", "0", "",
         "{v} {vy} θ", "{v} = {vy} : sin(θ)", "", "0", "",
         "{v} {vz} θ", "{v} = {vz} : cos(θ)", "", "0", "",
         "{v} {vx} θ ϕ", "{v} = {vx} : cos(θ) : sin(ϕ)", "", "0", "",
         "{v} {vz} θ ϕ", "{v} = {vz} : cos(θ) : cos(ϕ)", "", "0", "",
         "{v} {vx} {vy}", "{v} = √({vx} ^ 2 + {vy} ^ 2)", "", "0", "",
         "{v} {vx} {vz}", "{v} = √({vx} ^ 2 + {vz} ^ 2)", "", "0", "",
         "{v} {vy} {vz}", "{v} = √({vy} ^ 2 + {vz} ^ 2)", "", "0", "",
         "{v} {vx} {vy} {vz}", "{v} = √({vx} ^ 2 + {vy} ^ 2 + {vz} ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // {v}
        if (AA[0] == FAB[243])
        {
          FAC = [
         "{vx} {v}", "{vx} = {v}", "", "0", "",
         "{vx} {v} θ", "{vx} = {v} cos(θ)", "", "0", "",
         "{vx} {vy} θ", "{vx} = {vy} : tan(θ)", "", "0", "",
         "{vx} {vz} ϕ", "{vx} = {vz} tan(ϕ)", "", "0", "",
         "{vx} {v} {vy}", "{vx} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vx} {v} {vz}", "{vx} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vx} {v} θ ϕ", "{vx} = {v} cos(θ) sin(ϕ)", "", "0", "",
         "{vx} {vy} θ ϕ", "{vx} = {vy} sin(ϕ) : tan(θ)", "", "0", "",
         "{vx} {v} {vy} {vz}", "{vx} = √({v} ^ 2 - {vy} ^ 2 - {vz} ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // {vx}
        if (AA[0] == FAB[246])
        {
          FAC = [
         "{vy} {v}", "{vy} = {v}", "", "0", "",
         "{vy} {v} θ", "{vy} = {v} sin(θ)", "", "0", "",
         "{vy} {vx} θ", "{vy} = {vx} tan(θ)", "", "0", "",
         "{vy} {vz} θ", "{vy} = {vz} tan(θ)", "", "0", "",
         "{vy} {v} {vx}", "{vy} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vy} {v} {vz}", "{vy} = √({v} ^ 2 - {vz} ^ 2)", "", "0", "",
         "{vy} {vx} θ ϕ", "{vy} = {vx} tan(θ) : sin(ϕ)", "", "0", "",
         "{vy} {vz} θ ϕ", "{vy} = {vz} tan(θ) : cos(ϕ)", "", "0", "",
         "{vy} {v} {vx} {vz}", "{vy} = √({v} ^ 2 - {vx} ^ 2 - {vz} ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // {vy}
        if (AA[0] == FAB[249])
        {
          FAC = [
         "{vz} {v}", "{vz} = {v}", "", "0", "",
         "{vz} {v} θ", "{vz} = {v} cos(θ)", "", "0", "",
         "{vz} {vx} ϕ", "{vz} = {vx} : tan(ϕ)", "", "0", "",
         "{vz} {vy} θ", "{vz} = {vy} : tan(θ)", "", "0", "",
         "{vz} {v} {vx}", "{vz} = √({v} ^ 2 - {vx} ^ 2)", "", "0", "",
         "{vz} {v} {vy}", "{vz} = √({v} ^ 2 - {vy} ^ 2)", "", "0", "",
         "{vz} {vy} θ ϕ", "{vz} = {vy} cos(ϕ) : tan(θ)", "", "0", "",
         "{vz} {v} θ ϕ", "{vz} = {v} cos(θ) cos(ϕ)", "", "0", "",
         "{vz} {v} {vx} {vy}", "{vz} = √({v} ^ 2 - {vx} ^ 2 - {vy} ^ 2)", "", "0", ""];
          CAI = AA[0];
        } // {vz}
        if (AA[0] == FAB[252])
        {
          FAC = [
         "W a F P v1", "W = 2 P (P : F - v1) : a", "W a F Δt v1", "43", "",
         "W a F P v2", "W = 2 P (v2 - P : F) : a", "W a F Δt v2", "43", "",
         "W a F Δt v1", "W = F Δt (v1 + a Δt : 2)", "W F Δt v1 Δv", "24", "",
         "W a F Δt v2", "W = F Δt (v2 - a Δt : 2)", "W F Δt v2 Δv", "24", "",
         "W a F v1 v2", "W = F (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F Δv {v}", "19", "",
         "W a F v1 Δv", "W = F Δv (v1 + Δv : 2) : a", "W a F Δv {v}", "18", "",
         "W a F v1 {v}", "W = 2 F {v} ({v} - v1) : a", "W a F Δv {v}", "16", "",
         "W a F v2 Δv", "W = F Δv (v2 - Δv : 2) : a", "W a F Δv {v}", "15", "",
         "W a F v2 {v}", "W = 2 F {v} (v2 - {v}) : a", "W a F Δv {v}", "13", "",
         "W a F Δv {v}", "W = F Δv {v} : a", "W F Δt {v}", "25", "",
         "W a |Fn| μg P v1", "W = 2 P (P : |Fn| : μg - v1) : a", "W a F P v1", "85", "",
         "W a |Fn| μg P v2", "W = 2 P (v2 - P : |Fn| : μg) : a", "W a F P v2", "85", "",
         "W a |Fn| μg Δt v1", "W = |Fn| μg Δt (v1 + a Δt : 2)", "W a F Δt v1", "85", "",
         "W a |Fn| μg Δt v2", "W = |Fn| μg Δt (v2 - a Δt : 2)", "W a F Δt v2", "85", "",
         "W a |Fn| μg v1 v2", "W = |Fn| μg (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "85", "",
         "W a |Fn| μg v1 Δv", "W = |Fn| μg (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "85", "",
         "W a |Fn| μg v1 {v}", "W = 2 |Fn| μg {v} ({v} - v1) : a", "W a F v1 {v}", "85", "",
         "W a |Fn| μg v2 Δv", "W = |Fn| μg (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "85", "",
         "W a |Fn| μg v2 {v}", "W = 2 |Fn| μg {v} (v2 - {v}) : a", "W a F v2 {v}", "85", "",
         "W a |Fn| μg Δv {v}", "W = |Fn| μg Δv {v} : a", "W a F Δv {v}", "85", "",
         "W a |Fn| μh P v1", "W = 2 P (P : |Fn| : μh - v1) : a", "W a F P v1", "88", "",
         "W a |Fn| μh P v2", "W = 2 P (v2 - P : |Fn| : μh) : a", "W a F P v2", "88", "",
         "W a |Fn| μh Δt v1", "W = |Fn| μh Δt (v1 + a Δt : 2)", "W a F Δt v1", "88", "",
         "W a |Fn| μh Δt v2", "W = |Fn| μh Δt (v2 - a Δt : 2)", "W a F Δt v2", "88", "",
         "W a |Fn| μh v1 v2", "W = |Fn| μh (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "88", "",
         "W a |Fn| μh v1 Δv", "W = |Fn| μh (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "88", "",
         "W a |Fn| μh v1 {v}", "W = 2 |Fn| μh {v} ({v} - v1) : a", "W a F v1 {v}", "88", "",
         "W a |Fn| μh v2 Δv", "W = |Fn| μh (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "88", "",
         "W a |Fn| μh v2 {v}", "W = 2 |Fn| μh {v} (v2 - {v}) : a", "W a F v2 {v}", "88", "",
         "W a |Fn| μh Δv {v}", "W = |Fn| μh Δv {v} : a", "W a F Δv {v}", "88", "",
         "W a |Fn| μr P v1", "W = 2 P (P : |Fn| : μr - v1) : a", "W a F P v1", "91", "",
         "W a |Fn| μr P v2", "W = 2 P (v2 - P : |Fn| : μr) : a", "W a F P v2", "91", "",
         "W a |Fn| μr Δt v1", "W = |Fn| μr Δt (v1 + a Δt : 2)", "W a F Δt v1", "91", "",
         "W a |Fn| μr Δt v2", "W = |Fn| μr Δt (v2 - a Δt : 2)", "W a F Δt v2", "91", "",
         "W a |Fn| μr v1 v2", "W = |Fn| μr (v2 ^ 2 - v1 ^ 2) : a : 2", "W a F v1 v2", "91", "",
         "W a |Fn| μr v1 Δv", "W = |Fn| μr (v1 + Δv : 2) Δv : a", "W a F v1 Δv", "91", "",
         "W a |Fn| μr v1 {v}", "W = 2 |Fn| μr {v} ({v} - v1) : a", "W a F v1 {v}", "91", "",
         "W a |Fn| μr v2 Δv", "W = |Fn| μr (v2 - Δv : 2) Δv : a", "W a F v2 Δv", "91", "",
         "W a |Fn| μr v2 {v}", "W = 2 |Fn| μr {v} (v2 - {v}) : a", "W a F v2 {v}", "91", "",
         "W a |Fn| μr Δv {v}", "W = |Fn| μr Δv {v} : a", "W a F Δv {v}", "91", "",
         "W a k m", "W = -(a m) ^ 2 : k", "W F k", "26", "",
         "W a k Δt v1", "W = -k (Δt (v1 + a Δt : 2)) ^ 2", "W k Δt v1 Δv", "24", "",
         "W a k Δt v2", "W = -k (Δt (v2 - a Δt : 2)) ^ 2", "W k Δt v2 Δv", "24", "",
         "W a k v1 v2", "W = -k ((v2 ^ 2 - v1 ^ 2) : a : 2) ^ 2", "W a k Δv {v}", "19", "",
         "W a k v1 Δv", "W = -k (Δv (v1 + Δv : 2) : a) ^ 2", "W a k Δv {v}", "18", "",
         "W a k v1 {v}", "W = -k (2 {v} ({v} - v1) : a) ^ 2", "W a k Δv {v}", "16", "",
         "W a k v2 Δv", "W = -k (Δv (v2 - Δv : 2) : a) ^ 2", "W a k Δv {v}", "15", "",
         "W a k v2 {v}", "W = -k (2 {v} (v2 - {v}) : a) ^ 2", "W a k Δv {v}", "13", "",
         "W a k Δv {v}", "W = -k (Δv {v} : a) ^ 2", "W k Δt {v}", "25", "",
         "W a m P v1", "W = 2 P (P : a : m - v1) : a", "W a F P v1", "26", "",
         "W a m P v2", "W = 2 P (v2 - P : a : m) : a", "W a F P v2", "26", "",
         "W a m Δs", "W = a m Δs", "W F Δs", "26", "",
         "W a m Δt v1", "W = a m Δt (v1 + a Δt : 2)", "W a F Δt v1", "26", "",
         "W a m Δt v2", "W = a m Δt (v2 - a Δt : 2)", "W a F Δt v2", "26", "",
         "W a m Δt {v}", "W = a m Δt {v}", "W a m Δs", "21", "",
         "W a P Δs v1", "W = P (-v1 ± √(v1 ^ 2 + 2 a Δs)) : a", "W a F P v1", "30", "",
         "W a P Δs v2", "W = P (v2 ± √(v2 ^ 2 - 2 a Δs)) : a", "W a F P v2", "30", "",
         "W a P v1 {v}", "W = 2 P ({v} - v1) : a", "W a P Δv", "16", "",
         "W a P v2 {v}", "W = 2 P (v2 - {v}) : a", "W a P Δv", "13", "",
         "W a P Δv", "W = P Δv : a", "W P Δt", "25", "",
         "W Ek1 Ek2", "W = Ek2 - Ek1", "W ΔEk", "32", "",
         "W ΔEk", "W = ΔEk", "", "32", "",
         "W Ep1 Ep2", "W = Ep1 - Ep2", "W ΔEp", "34", "",
         "W ΔEp", "W = -ΔEp", "", "34", "",
         "W F k", "W = -(F ^ 2) : k", "W F Δs", "78", "",
         "W F m P v1", "W = 2 m P (P : F - v1) : F", "W a F P v1", "27", "",
         "W F m P v2", "W = 2 m P (v2 - P : F) : F", "W a F P v2", "27", "",
         "W F m P Δv", "W = m P Δv : F", "W a P Δv", "27", "",
         "W F m Δt v1", "W = F Δt (v1 + F Δt : m : 2)", "W a F Δt v1", "27", "",
         "W F m Δt v2", "W = F Δt (v2 - F Δt : m : 2)", "W a F Δt v2", "27", "",
         "W F Δs", "W = F Δs", "", "29", "",
         "W F Δt v1 v2", "W = F Δt (v1 + v2) : 2", "W F Δt {v}", "10", "",
         "W F Δt v1 Δv", "W = F Δt (v1 + Δv : 2)", "W F Δt {v}", "18", "",
         "W F Δt v2 Δv", "W = F Δt (v2 - Δv : 2)", "W F Δt {v}", "15", "",
         "W F Δt {v}", "W = F Δt {v}", "W F Δs", "21", "",
         "W |Fn| m μg P v1", "W = 2 m P (P : |Fn| : μg - v1) : |Fn| : μg", "W F m P v1", "85", "",
         "W |Fn| m μg P v2", "W = 2 m P (v2 - P : |Fn| : μg) : |Fn| : μg", "W F m P v2", "85", "",
         "W |Fn| m μg P Δv", "W = m P Δv : |Fn| : μg", "W F m P Δv", "85", "",
         "W |Fn| m μg Δt v1", "W = |Fn| μg Δt (v1 + |Fn| μg Δt : m : 2)", "W F m Δt v1", "85", "",
         "W |Fn| m μg Δt v2", "W = |Fn| μg Δt (v2 - |Fn| μg Δt : m : 2)", "W F m Δt v2", "85", "",
         "W |Fn| m μh P v1", "W = 2 m P (P : |Fn| : μh - v1) : |Fn| : μh", "W F m P v1", "88", "",
         "W |Fn| m μh P v2", "W = 2 m P (v2 - P : |Fn| : μh) : |Fn| : μh", "W F m P v2", "88", "",
         "W |Fn| m μh P Δv", "W = m P Δv : |Fn| : μh", "W F m P Δv", "88", "",
         "W |Fn| m μh Δt v1", "W = |Fn| μh Δt (v1 + |Fn| μh Δt : m : 2)", "W F m Δt v1", "88", "",
         "W |Fn| m μh Δt v2", "W = |Fn| μh Δt (v2 - |Fn| μh Δt : m : 2)", "W F m Δt v2", "88", "",
         "W |Fn| m μr P v1", "W = 2 m P (P : |Fn| : μr - v1) : |Fn| : μr", "W F m P v1", "91", "",
         "W |Fn| m μr P v2", "W = 2 m P (v2 - P : |Fn| : μr) : |Fn| : μr", "W F m P v2", "91", "",
         "W |Fn| m μr P Δv", "W = m P Δv : |Fn| : μr", "W F m P Δv", "91", "",
         "W |Fn| m μr Δt v1", "W = |Fn| μr Δt (v1 + |Fn| μr Δt : m : 2)", "W F m Δt v1", "91", "",
         "W |Fn| m μr Δt v2", "W = |Fn| μr Δt (v2 - |Fn| μr Δt : m : 2)", "W F m Δt v2", "91", "",
         "W |Fn| μg Δs", "W = |Fn| μg Δs", "W F Δs", "85", "",
         "W |Fn| μg Δt v1 v2", "W = |Fn| μg Δt (v1 + v2) : 2", "W F Δt v1 v2", "85", "",
         "W |Fn| μg Δt v1 Δv", "W = |Fn| μg Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "85", "",
         "W |Fn| μg Δt v2 Δv", "W = |Fn| μg Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "85", "",
         "W |Fn| μg Δt {v}", "W = |Fn| μg Δt {v}", "W F Δt {v}", "85", "",
         "W |Fn| μh Δs", "W = |Fn| μh Δs", "W F Δs", "88", "",
         "W |Fn| μh Δt v1 v2", "W = |Fn| μh Δt (v1 + v2) : 2", "W F Δt v1 v2", "88", "",
         "W |Fn| μh Δt v1 Δv", "W = |Fn| μh Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "88", "",
         "W |Fn| μh Δt v2 Δv", "W = |Fn| μh Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "88", "",
         "W |Fn| μh Δt {v}", "W = |Fn| μh Δt {v}", "W F Δt {v}", "88", "",
         "W |Fn| μr Δs", "W = |Fn| μr Δs", "W F Δs", "91", "",
         "W |Fn| μr Δt v1 v2", "W = |Fn| μr Δt (v1 + v2) : 2", "W F Δt v1 v2", "91", "",
         "W |Fn| μr Δt v1 Δv", "W = |Fn| μr Δt (v1 + Δv : 2)", "W F Δt v1 Δv", "91", "",
         "W |Fn| μr Δt v2 Δv", "W = |Fn| μr Δt (v2 - Δv : 2)", "W F Δt v2 Δv", "91", "",
         "W |Fn| μr Δt {v}", "W = |Fn| μr Δt {v}", "W F Δt {v}", "91", "",
         "W k m P Δv", "W = √(-(m P Δv) ^ 2 : k ' 3)", "W k m Δt Δv", "43", "",
         "W k m Δt v1", "W = -k (2 v1 : (-k Δt : m - 2 : Δt)) ^ 2", "W k m Δt Δv", "70", "",
         "W k m Δt v2", "W = -k (2 v2 : (k Δt : m - 2 : Δt)) ^ 2", "W k m Δt Δv", "74", "",
         "W k m Δt Δv", "W = -(m Δv) ^ 2 : k : Δt ^ 2", "W a k m", "23", "",
         "W k P v1 v2", "W = -4 P ^ 2 : k : (v1 + v2) ^ 2", "W k P {v}", "10", "",
         "W k P v1 Δv", "W = -(P ^ 2) : k : (v1 + Δv : 2) ^ 2", "W k P {v}", "18", "",
         "W k P v2 Δv", "W = -(P ^ 2) : k : (v2 - Δv : 2) ^ 2", "W k P {v}", "15", "",
         "W k P {v}", "W = -(P ^ 2) : k : {v} ^ 2", "W F k", "61", "",
         "W k Δs", "W = -k Δs ^ 2", "W F Δs", "75", "",
         "W k Δt v1 v2", "W = -k (Δt (v1 + v2) : 2) ^ 2", "W k Δt {v}", "10", "",
         "W k Δt v1 Δv", "W = -k (Δt (v1 + Δv : 2)) ^ 2", "W k Δt {v}", "18", "",
         "W k Δt v2 Δv", "W = -k (Δt (v2 - Δv : 2)) ^ 2", "W k Δt {v}", "15", "",
         "W k Δt {v}", "W = -k (Δt {v}) ^ 2", "W k Δs", "21", "",
         "W m P Δs Δv", "W = √(m P Δs Δv)", "W m Δs Δt Δv", "43", "",
         "W m Δs Δt v1", "W = 2 m Δs (Δs : Δt - v1) : Δt", "W m v1 {v}", "20", "",
         "W m Δs Δt v2", "W = 2 m Δs (v2 - Δs : Δt) : Δt", "W m v2 {v}", "20", "",
         "W m Δs Δt Δv", "W = m Δs Δv : Δt", "W a m Δs", "23", "",
         "W m v1 v2", "W = m (v2 ^ 2 - v1 ^ 2) : 2", "W m Δv {v}", "19", "",
         "W m v1 Δv", "W = m (v1 + Δv : 2) Δv", "W m Δv {v}", "18", "",
         "W m v1 {v}", "W = 2 m ({v} - v1) {v}", "W m Δv {v}", "16", "",
         "W m v2 Δv", "W = m (v2 - Δv : 2) Δv", "W m Δv {v}", "15", "",
         "W m v2 {v}", "W = 2 m (v2 - {v}) {v}", "W m Δv {v}", "13", "",
         "W m Δv {v}", "W = m Δv {v}", "W a m Δt {v}", "23", "",
         "W P Δs v1 v2", "W = 2 P Δs : (v1 + v2)", "W P Δs {v}", "10", "",
         "W P Δs v1 Δv", "W = P Δs : (v1 + Δv : 2)", "W P Δs {v}", "18", "",
         "W P Δs v2 Δv", "W = P Δs : (v2 - Δv : 2)", "W P Δs {v}", "15", "",
         "W P Δs {v}", "W = P Δs : {v}", "W P Δt", "22", "",
         "W P Δt", "W = P Δt", "", "44", ""];
          CAI = AA[0];
        } // W
        if (AA[0] == FAB[255])
        {
          FAC = [
         "θ a ax", "θ = acos(ax : a)", "", "0", "",
         "θ a az", "θ = acos(az : a)", "", "0", "",
         "θ a ay", "θ = asin(ay : a)", "", "0", "",
         "θ ax ay", "θ = atan(ay : ax)", "", "0", "",
         "θ ay az", "θ = atan(ay : az)", "", "0", "",
         "θ a ax ϕ", "θ = acos(ax : a : sin(ϕ))", "", "0", "",
         "θ a az ϕ", "θ = acos(az : a : cos(ϕ))", "", "0", "",
         "θ ax ay ϕ", "θ = atan(ay sin(ϕ) : ax)", "", "0", "",
         "θ ay az ϕ", "θ = atan(ay cos(ϕ) : az)", "", "0", "",
         "θ F Fx", "θ = acos(Fx : F)", "", "0", "",
         "θ F Fz", "θ = acos(Fz : F)", "", "0", "",
         "θ F Fy", "θ = asin(Fy : F)", "", "0", "",
         "θ Fx Fy", "θ = atan(Fy : Fx)", "", "0", "",
         "θ Fy Fz", "θ = atan(Fy : Fz)", "", "0", "",
         "θ F Fx ϕ", "θ = acos(Fx : F : sin(ϕ))", "", "0", "",
         "θ F Fz ϕ", "θ = acos(Fz : F : cos(ϕ))", "", "0", "",
         "θ Fx Fy ϕ", "θ = atan(Fy sin(ϕ) : Fx)", "", "0", "",
         "θ Fy Fz ϕ", "θ = atan(Fy cos(ϕ) : Fz)", "", "0", "",
         "θ Ft Ftx", "θ = acos(Ftx : Ft)", "", "0", "",
         "θ Ft Ftz", "θ = acos(Ftz : Ft)", "", "0", "",
         "θ Ft Fty", "θ = asin(Fty : Ft)", "", "0", "",
         "θ Ftx Fty", "θ = atan(Fty : Ftx)", "", "0", "",
         "θ Fty Ftz", "θ = atan(Fty : Ftz)", "", "0", "",
         "θ Ft Ftx ϕ", "θ = acos(Ftx : Ft : sin(ϕ))", "", "0", "",
         "θ Ft Ftz ϕ", "θ = acos(Ftz : Ft : cos(ϕ))", "", "0", "",
         "θ Ftx Fty ϕ", "θ = atan(Fty sin(ϕ) : Ftx)", "", "0", "",
         "θ Fty Ftz ϕ", "θ = atan(Fty cos(ϕ) : Ftz)", "", "0", "",
         "θ p px", "θ = acos(px : p)", "", "0", "",
         "θ p pz", "θ = acos(pz : p)", "", "0", "",
         "θ p py", "θ = asin(py : p)", "", "0", "",
         "θ px py", "θ = atan(py : px)", "", "0", "",
         "θ py pz", "θ = atan(py : pz)", "", "0", "",
         "θ p px ϕ", "θ = acos(px : p : sin(ϕ))", "", "0", "",
         "θ p pz ϕ", "θ = acos(pz : p : cos(ϕ))", "", "0", "",
         "θ px py ϕ", "θ = atan(py sin(ϕ) : px)", "", "0", "",
         "θ py pz ϕ", "θ = atan(py cos(ϕ) : pz)", "", "0", "",
         "θ Δs Δsx", "θ = acos(Δsx : Δs)", "", "0", "",
         "θ Δs Δsz", "θ = acos(Δsz : Δs)", "", "0", "",
         "θ Δs Δsy", "θ = asin(Δsy : Δs)", "", "0", "",
         "θ Δsx Δsy", "θ = atan(Δsy : Δsx)", "", "0", "",
         "θ Δsy Δsz", "θ = atan(Δsy : Δsz)", "", "0", "",
         "θ Δs Δsx ϕ", "θ = acos(Δsx : Δs : sin(ϕ))", "", "0", "",
         "θ Δs Δsz ϕ", "θ = acos(Δsz : Δs : cos(ϕ))", "", "0", "",
         "θ Δsx Δsy ϕ", "θ = atan(Δsy sin(ϕ) : Δsx)", "", "0", "",
         "θ Δsy Δsz ϕ", "θ = atan(Δsy cos(ϕ) : Δsz)", "", "0", "",
         "θ Δv Δvx", "θ = acos(Δvx : Δv)", "", "0", "",
         "θ Δv Δvz", "θ = acos(Δvz : Δv)", "", "0", "",
         "θ Δv Δvy", "θ = asin(Δvy : Δv)", "", "0", "",
         "θ Δvx Δvy", "θ = atan(Δvy : Δvx)", "", "0", "",
         "θ Δvy Δvz", "θ = atan(Δvy : Δvz)", "", "0", "",
         "θ Δv Δvx ϕ", "θ = acos(Δvx : Δv : sin(ϕ))", "", "0", "",
         "θ Δv Δvz ϕ", "θ = acos(Δvz : Δv : cos(ϕ))", "", "0", "",
         "θ Δvx Δvy ϕ", "θ = atan(Δvy sin(ϕ) : Δvx)", "", "0", "",
         "θ Δvy Δvz ϕ", "θ = atan(Δvy cos(ϕ) : Δvz)", "", "0", "",
         "θ {v} {vx}", "θ = acos({vx} : {v})", "", "0", "",
         "θ {v} {vz}", "θ = acos({vz} : {v})", "", "0", "",
         "θ {v} {vy}", "θ = asin({vy} : {v})", "", "0", "",
         "θ {vx} {vy}", "θ = atan({vy} : {vx})", "", "0", "",
         "θ {vy} {vz}", "θ = atan({vy} : {vz})", "", "0", "",
         "θ {v} {vx} ϕ", "θ = acos({vx} : {v} : sin(ϕ))", "", "0", "",
         "θ {v} {vz} ϕ", "θ = acos({vz} : {v} : cos(ϕ))", "", "0", "",
         "θ {vx} {vy} ϕ", "θ = atan({vy} sin(ϕ) : {vx})", "", "0", "",
         "θ {vy} {vz} ϕ", "θ = atan({vy} cos(ϕ) : {vz})", "", "0", ""];
          CAI = AA[0];
        } // θ
        if (AA[0] == FAB[258])
        {
          FAC = [
         "ϕ ay az θ", "ϕ = acos(az tan(θ) : ay)", "", "0", "",
         "ϕ a az θ", "ϕ = acos(az : a : cos(θ))", "", "0", "",
         "ϕ a ax θ", "ϕ = asin(ax : a : cos(θ))", "", "0", "",
         "ϕ ax ay θ", "ϕ = asin(ax tan(θ) : ay)", "", "0", "",
         "ϕ ax az", "ϕ = atan(ax : az)", "", "0", "",
         "ϕ F Fx θ", "ϕ = asin(Fx : F : cos(θ))", "", "0", "",
         "ϕ F Fz θ", "ϕ = acos(Fz : F : cos(θ))", "", "0", "",
         "ϕ Fx Fy θ", "ϕ = asin(Fx tan(θ) : Fy)", "", "0", "",
         "ϕ Fx Fz", "ϕ = atan(Fx : Fz)", "", "0", "",
         "ϕ Fy Fz θ", "ϕ = acos(Fz tan(θ) : Fy)", "", "0", "",
         "ϕ Ft Ftx θ", "ϕ = asin(Ftx : Ft : cos(θ))", "", "0", "",
         "ϕ Ft Ftz θ", "ϕ = acos(Ftz : Ft : cos(θ))", "", "0", "",
         "ϕ Ftx Fty θ", "ϕ = asin(Ftx tan(θ) : Fty)", "", "0", "",
         "ϕ Ftx Ftz", "ϕ = atan(Ftx : Ftz)", "", "0", "",
         "ϕ Fty Ftz θ", "ϕ = acos(Ftz tan(θ) : Fty)", "", "0", "",
         "ϕ py pz θ", "ϕ = acos(pz tan(θ) : py)", "", "0", "",
         "ϕ p pz θ", "ϕ = acos(pz : p : cos(θ))", "", "0", "",
         "ϕ p px θ", "ϕ = asin(px : p : cos(θ))", "", "0", "",
         "ϕ px py θ", "ϕ = asin(px tan(θ) : py)", "", "0", "",
         "ϕ px pz", "ϕ = atan(px : pz)", "", "0", "",
         "ϕ Δsy Δsz θ", "ϕ = acos(Δsz tan(θ) : Δsy)", "", "0", "",
         "ϕ Δs Δsz θ", "ϕ = acos(Δsz : Δs : cos(θ))", "", "0", "",
         "ϕ Δs Δsx θ", "ϕ = asin(Δsx : Δs : cos(θ))", "", "0", "",
         "ϕ Δsx Δsy θ", "ϕ = asin(Δsx tan(θ) : Δsy)", "", "0", "",
         "ϕ Δsx Δsz", "ϕ = atan(Δsx : Δsz)", "", "0", "",
         "ϕ Δvy Δvz θ", "ϕ = acos(Δvz tan(θ) : Δvy)", "", "0", "",
         "ϕ Δv Δvz θ", "ϕ = acos(Δvz : Δv : cos(θ))", "", "0", "",
         "ϕ Δv Δvx θ", "ϕ = asin(Δvx : Δv : cos(θ))", "", "0", "",
         "ϕ Δvx Δvy θ", "ϕ = asin(Δvx tan(θ) : Δvy)", "", "0", "",
         "ϕ Δvx Δvz", "ϕ = atan(Δvx : Δvz)", "", "0", "",
         "ϕ {vy} {vz} θ", "ϕ = acos({vz} tan(θ) : {vy})", "", "0", "",
         "ϕ {v} {vz} θ", "ϕ = acos({vz} : {v} : cos(θ))", "", "0", "",
         "ϕ {v} {vx} θ", "ϕ = asin({vx} : {v} : cos(θ))", "", "0", "",
         "ϕ {vx} {vy} θ", "ϕ = asin({vx} tan(θ) : {vy})", "", "0", "",
         "ϕ {vx} {vz}", "ϕ = atan({vx} : {vz})", "", "0", ""];
          CAI = AA[0];
        } // ϕ
      }
      // 2     Für Vorschläge, Formeln und Formelnquelle
      if (AA.Length > 1)
      {
        for (int i = 0; i < FAC.Length - 4; i += 5)
        {
          if (FAC[i] == CAD) { A102.Text = FAC[i + 1]; }
        }
      }
    }
    private void EAAE()
    {
      // 1     Deklaration
      string aa; string[] ab;
      if (FAA.Length == 1) { return; }
      //DAO = False // Eingabeneingangsprüfer zurücksetzen
      // 2     Die Zeilen von E1 trennen
      aa = A103.Text!; ab = aa.Split('\n');
      // 3     Die Eingaben von Zeilen trennen
      for (int f = 0; f < ab.Length; f++)
      {
        ab[f] = ab[f][6..];
        ab[f] = ab[f].TrimStart(' ');
        ab[f] = ab[f].TrimEnd(' ');
        ab[f] = "(" + ab[f] + ")";
      }
      CAA = A102.Text!;
      // 4     Eingaben einsetzen
      for (int i = 1; i < FAA.Length; i++)
      {
        for (int j = W_FA.Length - 1; j > -1; j--)
        {
          if (FAA[i] == W_FA[j]) { CAA = CAA.Replace(W_FA[j], ab[i]); break; }
        }
      }
      // 7     Fertiger Ausdruck in mathematischer Funktion rechnen
      DAAB(); // : DAO = True
    }
    #endregion
    #region E-AB


    #endregion
    #endregion
  }
}