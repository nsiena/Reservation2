using System;

namespace 会議室予約.Domain
{
    /// <summary>
    /// 予約ルートエンティティ
    /// </summary>
    public class 予約
    {
        private 予約者 よやくしゃ;
        private 利用期間 りようきかん;
        private 会議室 かいぎしつ;
        private 会議参加予定者 かいぎさんかよていしゃ;

        public 予約(予約者 よやくしゃ, 利用期間 りようきかん, 会議室 かいぎしつ, 会議参加予定者 かいぎさんかよていしゃ)
        {
            // 予約可能かどうか判定する?
            
            this.よやくしゃ = よやくしゃ;
            this.りようきかん = りようきかん;
            this.かいぎしつ = かいぎしつ;
            this.かいぎさんかよていしゃ = かいぎさんかよていしゃ;
        }
        
        // 操作・メソッド考える？
        // public 予約()
        // {
        //     if(予約可能ルール().isOK())
        // }
    }
    public class 利用期間
    {
        // private 開始年月日時分 かいしねんがっぴじふん;
        // private 終了年月日時分 しゅうりょうねんがっぴじふん;
        private 開始年月日時分 かいしねんがっぴじふん;
        private 終了年月日時分 しゅうりょうねんがっぴじふん;

        public 利用期間(開始年月日時分 かいしねんがっぴじふん, 終了年月日時分 しゅうりょうねんがっぴじふん, DateTime きょうのひづけ)
        {
            if(!new 予約可能ルール(かいしねんがっぴじふん, しゅうりょうねんがっぴじふん, きょうのひづけ).isSatisfied())
                throw new ArgumentException();
 
            this.かいしねんがっぴじふん = かいしねんがっぴじふん;
            this.しゅうりょうねんがっぴじふん = しゅうりょうねんがっぴじふん;
        }
    }
}

