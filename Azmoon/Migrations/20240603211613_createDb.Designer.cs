﻿// <auto-generated />
using System;
using Azmoon.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Azmoon.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240603211613_createDb")]
    partial class createDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Arabic_CI_AS")
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Azmoon.Models.ExamPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ExamTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RemoveTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ExamPeriods");
                });

            modelBuilder.Entity("Azmoon.Models.TblApplicant", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AliasName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BirthCertificate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("BirthCertificateCityId")
                        .HasColumnType("int")
                        .HasColumnName("BirthCertificateCity_Id");

                    b.Property<int?>("BirthCityId")
                        .HasColumnType("int")
                        .HasColumnName("BirthCity_Id");

                    b.Property<string>("BirthDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CandidateNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("City_Id");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EssentialMobile")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FatherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FileNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte?>("Gender")
                        .HasColumnType("tinyint");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("LeftHanded")
                        .HasColumnType("bit");

                    b.Property<byte?>("MaritalCode")
                        .HasColumnType("tinyint");

                    b.Property<bool?>("MaritalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("NationalNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PreLastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte?>("Religion")
                        .HasColumnType("tinyint");

                    b.Property<int?>("StateId")
                        .HasColumnType("int")
                        .HasColumnName("State_Id");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TrackingCode")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkCityId")
                        .HasColumnType("int")
                        .HasColumnName("WorkCity_Id");

                    b.Property<string>("WorkPostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("WorkStateId")
                        .HasColumnType("int")
                        .HasColumnName("WorkState_Id");

                    b.Property<string>("WorkTel")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.ToTable("__Tbl_Applicant", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblApplicant1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("آدرس پستی");

                    b.Property<string>("AliasName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام مستعار");

                    b.Property<string>("BirthCertificate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره شناسنامه");

                    b.Property<int?>("BirthCertificateCityId")
                        .HasColumnType("int")
                        .HasColumnName("BirthCertificateCity_Id")
                        .HasComment("کد شهر محل صدور شناسنامه");

                    b.Property<int?>("BirthCityId")
                        .HasColumnType("int")
                        .HasColumnName("BirthCity_Id")
                        .HasComment("کد شهر محل تولد");

                    b.Property<string>("BirthDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("تاریخ تولی");

                    b.Property<string>("CandidateNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره داوطلبی");

                    b.Property<int?>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("City_Id")
                        .HasComment("کد شهر اقامت");

                    b.Property<string>("Email")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("ایمیل");

                    b.Property<string>("EssentialMobile")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("تلفن همراه ضروری");

                    b.Property<string>("FatherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام پدر");

                    b.Property<string>("FileNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره پرونده");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام");

                    b.Property<byte?>("Gender")
                        .HasColumnType("tinyint")
                        .HasComment("جنسیت\r\n1:زن\r\n2:مرد\r\n");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام خانوادگی");

                    b.Property<bool?>("LeftHanded")
                        .HasColumnType("bit")
                        .HasComment("چپ دست\r\n0-خیر\r\n1-بله\r\n");

                    b.Property<byte?>("MaritalCode")
                        .HasColumnType("tinyint");

                    b.Property<bool?>("MaritalStatus")
                        .HasColumnType("bit")
                        .HasComment("وضعیت تاهل\r\n1:مجرد\r\n2:متاهل\r\n");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("تلفن همراه");

                    b.Property<string>("NationalNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("کد ملی");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("کد پستی");

                    b.Property<string>("PreLastName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام خانوادگی قبلی");

                    b.Property<byte?>("Religion")
                        .HasColumnType("tinyint")
                        .HasComment("دین\r\n1-اسلام\r\n2-كليمي\r\n3-مسيحي\r\n4-زرتشتي\r\n");

                    b.Property<int?>("StateId")
                        .HasColumnType("int")
                        .HasColumnName("State_Id")
                        .HasComment("کد استان اقامت");

                    b.Property<string>("Tel")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("تلفن ثابت");

                    b.Property<string>("TrackingCode")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("کد پیگیری ثبت نام");

                    b.Property<string>("WorkAddress")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("آدرس محل کار");

                    b.Property<int?>("WorkCityId")
                        .HasColumnType("int")
                        .HasColumnName("WorkCity_Id")
                        .HasComment("شهرستان محل کار");

                    b.Property<string>("WorkPostalCode")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("کد پستی محل کار");

                    b.Property<int?>("WorkStateId")
                        .HasColumnType("int")
                        .HasColumnName("WorkState_Id")
                        .HasComment("استان محل کار");

                    b.Property<string>("WorkTel")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasComment("تلفن محل کار");

                    b.HasKey("Id");

                    b.HasIndex("BirthCertificateCityId");

                    b.HasIndex("BirthCityId");

                    b.HasIndex("CityId");

                    b.HasIndex("StateId");

                    b.HasIndex("WorkCityId");

                    b.HasIndex("WorkStateId");

                    b.ToTable("Tbl_Applicant", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblApplicantDetail", b =>
                {
                    b.Property<bool?>("ChangeCourse")
                        .HasColumnType("bit")
                        .HasComment("متقاضی تغییر رشته");

                    b.Property<int?>("CurrentJudgeFieldId")
                        .HasColumnType("int")
                        .HasColumnName("CurrentJudgeField_Id")
                        .HasComment("کد رشته کارشناسی فعلی");

                    b.Property<int?>("CurrentJudgeRegionId")
                        .HasColumnType("int")
                        .HasColumnName("CurrentJudgeRegion_Id")
                        .HasComment("کد منطقه محل کارشناسی فعلی");

                    b.Property<int?>("CurrentJudgeStateId")
                        .HasColumnType("int")
                        .HasColumnName("CurrentJudgeState_Id")
                        .HasComment("کد استان محل کارشناسی فعلی");

                    b.Property<int?>("ExamAreaCityId")
                        .HasColumnType("int")
                        .HasColumnName("ExamAreaCity_Id")
                        .HasComment("کد شهربراي تعيين حوزه امتحاني");

                    b.Property<int?>("ExamAreaStateId")
                        .HasColumnType("int")
                        .HasColumnName("ExamAreaState_Id")
                        .HasComment("کد استان براي تعيين حوزه امتحاني");

                    b.Property<string>("FileNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GraduationDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("تاریخ فارغ التحصیلی");

                    b.Property<string>("JudgeLicenseNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره پروانه کارشناسی");

                    b.Property<string>("MilitaryDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("تاریخ خدمت");

                    b.Property<short?>("MilitaryDuration")
                        .HasColumnType("smallint")
                        .HasComment("مدت خدمت");

                    b.Property<short?>("MilitaryStatus")
                        .HasColumnType("smallint")
                        .HasComment("وضعیت نظام وظیفه\r\n0- ندارد\r\n1- کارت پایان خدمت\r\n2-کارت معافیت\r\n");

                    b.Property<string>("PicPath")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("شاخه تصویر");

                    b.Property<string>("QuotaCode")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasComment("کد سهمیه ایثارگری");

                    b.Property<int?>("QuotaId")
                        .HasColumnType("int")
                        .HasColumnName("Quota_Id")
                        .HasComment("سهمیه ایثارگری");

                    b.Property<byte?>("QuotaPreCode")
                        .HasColumnType("tinyint")
                        .HasComment("پیش کد ایثارگری\r\n0-ندارد\r\n1-ستاد کل نیروهای مسلح\r\n3-ارتش جمهوری اسلامی ایران\r\n4-سپاه پاسداران\r\n5-سازمان بسیج مستضعفین\r\n6-وزارت دفاع جمهوری اسلامی ایران\r\n7-نیروی انتظامی جمهوری اسلامی ایران\r\n8-جهاد کشاورزی\r\n");

                    b.Property<byte?>("RegistryStatus")
                        .HasColumnType("tinyint")
                        .HasComment("وضعیت استعلام ثبت احوال\r\n0-  استعلام نشده است \r\n1-تایید شده\r\n4-  به داوطلب سرویس داده نمیشود\r\n");

                    b.Property<int?>("RequiredJudgeFieldId")
                        .HasColumnType("int")
                        .HasColumnName("RequiredJudgeField_Id")
                        .HasComment("کد رشته کارشناسی مورد تقاضا");

                    b.Property<int?>("RequiredStateJudgeId")
                        .HasColumnType("int")
                        .HasColumnName("RequiredStateJudge_Id")
                        .HasComment("کد استان کارشناسی مورد تقاضا");

                    b.Property<int?>("StudyFieldId")
                        .HasColumnType("int")
                        .HasColumnName("StudyField_Id")
                        .HasComment("رشته تحصیلی");

                    b.Property<int?>("StudyGrade")
                        .HasColumnType("int")
                        .HasComment("مقطع تحصیلی\r\n7: کارشناسی\r\n8: کارشناسی ارشد\r\n9: دكتري\r\n");

                    b.Property<bool?>("Transfer")
                        .HasColumnType("bit")
                        .HasComment("متقاضی انتقال");

                    b.Property<int?>("UniversityId")
                        .HasColumnType("int")
                        .HasColumnName("University_Id")
                        .HasComment("دانشگاه محل تحصیل");

                    b.Property<string>("WarriorBirthCertificate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره شناسنامه رزمنده");

                    b.Property<string>("WarriorBirthDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("تاریخ تولد رزمنده");

                    b.Property<string>("WarriorFamily")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام خانوادگی رزمنده");

                    b.Property<string>("WarriorFatherName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام پدر رزمنده");

                    b.Property<string>("WarriorName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("نام رزمنده");

                    b.Property<string>("WarriorNationalNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("کد ملی رزمنده");

                    b.Property<short?>("WorkExperienceLength")
                        .HasColumnType("smallint")
                        .HasComment("مدت سابقه کار (ماه)");

                    b.ToTable("Tbl_ApplicantDetail", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<short?>("RegionCode")
                        .HasColumnType("smallint");

                    b.Property<string>("SanjeshId")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("Sanjesh_Id")
                        .IsFixedLength();

                    b.Property<int?>("StateId")
                        .HasColumnType("int")
                        .HasColumnName("State_Id");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id")
                        .HasName("PK_City");

                    b.HasIndex("StateId");

                    b.ToTable("Tbl_City", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblJudgeField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SanjeshId")
                        .HasColumnType("int")
                        .HasColumnName("Sanjesh_Id");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_JudgeField", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblQuotum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SanjeshId")
                        .HasColumnType("int")
                        .HasColumnName("Sanjesh_Id");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_Quota", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblScore", b =>
                {
                    b.Property<short?>("AcceptanceFreeScore")
                        .HasColumnType("smallint")
                        .HasComment("حدنصاب قبولی در سهمیه آزاد (در فایل اصلی سنجش به عنوان اخرین نمره قبولی در آزاد)");

                    b.Property<short?>("AcceptanceQuotaScore")
                        .HasColumnType("smallint")
                        .HasComment("حدنصاب قبولی در سهمیه ایثارگری (در فایل سنجش با عنوان اخرین نمره قبولی در ایثارگری )");

                    b.Property<short?>("BalanceScore")
                        .HasColumnType("smallint")
                        .HasComment("نمره تراز (درفایل اصلی سنجش این آیتم به اسم نمره کل درج شده ) ");

                    b.Property<string>("FileNo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("شماره پرونده");

                    b.Property<short?>("RawScore")
                        .HasColumnType("smallint")
                        .HasComment("نمره خام");

                    b.Property<byte?>("ResultStatus")
                        .HasColumnType("tinyint")
                        .HasComment("کد وضعیت \r\n2:مردود");

                    b.ToTable("Tbl_Score", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SanjeshId")
                        .HasColumnType("int")
                        .HasColumnName("Sanjesh_Id");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_State", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblStudyField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SanjeshId")
                        .HasColumnType("int")
                        .HasColumnName("Sanjesh_Id");

                    b.Property<string>("Title")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Tbl_StudyField", (string)null);
                });

            modelBuilder.Entity("Azmoon.Models.TblApplicant1", b =>
                {
                    b.HasOne("Azmoon.Models.TblCity", "BirthCertificateCity")
                        .WithMany("TblApplicant1BirthCertificateCities")
                        .HasForeignKey("BirthCertificateCityId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_City2");

                    b.HasOne("Azmoon.Models.TblCity", "BirthCity")
                        .WithMany("TblApplicant1BirthCities")
                        .HasForeignKey("BirthCityId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_City");

                    b.HasOne("Azmoon.Models.TblCity", "City")
                        .WithMany("TblApplicant1Cities")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_City1");

                    b.HasOne("Azmoon.Models.TblState", "State")
                        .WithMany("TblApplicant1States")
                        .HasForeignKey("StateId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_State2");

                    b.HasOne("Azmoon.Models.TblCity", "WorkCity")
                        .WithMany("TblApplicant1WorkCities")
                        .HasForeignKey("WorkCityId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_City3");

                    b.HasOne("Azmoon.Models.TblState", "WorkState")
                        .WithMany("TblApplicant1WorkStates")
                        .HasForeignKey("WorkStateId")
                        .HasConstraintName("FK_Tbl_Applicant_Tbl_State3");

                    b.Navigation("BirthCertificateCity");

                    b.Navigation("BirthCity");

                    b.Navigation("City");

                    b.Navigation("State");

                    b.Navigation("WorkCity");

                    b.Navigation("WorkState");
                });

            modelBuilder.Entity("Azmoon.Models.TblCity", b =>
                {
                    b.HasOne("Azmoon.Models.TblState", "State")
                        .WithMany("TblCities")
                        .HasForeignKey("StateId")
                        .HasConstraintName("FK_Tbl_City_Tbl_State");

                    b.Navigation("State");
                });

            modelBuilder.Entity("Azmoon.Models.TblCity", b =>
                {
                    b.Navigation("TblApplicant1BirthCertificateCities");

                    b.Navigation("TblApplicant1BirthCities");

                    b.Navigation("TblApplicant1Cities");

                    b.Navigation("TblApplicant1WorkCities");
                });

            modelBuilder.Entity("Azmoon.Models.TblState", b =>
                {
                    b.Navigation("TblApplicant1States");

                    b.Navigation("TblApplicant1WorkStates");

                    b.Navigation("TblCities");
                });
#pragma warning restore 612, 618
        }
    }
}
