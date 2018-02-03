using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziBulmaProjesi
{
    public partial class FrmDiziBul : Form
    {
        public FrmDiziBul()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void FrmDiziBul_Load(object sender, EventArgs e)
        {
           




        }

        private void BtnAile_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;





            LblSezonBolum.Text = "11 sezon / 128 bölüm";
            LblYapımYili.Text = "2005 - Doctor Who";
            LblPuan.Text = "8.9";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\doctorwho.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Televizyon tarihinin en uzun soluklu ve en başarılı bilimkurgu dizisi olarak Guinness Rekorlar Kitabı’na geçen\n İngiliz menşeli Doctor Who, 2005’te baştan aşağı yenilenen versiyonuyla izleyicilerin beğenisine sunuluyor.\n Yayın hayatına 1963’te başlayan kült dizi, yaptığı zaman yolculuklarıyla kötülerin en büyük düşmanı haline \n gelen Doktor adlı eğlenceli bir karakterin etrafında dönüyor. Başrolde izleyeceğimiz ünlü İngiliz oyuncu \n Christopher Eccleston, seneler içinde Doktor’u canlandıran dokuzuncu aktör olmanın gururunu yaşıyor.\n Yardımcısıyla birlikte İngilizlere özgü sıradan bir polis kulübesine girip, zamanlar ve mekanlar arası \n yolculuklara çıkan Doktor’un nefes kesen maceraları, bugüne kadar 39 ayrı ödüle layık görüldü.";

            LblSezonBolum2.Text = "5 sezon / 65 bölüm";
            LblYapimYili2.Text = "2008 - Merlin";
            LblPuan2.Text = "7.9";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\merlin.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Harry Potter, Yüzüklerin Efendisi'yle buluşuyor, Orta Çağ efsanesi ekranlarda yaşanıyor... İngiliz yapımı \n Merlin'de sihrin ve doğaüstü yaratıkların diyarı Camelot'ta bir efsanenin doğuşuna tanık olacağız. Kral Uther \n tarafından yönetilen Birleşik Krallık’ta büyücülerin sihir yapmalarının yasaklandığı bir dönemde, doğaüstü \n yeteneklere sahip Merlin adında genç bir adamın yolu ileride tahta geçecek Prens Arthur’la kesişir. İki genç \n adamın rekabetle başlayan tanışıklıkları kısa sürede dostluğa dönüşecek ve ülkelerinin kaderinde büyük rol \n oynayacaktır. Tarihin en büyük büyücü efsanesi Merlin'in gençlik yılları, fantastik dizi tutkunlarını ekran başına toplayacak.";

            LblSezonBolum3.Text = "1 sezon / 10 bölüm";
            LblYapimYili3.Text = "2017 - Free Rein";
            LblPuan.Text = "8.9";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\freerein.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Los Angeles'ta yaşayan 15 yaşındaki Zoe, yaz tatilini İngiltere açıklarındaki bir adada, annesinin \n çocukluğunun geçtiği evde geçirir ve burada gizemli bir atla bağ kurar.";

            LblSezonBolum4.Text = "3 sezon / 35 bölüm";
            LblYapimYili4.Text = "2016 - Fuller House";
            LblPuan4.Text = "7.9";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\fullerhouse.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = "San Francisco'da yaşayan D.J. hamiledir ve eşinden ayrılmıştır. Kardeşi Stephanie, en yakın arkadaşı \n Kimmy ve onun ergen kızı Ramona, 12 yaşındaki isyankar oğlu J.D. ve 7 yaşındaki oğlu Max ile başa çıkamayan D.J.'ye yardım etmek için, onun evine taşınırlar.";


            LblSezonBolum5.Text = "6 sezon / 99 bölüm";
            LblYapimYili5.Text = "2012 - Baby Daddy";
            LblPuan5.Text = "7.4";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\babydaddy.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "New York'ta barmenlik yapan Ben Wheeler (Jean-Luc Bilodeau) aynı zamanda öğrenimini \n tamamlamaya çalışmaktadır. Bir gün eve geldiğinde kapısında eski kız arkadaşı tarafından \n bırakılmış bir bebek bulur ve hayatı alt-üst olur. Ne yapacağını bilemez bir haldeyken annesi \n Bonnie (Melissa Peterman), erkek kardeşi Danny (Derek Ler), en iyi arkadaşları Tucker (Tahj Mowry) \n ve Riley'in (Chelsea Kane) yardımları ile bu sevimli kız bebeğe bakıp, onu büyütmeye karar verir. ";


            LblSezonBolum6.Text = "1 sezon / 8 bölüm";
            LblYapimYili6.Text = "2017 - The Blacklist: Redemption";
            LblPuan6.Text = "7.0";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\blacklist.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "NBC'de yayınlanan The Blacklist'in yan dizisi. Dizide yeni karakterler görüleceği gibi orijinal karakterlere de yer verilecek.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;


            LblSezonBolum.Text = "1 sezon / 10 bölüm";
            LblYapımYili.Text = "2001 - Band of Brothers";
            LblPuan.Text = "9.6";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\bandofbrothers.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "2. Dünya Savaşı'nı anlatan en başarılı TV dizisi olarak gösterilen Kardeşler Takımı, askerler \n arasındaki görev duygusu, dostluk, güveni son derece etkileyici sahnelerle sergileyen bir cesaret  öyküsü.";



            LblSezonBolum2.Text = "2 sezon / 26 bölüm";
            LblYapimYili2.Text = "2015 - Daredevil";
            LblPuan2.Text = "9.1";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\daredevil.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Daredevil, hikayenin merkezinde yer alan ve gündüzleri avukatlık yapıp, geceleri ise suçluların \n peşinden giden Matt Murdock'ın yaşadığı maceraları konu alıyor. 2003 yılında Mark Steven \n Johnson'ın yazıp yönettiği çizgi romanın sinema uyarlamasında Matt Murdock, Ben Affleck tarafından canlandırılmıştı.";


            LblSezonBolum3.Text = "5 sezon / 59 bölüm";
            LblYapimYili3.Text = "2013- Free Rein";
            LblPuan.Text = "8.6";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\vikings.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Vikings dizisi; Fransa ve Britanya’ya kadar uzanan saldırılarla tarihte kendisinden oldukça söz \n ettirmiş cesur savaşçı Ragnar Lothbrok ve oğlu Bjørn‘un yaşadıklarını anlatırken, Vikinglerin çok az \n işlenmiş kültürünü de bize yansıtarak gerçeğe dayalı bir izlenim sunuyor. Ragnor’un basit bir \n çiftçiyken ne kadar ileriyi görebileceğine tanık oluyor ve onun kardeşi kadar sevdiği arkadaşı \n Rollo‘yla beraber denizlerle olan imtihanını seyrediyoruz. Gözlerini denizden, saçlarını güneşten ve \n  cesaretlerini Odin’den alan korkusuz ve acımasız ırkın maceraları ve yaşamları kesinlikle ilgi çekmeyi başarıyor.";


            LblSezonBolum4.Text = "5 sezon / 103 bölüm";
            LblYapimYili4.Text = "2011 - Person of Interest";
            LblPuan4.Text = "8.4";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\fullerhouse.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = "En iyi suç henüz işlenmeyendir. Lost’un yaratıcısı J.J. Abrams ve The Dark Knight'ın senaristi Jonathan Nolan'dan yepyeni bir gizem öyküsü.";


            LblSezonBolum5.Text = "2 sezon / 18 bölüm";
            LblYapimYili5.Text = "2016 - Shooter";
            LblPuan5.Text = "7.6";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\shooter.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "Dizi, Vietnam Savaşı'nda keskin nişancı olarak görev almış Bob Lee Swagger/Bob 'the Nailer' (Ryan \n Phillippe) etrafında döner. (Bu karakter gerçek hayatta ABD Deniz Piyadeleri'nde sniper olarak \n görev almış, Vietnam Savaşı'nda uzun mesafede yaptığı atışlarla ün yaparak efsane olmuş Carlos  \n Hathcock'u yansıtmaktadır.) Geçmişini geride bırakmak isteyen Bob uzun süredir küçük bir \n kasabada inzivaya çekilmiştir. Ondan son bir görev için işine geri dönmesi istenmektedir. Ancak \n bu yeni görevinde ABD Başkanı'na yönelik bir suikast komplosu tuzağına düştüğünü farketmesi \n uzun sürmez. Onun amacı artık bu sır perdesini aralamak ve başkanı her türlü suikast girişimine karşı korumaktır.";


            LblSezonBolum6.Text = "4 sezon / 38 bölüm";
            LblYapimYili6.Text = "2013 - Banshee";
            LblPuan6.Text = "8.3";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\banshee.jpeg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Bir zamanlar ülkenin en ünlüleri arasında yer alan bir mücevher hırsızı (Anthony Starr) \n hapishaneden yeni çıkmıştır. Yeraltı dünyasından bir arkadaşının yardımıyla, hapishaneye \n düşmesine neden olan soygundan kazandıklarına sahip olan eski ortağının (Ivana Miličević) peşine \n düşer. Ama aradan 15 yıl geçmiştir ve Anna olarak tanıdığı kadın artık Carrie ismini kullanan \n saygın bir emlakçıdır. Kadın Bölge Başsavcısı ile evlidir ve iki çocuğu vardır. Peki ya soygundaki pırlantalara ne oldu? ";
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;


            LblSezonBolum.Text = "1 sezon / 14 bölüm";
            LblYapımYili.Text = "2002 - Firefly";
            LblPuan.Text = "9.2";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\firefly.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Firefly, 2002 yılında 12 bölüm yayınlanmış bir bilimkurgu, drama dizisidir. Uzun soluklu bir yapım olabilecek iken Fox kanalı tarafından bitirilmiştir.\n Buna rağmen yüksek bir fan kitlesine sahiptir. ";


            LblSezonBolum2.Text = "1 sezon / 10 bölüm";
            LblYapimYili2.Text = "2016 - Westworld";
            LblPuan2.Text = "9.1";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\westworld.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Westworld ya da Batı Dünyası, yapay bilincin ortaya çıkması ve suçun evrimiyle ilgili karanlık bir yolculuğu anlatmaktadır.";

            LblSezonBolum3.Text = "6 sezon / 120 bölüm";
            LblYapimYili3.Text = "2004- Lost";
            LblPuan.Text = "8.6";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\lost.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Korkunç bir uçak kazası... Bir adada mahsur kalan kazazedeler ve adada keşfettikleri gizemler...";


            LblSezonBolum4.Text = "5 sezon / 100 bölüm";
            LblYapimYili4.Text = "2008 - Fringe";
            LblPuan4.Text = "8.5";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\fringe.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text= "Bilimkurgu, drama ve gerilimin iç içe geçtiği yapımda bir özel ajan, bir bilim adamı ve oğlundan oluşan üçlümüz, \n bir dizi inanılmaz olayla bağlantılı ölümcül bir gizemi çözmeye çalışıyorlar...";

            LblSezonBolum5.Text = "2 sezon / 24 bölüm";
            LblYapimYili5.Text = "2017 - Travelers";
            LblPuan5.Text = "7.7";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\travelers.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "Yüzlerce yıl gelecekte geçen hikayede teknoloji öyle gelişmiş ki insanlara zamanda yolculuk \n yaptırıp 21. yüzyıla geri gönderip insanlığı amansız bir gelecekten kurtarmaya çalışılıyor.";



            LblSezonBolum6.Text = "2 sezon / 23 bölüm";
            LblYapimYili6.Text = "2015 - Colony";
            LblPuan6.Text = "7.3";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\colony.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Carlton Cuse önderliğindeki USA Network kanalının yeni dizisi olacak olan Colony, yakın gelecek \n zamanında geçecek ve uzaylı istilasına uğramış Los Angeles şehrindeki direniş mücadelesini konu \n alacak. Dizinin başrollerinde ise 13 bölümlük başarısız İntelligence macerası yaşayan Josh \n olloway ve Prison Break-The Walking Dead yıldızı Sarah Wayne Callies var. Holloway, bu direniş \n içerisinde yer alacak eski FBI ajanı Will Bowman karakteri ile dizide yer alacak.";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;

            LblSezonBolum.Text = "5 sezon / 62 bölüm";
            LblYapımYili.Text = "2008 - Breaking Bad";
            LblPuan.Text = "9.6";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\bb.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Sıradan bir kimya öğretmeni olan Walter White'ın öleceğini öğrenince uyuşturucu üreticiliğine kadar uzanan \n özgürleşme deneyimi, çarpıcı bir kara mizaha dönüşüyor.";

            LblSezonBolum2.Text = "7 sezon / 68 bölüm";
            LblYapimYili2.Text = "2011 - Game of Thrones";
            LblPuan2.Text = "9.5";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\got.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Dizi Westeros kıtasındaki birleşik Yedi Krallık'ın uzun yazdan çıkmasının ve kışın yaklaşması ile \n başlar. Lord Eddard Stark'ın eski ve yakın arkadaşı Kral Robert Baratheon, eski Kral Eli ve \n Eddard'ın akıl hocasıJon Arryn'nin ölmesi üzerine kendisinden yeni Kral Eli olmasını ister. Eddard, \n Jon'un öldürüldüğü ile aldığı bir mesajdan sonra isteksiz de olsa bu görevi kabul eder.";

            LblSezonBolum3.Text = "3 sezon / 30 bölüm";
            LblYapimYili3.Text = "2015- Better Call Saul";
            LblPuan.Text = "9.4";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\bcs.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Breaking Bad spin-off’u. Breaking Bad’te Walter White ve Jesse’nin avukatı ve aynı zamanda \n suçluların bir numaralı adresi olan Saul Goodman odaklı olacak dizi bir “prequel” olacak. Yani \n  Breaking Bad’teki zamanın daha öncelerine bir yolculuk yapacağız ve Saul Goodman henüz Walter \n ve Jesse ile tanışmamış olacak. Saul Goodman’ı bol bol mahkemelerde göreceğiz.";


            LblSezonBolum4.Text = "4 sezon / 13 bölüm";
            LblYapimYili4.Text = "2010 - Sherlock";
            LblPuan4.Text = "9.3";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\s.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
              label17.Text= "Sherlock’u hiç böyle görmediniz! Sör Conan Doyle’un kahramanını günümüze taşıyan Sherlock'ta ünlü dedektif, modern teknolojiden yararlanan biri olarak karşımızda.";

            LblSezonBolum5.Text = "2 sezon / 16 bölüm";
            LblYapimYili5.Text = "2014 - True Detective";
            LblPuan5.Text = "9.3";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\td.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text= "Matthew McConaughey ve Woody Harrelson'ın başrollerini paylaşacağı True Detective, 8 bölüm halinde yayınlanacak olan bir polisiye drama. ";

            LblSezonBolum6.Text = "8 sezon / 176 bölüm";
            LblYapimYili6.Text = "2004 - House M.D";
            LblPuan6.Text = "8.9";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\hmd.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Huysuz, ukala, çekilmez, asosyal, saplantılı ve aynı zamanda dahi bir doktor, teşhis konulması zor \n hastalıklar ve bu konuda eğitilmek için özenle seçilmiş genç doktorlar...";







        }

        private void button7_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;

            LblSezonBolum.Text = "5 sezon / 60 bölüm";
            LblYapımYili.Text = "2002 - The Wire";
            LblPuan.Text = "9.4";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\tw.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Amerika'nın Baltimore şehrinde geçen dizi; her sezon başka bir sorunu odağına alarak, birebir \n yaşanan olaylardan esinlenerek suçluların dünyasına farklı bir yerden bakıyor.";

            LblSezonBolum2.Text = "2 sezon / 17 bölüm";
            LblYapimYili2.Text = "2016 - Stranger Things";
            LblPuan2.Text = "9.3";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\st.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Dizi 1980'li yıllarda New York eyaletine bağlı bir liman kasabası olan Montauk'ta geçmektedir. \n Genç bir çocuk gizemli bir şekilde ortadan kaybolur. Ailesi, arkadaşları ve yerel polisler çocuğun \n ortadan kaybolması ile ilgili kapsamlı bir soruşturma başlatarak gerçeği açığa çıkartmaya çalışırlar. \n Olayın soruşturması derinleştikçe gizli hükümet deneylerinin yapıldığı olağanüstü bir gizemin içine çekilirler.";

            LblSezonBolum3.Text = "6 sezon / 56 bölüm";
            LblYapimYili3.Text = "1997- OZ";
            LblPuan.Text = "8.9";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\oz.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Oswald Hapishanesi'ne hoş geldiniz... Ama Oz adıyla da bilinen bu özel hapishaneye adım \n attığınzda, 'hoş bulduk' demek de biraz zorlanacaksınız; çünkü Oz'da sınır tanımayan, sert olaylara \n tanıklık edecek ve mahkûmlarla gardiyanların nasıl bir psikolojiye sahip olduklarını çok daha iyi \n anlayacaksınız...";

            LblSezonBolum4.Text = "1 sezon / 8 bölüm";
            LblYapimYili4.Text = "2016 - 11.22.63";
            LblPuan4.Text = "8.9";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\112263.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = "Stephen King'in aynı adlı romanından uyarlanacak dizi, Jake Epping isimli bir öğretmeninin, \n zamanda yolculuk yaparak John F. Kennedy suikastini engellemeye çalışmasını konu alıyor. J.J \n Abrams'ın öncülüğünde gerçekleşecek dizinin başrolünde ise Jake rolüyle James Franco var.";

            LblSezonBolum5.Text = "13 sezon / 276 bölüm";
            LblYapimYili5.Text = "2005 - Supernatural";
            LblPuan5.Text = "8.7";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\sn.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "Anneleri kendileri daha çocukken doğaüstü bir varlık tarafından öldürülen kardeşler babaları \n tarafından avcı olarak yetiştirilirler... Av ise annelerini öldüren gibi doğaüstü varlıklardır... ";

            LblSezonBolum6.Text = "7 sezon / 92 bölüm";
            LblYapimYili6.Text = "2008 - Sons of Anarchy";
            LblPuan6.Text = "8.7";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\soa.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Motorsikilet Kulübü MC, Kaliforniya'nın küçük kasabasında, kanun adamlarına karşı kendi yasa \n dışı varlığını korumaya çalışır. Kulüp, bir yandan içinde bulunduğu kuralsız yaşamını sürdürmeye \n çalışırken, diğer taraftan da bölgenin suç ve uyuşturucu ağına karşı direnç göstermek zorunda kalır.";



        }

        private void button9_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;

            LblSezonBolum.Text = "3 sezon / 31 bölüm";
            LblYapımYili.Text = "2013 -  Rick and Morty ";
            LblPuan.Text = "9.2";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\ram.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "En kısa tanımıyla dizi, çatlak bir bilim adamının peşinden sürüklediği torunu Morty ile \n maceradan maceraya atılmalarını konu ediyor.";


            LblSezonBolum2.Text = "21 sezon / 286 bölüm";
            LblYapimYili2.Text = "1997 - South Park";
            LblPuan2.Text = "8.9";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\sp.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Büyümekte olan dört çocuğun, Cartman, Stan, Kyle ve Kenny’nin gözünden dünyadaki politik, \n sosyal ve güncel olayların ironik bir şekilde ele alındığı dizi, yetişkinler için hazırlanmış içeriğinden \n anlatımına ‘kendine has’ benzersiz bir yapım. ";


            LblSezonBolum3.Text = "7 sezon / 102 bölüm";
            LblYapimYili3.Text = "2011- Suits";
            LblPuan.Text = "8.8";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\suits.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Mike Ross (Patrick J. Adams) eğitimini yarıda bırakmış bir dahidir. Mike'ın çocukluk hayalleri \n yaşadığı talihsiz olaylar ve büyük annesine bakma sorumluluğunu almış olmasından dolayı \n gerçekleşememiştir. Doğal zekası ve inanılmaz hafızası ile Mike geçimini başka insanların yerine \n LSAT sınavlarına girerek sağlamaktadır. ";

            LblSezonBolum4.Text = "8 sezon / 96 bölüm";
            LblYapimYili4.Text = "2011 - Shameless";
            LblPuan4.Text = "8.7";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\shame.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = " Chicago’nun güneyinde geçen dizi altı çocuk ve bir babadan oluşan \n ailenin trajikomik hikayesini anlatmaktadır";

            LblSezonBolum5.Text = "9 sezon / 201 bölüm";
            LblYapimYili5.Text = "2009 - Modern Family";
            LblPuan5.Text = "8.7";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\mf.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "Modern Family, Amerika ABC televizyonun da yayınlanan bir komedi dizisidir. \n Dizi, 3 aile ve 3 ayrı yaşamı ele almaktadır.";

            LblSezonBolum6.Text = "9 sezon / 205 bölüm";
            LblYapimYili6.Text = "2008 - Sons of Anarchy";
            LblPuan6.Text = "8.6";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\hım.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text= "Carter Bays ve Craig Thomas'ın yarattıkları How I Met Your Mother konu olarak, romantik başrol \n Theodore -Ted- Mosby'nin (Bob Saget) hayatının aşkı -eşiyle- tanışma hikayesini flashbacklerle \n anlatan bir sit-com. 2030 yılında evli, iki çocuk babası Ted çocuklarını karşısına alıyor (David \n Henrie, Lyndsy Fonseca) ve hikayesini anlatmaya başlıyor.";


        }

        private void button13_Click(object sender, EventArgs e)
        {
         


        }

        private void button14_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;

            LblSezonBolum.Text = "3 sezon / 42 bölüm";
            LblYapımYili.Text = "2014 -  Outlander ";
            LblPuan.Text = "8.9";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\out.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Diana Gabaldon'ın popüler fantastik aşk romanları serisinden uyarlanan bu destansı hikaye, \n iki farklı zamanda geçen iki aşk hikayesine odaklanıyor.";

            LblSezonBolum2.Text = "7 sezon / 143 bölüm";
            LblYapimYili2.Text = "2011 - Once Upon a Time";
            LblPuan2.Text = "8.1";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\once.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Hepsi sonsuza kadar mutlu mesut yaşadılar.… Ya da herkesin bu cümleye inanması sağlandı. \n Şimdi 28 yaşında olan Emma Swan kendisine nasıl bakacağını biliyor çünkü bebekken terk \n edildiğinden beri o bunu zaten yapıyor ama onunda yıllar önce terk ettiği oğlu onu tekrar buluyor \n ve işte her şey burada değişmeye başlıyor...";

            LblSezonBolum3.Text = "6 sezon / 101 bölüm";
            LblYapimYili3.Text = "2011 - Teen Wolf";
            LblPuan.Text = "7.8";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\tew.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Michael J. Fox’un 1985 tarihli filminden uyarlanan Teen Wolf, kurtadam efsanesi ve MTV’nin elinin  \n değdiği müzikleriyle, fantastik gençlik dizisi janrının son ürünü. ";

            LblSezonBolum4.Text = "4 sezon / 76 bölüm";
            LblYapimYili4.Text = "2011 - Hart of Dixie";
            LblPuan4.Text = "7.8";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\hod.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = "Tıp Fakültesi'nden mezun olduğu gün, cerrah olma hayalleri kuran Zoe Hart'ın umutları, staj \n  yaptığı hastanenin kendisine burs vermemesiyle suya düşer. Mezuniyet Günü, yaşlıca bir \n doktorun eline tutuşturduğu kartvizit artık onun son çaresidir.";

            LblSezonBolum5.Text = "4 sezon / 92 bölüm";
            LblYapimYili5.Text = "2003 - The O.C.";
            LblPuan5.Text = "7.5";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\oc.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "Zenginlik içinde hayatlarını sürdüren Orange County sakinlerinin hayatına dahil olmak \n durumunda kalan taşralı bir gencin hayatını, adaptasyon sürecini, arkadaşları ile ilişkilerini anlatıyor";


            LblSezonBolum6.Text = "1 sezon / 39 bölüm";
            LblYapimYili6.Text = "2015 - I Have a Lover";
            LblPuan6.Text = "8.3";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\lover.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Hafızasını kaybeden bir kadın (Kim Hyun-Joo), kendisinden nefret eden kocası (Ji Jin-Hee) ile karşılaşır. \n   Ona tekrar aşık olur. Bu arada, zorla ayrılmış olduğu ikiz kız kardeşi ile 30 yıl sonra tekrar karşılaşır.";


        }

        private void button18_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label9.Visible = true;
            label13.Visible = true;
            label17.Visible = true;
            label21.Visible = true;
            label25.Visible = true;


            LblSezonBolum.Text = "6 sezon / 86 bölüm ";
            LblYapımYili.Text = "1999 -  The Sopranos ";
            LblPuan.Text = "9.3";
            Pb1.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\sop.jpg");
            Pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label6.Text = "Dizinin konusu New Jersey’de bir Amerikan-İtalyan mafya ailesi patronu Tony Soprano’nun \n meslek, suç, şiddet, aile, adalet ve dostluk kavramları arasındaki denge kurma mücadelesi üzerine kurulmuştur.";

            LblSezonBolum2.Text = "4 sezon / 32 bölüm";
            LblYapimYili2.Text = "2015 - Mr. Robot";
            LblPuan2.Text = "9.3";
            Pb2.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\robot.jpg");
            Pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label9.Text = "Dizide Elliot, gündüzleri genç bir siber güvenlik mühendisi ve geceleri  hackerlık yapan bir siber korsandır. \n Elliot, yer altı hacker grubunun (fsociety) onunla irtibata geçmek için şirketininin \n sistemine zarar vermesi üzerine büyük bir karmaşıklığın içine kendisini atmıştır.";

            LblSezonBolum3.Text = "3 sezon / 30 bölüm";
            LblYapimYili3.Text = "2015 - Narcos";
            LblPuan.Text = "9.2";
            Pb3.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\narcos.jpg");
            Pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label13.Text = "Narcos, dünyanın en büyük uyuşturucu kaçakçısı olarak anılan Pablo Escobar'ın bu konuma \n gelirken yaşadıklarını ve onu hapse göndermek isteyen DEA Ajanı Steve Murphy'le ortağı Javier \n  Peña'nın yaşayacağı olayları anlatıyor.";

            LblSezonBolum4.Text = "3 sezon / 36 bölüm";
            LblYapimYili4.Text = "2004- Deadwood";
            LblPuan4.Text = "8.8";
            Pb4.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\deadw.jpg");
            Pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label17.Text = "Dizi 1870’li yıllarda Güney Dakota bölgesindeki Deadwood adlı madenci kasabasında geçer.";

            LblSezonBolum5.Text = "3 sezon / 39 bölüm";
            LblYapimYili5.Text = "2013 - Hannibal";
            LblPuan5.Text = "8.6";
            Pb5.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\han.jpg");
            Pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label21.Text = "En etkileyici edebi karakterlerden biri ilk defa televizyon dizisine uyarlanıyor: eski psikiyatrist yeni \n seri katil Dr. Hannibal Lecter. Thomas Harris’in klasik romanlarından uyarlanan ve Bryan Fuller \n (“Pushing Daisies,” “Heroes”) tarafından yaratılan bu yeni dizide, inanılmaz hikayenin nerede \n başladığını görüyoruz.";

            LblSezonBolum6.Text = "2 sezon / 16 bölüm";
            LblYapimYili6.Text = "2006 - Life on Mars";
            LblPuan6.Text = "8.4";
            Pb6.Image = Image.FromFile(@"C:\Users\yunus\Desktop\dizi proje\mars.jpg");
            Pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            label25.Text = "Sam Tyler bir suçu araştırırken geçirdiği trafik kazası sonucu gözlerini, David Bowie'nin \n Life on Mars single'ının listeleri kasıp kavurduğu 1973 yılında açar.";

        }
    }
}
