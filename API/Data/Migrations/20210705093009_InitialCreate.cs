﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    timestamp = table.Column<double>(type: "REAL", nullable: false),
                    AED = table.Column<double>(type: "REAL", nullable: false),
                    AFN = table.Column<double>(type: "REAL", nullable: false),
                    ALL = table.Column<double>(type: "REAL", nullable: false),
                    AMD = table.Column<double>(type: "REAL", nullable: false),
                    ANG = table.Column<double>(type: "REAL", nullable: false),
                    AOA = table.Column<double>(type: "REAL", nullable: false),
                    ARS = table.Column<double>(type: "REAL", nullable: false),
                    AUD = table.Column<double>(type: "REAL", nullable: false),
                    AWG = table.Column<double>(type: "REAL", nullable: false),
                    AZN = table.Column<double>(type: "REAL", nullable: false),
                    BAM = table.Column<double>(type: "REAL", nullable: false),
                    BBD = table.Column<double>(type: "REAL", nullable: false),
                    BDT = table.Column<double>(type: "REAL", nullable: false),
                    BGN = table.Column<double>(type: "REAL", nullable: false),
                    BHD = table.Column<double>(type: "REAL", nullable: false),
                    BIF = table.Column<double>(type: "REAL", nullable: false),
                    BMD = table.Column<double>(type: "REAL", nullable: false),
                    BND = table.Column<double>(type: "REAL", nullable: false),
                    BOB = table.Column<double>(type: "REAL", nullable: false),
                    BRL = table.Column<double>(type: "REAL", nullable: false),
                    BSD = table.Column<double>(type: "REAL", nullable: false),
                    BTC = table.Column<double>(type: "REAL", nullable: false),
                    BTN = table.Column<double>(type: "REAL", nullable: false),
                    BWP = table.Column<double>(type: "REAL", nullable: false),
                    BYN = table.Column<double>(type: "REAL", nullable: false),
                    BZD = table.Column<double>(type: "REAL", nullable: false),
                    CAD = table.Column<double>(type: "REAL", nullable: false),
                    CDF = table.Column<double>(type: "REAL", nullable: false),
                    CHF = table.Column<double>(type: "REAL", nullable: false),
                    CLF = table.Column<double>(type: "REAL", nullable: false),
                    CLP = table.Column<double>(type: "REAL", nullable: false),
                    CNH = table.Column<double>(type: "REAL", nullable: false),
                    CNY = table.Column<double>(type: "REAL", nullable: false),
                    COP = table.Column<double>(type: "REAL", nullable: false),
                    CRC = table.Column<double>(type: "REAL", nullable: false),
                    CUC = table.Column<double>(type: "REAL", nullable: false),
                    CUP = table.Column<double>(type: "REAL", nullable: false),
                    CVE = table.Column<double>(type: "REAL", nullable: false),
                    CZK = table.Column<double>(type: "REAL", nullable: false),
                    DJF = table.Column<double>(type: "REAL", nullable: false),
                    DKK = table.Column<double>(type: "REAL", nullable: false),
                    DOP = table.Column<double>(type: "REAL", nullable: false),
                    DZD = table.Column<double>(type: "REAL", nullable: false),
                    EGP = table.Column<double>(type: "REAL", nullable: false),
                    ERN = table.Column<double>(type: "REAL", nullable: false),
                    ETB = table.Column<double>(type: "REAL", nullable: false),
                    EUR = table.Column<double>(type: "REAL", nullable: false),
                    FJD = table.Column<double>(type: "REAL", nullable: false),
                    FKP = table.Column<double>(type: "REAL", nullable: false),
                    GBP = table.Column<double>(type: "REAL", nullable: false),
                    GEL = table.Column<double>(type: "REAL", nullable: false),
                    GGP = table.Column<double>(type: "REAL", nullable: false),
                    GHS = table.Column<double>(type: "REAL", nullable: false),
                    GIP = table.Column<double>(type: "REAL", nullable: false),
                    GMD = table.Column<double>(type: "REAL", nullable: false),
                    GNF = table.Column<double>(type: "REAL", nullable: false),
                    GTQ = table.Column<double>(type: "REAL", nullable: false),
                    GYD = table.Column<double>(type: "REAL", nullable: false),
                    HKD = table.Column<double>(type: "REAL", nullable: false),
                    HNL = table.Column<double>(type: "REAL", nullable: false),
                    HRK = table.Column<double>(type: "REAL", nullable: false),
                    HTG = table.Column<double>(type: "REAL", nullable: false),
                    HUF = table.Column<double>(type: "REAL", nullable: false),
                    IDR = table.Column<double>(type: "REAL", nullable: false),
                    ILS = table.Column<double>(type: "REAL", nullable: false),
                    IMP = table.Column<double>(type: "REAL", nullable: false),
                    INR = table.Column<double>(type: "REAL", nullable: false),
                    IQD = table.Column<double>(type: "REAL", nullable: false),
                    IRR = table.Column<double>(type: "REAL", nullable: false),
                    ISK = table.Column<double>(type: "REAL", nullable: false),
                    JEP = table.Column<double>(type: "REAL", nullable: false),
                    JMD = table.Column<double>(type: "REAL", nullable: false),
                    JOD = table.Column<double>(type: "REAL", nullable: false),
                    JPY = table.Column<double>(type: "REAL", nullable: false),
                    KES = table.Column<double>(type: "REAL", nullable: false),
                    KGS = table.Column<double>(type: "REAL", nullable: false),
                    KHR = table.Column<double>(type: "REAL", nullable: false),
                    KMF = table.Column<double>(type: "REAL", nullable: false),
                    KPW = table.Column<double>(type: "REAL", nullable: false),
                    KRW = table.Column<double>(type: "REAL", nullable: false),
                    KWD = table.Column<double>(type: "REAL", nullable: false),
                    KYD = table.Column<double>(type: "REAL", nullable: false),
                    KZT = table.Column<double>(type: "REAL", nullable: false),
                    LAK = table.Column<double>(type: "REAL", nullable: false),
                    LBP = table.Column<double>(type: "REAL", nullable: false),
                    LKR = table.Column<double>(type: "REAL", nullable: false),
                    LRD = table.Column<double>(type: "REAL", nullable: false),
                    LSL = table.Column<double>(type: "REAL", nullable: false),
                    LYD = table.Column<double>(type: "REAL", nullable: false),
                    MAD = table.Column<double>(type: "REAL", nullable: false),
                    MDL = table.Column<double>(type: "REAL", nullable: false),
                    MGA = table.Column<double>(type: "REAL", nullable: false),
                    MKD = table.Column<double>(type: "REAL", nullable: false),
                    MMK = table.Column<double>(type: "REAL", nullable: false),
                    MNT = table.Column<double>(type: "REAL", nullable: false),
                    MOP = table.Column<double>(type: "REAL", nullable: false),
                    MRO = table.Column<double>(type: "REAL", nullable: false),
                    MRU = table.Column<double>(type: "REAL", nullable: false),
                    MUR = table.Column<double>(type: "REAL", nullable: false),
                    MVR = table.Column<double>(type: "REAL", nullable: false),
                    MWK = table.Column<double>(type: "REAL", nullable: false),
                    MXN = table.Column<double>(type: "REAL", nullable: false),
                    MYR = table.Column<double>(type: "REAL", nullable: false),
                    MZN = table.Column<double>(type: "REAL", nullable: false),
                    NAD = table.Column<double>(type: "REAL", nullable: false),
                    NGN = table.Column<double>(type: "REAL", nullable: false),
                    NIO = table.Column<double>(type: "REAL", nullable: false),
                    NOK = table.Column<double>(type: "REAL", nullable: false),
                    NPR = table.Column<double>(type: "REAL", nullable: false),
                    NZD = table.Column<double>(type: "REAL", nullable: false),
                    OMR = table.Column<double>(type: "REAL", nullable: false),
                    PAB = table.Column<double>(type: "REAL", nullable: false),
                    PEN = table.Column<double>(type: "REAL", nullable: false),
                    PGK = table.Column<double>(type: "REAL", nullable: false),
                    PHP = table.Column<double>(type: "REAL", nullable: false),
                    PKR = table.Column<double>(type: "REAL", nullable: false),
                    PLN = table.Column<double>(type: "REAL", nullable: false),
                    PYG = table.Column<double>(type: "REAL", nullable: false),
                    QAR = table.Column<double>(type: "REAL", nullable: false),
                    RON = table.Column<double>(type: "REAL", nullable: false),
                    RSD = table.Column<double>(type: "REAL", nullable: false),
                    RUB = table.Column<double>(type: "REAL", nullable: false),
                    RWF = table.Column<double>(type: "REAL", nullable: false),
                    SAR = table.Column<double>(type: "REAL", nullable: false),
                    SBD = table.Column<double>(type: "REAL", nullable: false),
                    SCR = table.Column<double>(type: "REAL", nullable: false),
                    SDG = table.Column<double>(type: "REAL", nullable: false),
                    SEK = table.Column<double>(type: "REAL", nullable: false),
                    SGD = table.Column<double>(type: "REAL", nullable: false),
                    SHP = table.Column<double>(type: "REAL", nullable: false),
                    SLL = table.Column<double>(type: "REAL", nullable: false),
                    SOS = table.Column<double>(type: "REAL", nullable: false),
                    SRD = table.Column<double>(type: "REAL", nullable: false),
                    SSP = table.Column<double>(type: "REAL", nullable: false),
                    STD = table.Column<double>(type: "REAL", nullable: false),
                    STN = table.Column<double>(type: "REAL", nullable: false),
                    SVC = table.Column<double>(type: "REAL", nullable: false),
                    SYP = table.Column<double>(type: "REAL", nullable: false),
                    SZL = table.Column<double>(type: "REAL", nullable: false),
                    THB = table.Column<double>(type: "REAL", nullable: false),
                    TJS = table.Column<double>(type: "REAL", nullable: false),
                    TMT = table.Column<double>(type: "REAL", nullable: false),
                    TND = table.Column<double>(type: "REAL", nullable: false),
                    TOP = table.Column<double>(type: "REAL", nullable: false),
                    TRY = table.Column<double>(type: "REAL", nullable: false),
                    TTD = table.Column<double>(type: "REAL", nullable: false),
                    TWD = table.Column<double>(type: "REAL", nullable: false),
                    TZS = table.Column<double>(type: "REAL", nullable: false),
                    UAH = table.Column<double>(type: "REAL", nullable: false),
                    UGX = table.Column<double>(type: "REAL", nullable: false),
                    USD = table.Column<double>(type: "REAL", nullable: false),
                    UYU = table.Column<double>(type: "REAL", nullable: false),
                    UZS = table.Column<double>(type: "REAL", nullable: false),
                    VES = table.Column<double>(type: "REAL", nullable: false),
                    VND = table.Column<double>(type: "REAL", nullable: false),
                    VUV = table.Column<double>(type: "REAL", nullable: false),
                    WST = table.Column<double>(type: "REAL", nullable: false),
                    XAF = table.Column<double>(type: "REAL", nullable: false),
                    XAG = table.Column<double>(type: "REAL", nullable: false),
                    XAU = table.Column<double>(type: "REAL", nullable: false),
                    XCD = table.Column<double>(type: "REAL", nullable: false),
                    XDR = table.Column<double>(type: "REAL", nullable: false),
                    XOF = table.Column<double>(type: "REAL", nullable: false),
                    XPD = table.Column<double>(type: "REAL", nullable: false),
                    XPF = table.Column<double>(type: "REAL", nullable: false),
                    XPT = table.Column<double>(type: "REAL", nullable: false),
                    YER = table.Column<double>(type: "REAL", nullable: false),
                    ZAR = table.Column<double>(type: "REAL", nullable: false),
                    ZMW = table.Column<double>(type: "REAL", nullable: false),
                    ZWL = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");
        }
    }
}
