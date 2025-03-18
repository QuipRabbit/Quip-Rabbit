// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;

namespace ChainSafe.Gaming.WalletConnect.Dialog
{
    public class CustomConnectionDialogChainSafe : ConnectionDialogBase
    {
        public new Animation animation;
        public string showAnimationClipName;
        public string hideAnimationClipName;
        public RawImage qrCodeImage;
        public Vector2Int qrCodeSize = new(512, 512);
        public int qrCodePadding = 20;
        public GameObject qrCodePanel;
        public GameObject localWalletButtonsPanel;
        public LocalWalletButton localWalletButtonPrefab;
        public RectTransform localWalletButtonsContainer;
        public GameObject singleButtonForLocalWalletsPanel;
        public Button singleButtonForLocalWallets;

        private Result result;
        private LocalWalletButton[] loadedLocalWalletButtons;

        public static CustomConnectionDialogChainSafe instance;

        private void Awake()
        {
            instance = this;
            singleButtonForLocalWallets.onClick.AddListener(OpenLocalWalletOsManaged);
        }

        void Start()
        {
            DecodeQRCode();
            Transform childCanvasError = UnityPackage.Web3Unity.ConnectModal.transform.Find("Canvas_Error");
            if (childCanvasError != null)
            {
                childCanvasError.gameObject.SetActive(false);
            }
        }

        void DecodeQRCode()
        {
            Texture2D qrTexture = qrCodeImage.texture as Texture2D;

            Color32[] pixels = qrTexture.GetPixels32();
            int width = qrTexture.width;
            int height = qrTexture.height;

            BarcodeReader reader = new BarcodeReader();
            result = reader.Decode(pixels, width, height);
        }

        public void RedirectToMetamask()
        {
            Application.OpenURL(result.Text);
        }

        protected override void PlayShowDialog() => animation.Play(showAnimationClipName);
        protected override void PlayHideDialog() => animation.Play(hideAnimationClipName);

        protected override void SetRedirectOptionsVisible(bool visible) => localWalletButtonsPanel.SetActive(false);
        protected override void SetQrCodeElementVisible(bool visible) => qrCodePanel.SetActive(false);

        protected override void SetSingleButtonForRedirectVisible(bool visible) =>
            singleButtonForLocalWalletsPanel.SetActive(false);

        protected override void SpawnRedirectOptions(List<WalletOptionConfig> supportedWallets)
        {
            loadedLocalWalletButtons = supportedWallets
                .Select(w =>
                {
                    var button = Instantiate(localWalletButtonPrefab, localWalletButtonsContainer);
                    button.Set(w.Data, w.OnClick);
                    return button;
                })
                .ToArray();
        }

        protected override void CreateQrCodeElement(QrCodeBuilder builder)
        {
            qrCodeImage.texture = builder.GenerateQrCode(new QrCodeEncodingOptions
            {
                Width = qrCodeSize.x,
                Height = qrCodeSize.y,
                Margin = qrCodePadding
            }
            );
        }

        protected override void ClearDynamicElements()
        {
            if (loadedLocalWalletButtons != null)
            {
                foreach (var localWalletButton in loadedLocalWalletButtons)
                {
                    Destroy(localWalletButton.gameObject);
                }

                loadedLocalWalletButtons = null;
            }
        }

        public void Close()
        {
            OnException(new Exception("User closed the connection dialog."));
            Destroy(gameObject);
        }
    }
}

// Support us by participating in Quip Rabbit pre-sale (ICO), we will share all the game source codes after the sale reaches the hard cap. Thank you very much.
