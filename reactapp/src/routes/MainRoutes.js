import { lazy } from 'react';

// project imports
import MainLayout from 'layout/MainLayout';
import Loadable from 'ui-component/Loadable';

// dashboard routing
const DashboardDefault = Loadable(lazy(() => import('views/dashboard/Default')));

// digerIslemler routing
const Musteriler = Loadable(lazy(() => import('views/digerIslemler/Musteriler/MusteriListesi')));
const MusteriEkle = Loadable(lazy(() => import('views/digerIslemler/Musteriler/MusteriEkle')));
const Urunler = Loadable(lazy(() => import('views/digerIslemler/Urunler/UrunListesi')));
const UrunEkle = Loadable(lazy(() => import('views/digerIslemler/Urunler/UrunEkle')));
const UrunDetay = Loadable(lazy(() => import('views/digerIslemler/Urunler/UrunDetay')));
const TeklifOlustur = Loadable(lazy(() => import('views/digerIslemler/Teklifler/TeklifOlustur')));
const Tekliflerim = Loadable(lazy(() => import('views/digerIslemler/Teklifler/Tekliflerim')));
const Kategoriler = Loadable(lazy(() => import('views/digerIslemler/Kategoriler/KategoriListesi')));
const KategoriEkle = Loadable(lazy(() => import('views/digerIslemler/Kategoriler/KategoriEkle')));

// utilities routing
const UtilsTypography = Loadable(lazy(() => import('views/utilities/Typography')));
const UtilsColor = Loadable(lazy(() => import('views/utilities/Color')));
const UtilsShadow = Loadable(lazy(() => import('views/utilities/Shadow')));
const UtilsMaterialIcons = Loadable(lazy(() => import('views/utilities/MaterialIcons')));
const UtilsTablerIcons = Loadable(lazy(() => import('views/utilities/TablerIcons')));

// sample page routing
const SamplePage = Loadable(lazy(() => import('views/sample-page')));
const SamplePage2 = Loadable(lazy(() => import('views/sample-page-2')));

// ==============================|| MAIN ROUTING ||============================== //

const MainRoutes = {
    path: '/',
    element: <MainLayout />,
    children: [
        {
            path: '/',
            element: <DashboardDefault />
        },
        {
            path: 'dashboard',
            children: [
                {
                    path: 'default',
                    element: <DashboardDefault />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-typography',
                    element: <UtilsTypography />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-color',
                    element: <UtilsColor />
                }
            ]
        },
        {
            path: 'utils',
            children: [
                {
                    path: 'util-shadow',
                    element: <UtilsShadow />
                }
            ]
        },
        {
            path: 'icons',
            children: [
                {
                    path: 'tabler-icons',
                    element: <UtilsTablerIcons />
                }
            ]
        },
        {
            path: 'icons',
            children: [
                {
                    path: 'material-icons',
                    element: <UtilsMaterialIcons />
                }
            ]
        },
        {
            path: 'sample-page',
            element: <SamplePage />
        },
        {
            path: 'sample-page-2',
            element: <SamplePage2 />
        },
        {
            path: 'digerIslemler',
            children: [
                {
                    path: 'musteriler',
                    element: <Musteriler />
                },
                {
                    path: 'musteri-ekle',
                    element: <MusteriEkle />
                },
                {
                    path: 'musteri-duzenle/:id',
                    element: <MusteriEkle />
                },
                {
                    path: 'urunler',
                    element: <Urunler />
                },
                {
                    path: 'urun-ekle',
                    element: <UrunEkle />
                },
                {
                    path: 'urun-duzenle/:id',
                    element: <UrunEkle />
                },
                {
                    path: 'urun-detay/:id',
                    element: <UrunDetay />
                },
                {
                    path: 'tekliflerim',
                    element: <Tekliflerim />
                },
                {
                    path: 'teklif-olustur',
                    element: <TeklifOlustur />
                },
                {
                    path: 'kategoriler',
                    element: <Kategoriler />
                },
                {
                    path: 'kategori-ekle',
                    element: <KategoriEkle />
                },
                {
                    path: 'kategori-duzenle/:id',
                    element: <KategoriEkle />
                }
            ]
        }
    ]
};

export default MainRoutes;
